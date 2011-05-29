using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SiDcore;

namespace InSiDe
{
  public partial class CPImageToObject : ControlPanelForm
  {
    struct ExtractedObject
    {
      public Rectangle bounds;
      public List<Rectangle> slices;

      public ExtractedObject(Rectangle b)
      {
        bounds = b;
        slices = new List<Rectangle>(8);
      }

      public override string ToString()
      {
        return String.Format("[{0},{1}] {2}x{3}", bounds.Left, bounds.Top, bounds.Width, bounds.Height);
      }
    }

    public CPImageToObject()
    {
      InitializeComponent();
    }

    List<ExtractedObject> ObjectExtents = new List<ExtractedObject>(16);

    Rectangle ExtractExtentsFromArea(BitmapData bmpData, Int32 xStart, Int32 searchWidth, Int32 yStart, Int32 searchHeight)
    {
      Point minBound = new Point(TargetBitmap.Width, TargetBitmap.Height);
      Point maxBound = new Point(0, 0);

      Int32 targetX = Math.Min(bmpData.Width, xStart + searchWidth);
      Int32 targetY = Math.Min(bmpData.Height, yStart + searchHeight);
      unsafe
      {
        for (int y = yStart; y < targetY; y++)
        {
          byte* row = (byte*)bmpData.Scan0 + (y * bmpData.Stride);
          for (int x = xStart; x < targetX; x++)
          {
            Int32 xP = x * 4;
            if (row[(x * 4) + 3] > 128)
            {
              if (x > maxBound.X)
                maxBound.X = x;
              if (x < minBound.X)
                minBound.X = x;
              if (y > maxBound.Y)
                maxBound.Y = y;
              if (y < minBound.Y)
                minBound.Y = y;
            }
          }
        }
      }

      return new Rectangle(
        minBound.X, 
        minBound.Y, 
        maxBound.X - minBound.X, 
        maxBound.Y - minBound.Y);
    }

    void FindObjectExtents()
    {
      lbSubs.Items.Clear();
      ObjectExtents.Clear();

      Int32 objectSpacingX = (Int32)spacingX.Value;
      Int32 objectSpacingY = (Int32)spacingY.Value;

      if (!extractMultiple.Checked)
      {
        objectSpacingX = TargetBitmap.Width;
        objectSpacingY = TargetBitmap.Height;
      }

      BitmapData bmpData = TargetBitmap.LockBits(new Rectangle(0, 0, TargetBitmap.Width, TargetBitmap.Height), ImageLockMode.ReadOnly, TargetBitmap.PixelFormat);
      {
        Int32 curX = 0, curY = 0;
        while (curY < bmpData.Height)
        {
          while (curX < bmpData.Width)
          {
            Rectangle ext = ExtractExtentsFromArea(bmpData, curX, objectSpacingX, curY, objectSpacingY);
            if (ext.Width > 0 && ext.Height > 0)
            {
              ExtractedObject eo = new ExtractedObject(
                findInnerEdges.Checked ? ext : new Rectangle(curX, curY, objectSpacingX, objectSpacingY));

              ObjectExtents.Add(eo);
              lbSubs.Items.Add(eo);
            }

            curX += objectSpacingX;
          }

          curX = 0;
          curY += objectSpacingY;
        }
      }
      TargetBitmap.UnlockBits(bmpData);

      foreach (ExtractedObject eo in ObjectExtents)
      {
        CreateTileSlices(eo);
      }
    }

    public override void SetTargetBitmap(Bitmap targetBitmap)
    {
      base.SetTargetBitmap(targetBitmap);
      FindObjectExtents();
    }

    public delegate bool IterationOp(Int32 cur);
    void CreateTileSlices(ExtractedObject eo)
    {
      eo.slices.Clear();

      // configure for TopLeft y default
      Int32 curX = 0, curY = 0;
      Int32 deltaX = Constants.TileSize, deltaY = Constants.TileSize;
      IterationOp outer = cur => (cur < eo.bounds.Height),
                  inner = cur => (cur < eo.bounds.Width);

      if (edgeBL.Checked || edgeBR.Checked)
      {
        curY = eo.bounds.Height - Constants.TileSize;
        deltaY = -Constants.TileSize;

        outer = cur => (cur > -Constants.TileSize);
      }
      if (edgeTR.Checked || edgeBR.Checked)
      {
        curX = eo.bounds.Width - Constants.TileSize;
        deltaX = -Constants.TileSize;

        inner = cur => (cur > -Constants.TileSize);
      }

      Int32 xReset = curX;
      while (outer(curY))
      {
        while (inner(curX))
        {
          Rectangle sliceRect = new Rectangle(eo.bounds.Left + curX, eo.bounds.Top + curY, Constants.TileSize, Constants.TileSize);
          eo.slices.Add(sliceRect);

          curX += deltaX;
        }

        curX = xReset;
        curY += deltaY;
      }
    }

    static Brush ObjectHighlightBrush = new SolidBrush(Color.FromArgb(64, 255, 255, 255));

    void DrawSlicingGrid(Graphics g, bool drawGrid)
    {
      using (Pen gridPen = new Pen(colourSwatch.BackColor, 1.0f))
      {
        foreach (ExtractedObject eo in ObjectExtents)
        {
          bool shouldDraw = drawGrid;

          if (lbSubs.SelectedItems.Contains(eo))
          {
            g.FillRectangle(
              ObjectHighlightBrush, 
              eo.bounds.Left - 0.5f,
              eo.bounds.Top - 0.5f,
              eo.bounds.Width + 1.0f,
              eo.bounds.Height + 1.0f);
          }
          else
          {
            if (previewSel.Checked && extractMultiple.Checked)
              shouldDraw = false;
          }

          if (shouldDraw)
          {
            foreach (Rectangle r in eo.slices)
            {
              g.DrawRectangle(gridPen, r);
            }
          }
        }
      }
    }

    public override void Underlay(Graphics g)
    {
      DrawSlicingGrid(g, (previewUnder.Checked));
    }

    public override void Overlay(Graphics g)
    {
      DrawSlicingGrid(g, (previewOver.Checked));
    }


    public override void Process(String compName, ResourcePack rp)
    {
      const Int32 MidPoint = (Constants.RoomSize * Constants.TileSize) / 2;
      Point assembleAtPoint;


      Bitmap edgedBitmap = new Bitmap(TargetBitmap, TargetBitmap.Width + Constants.TileSize, TargetBitmap.Height + Constants.TileSize);
      edgedBitmap.MakeTransparent();

      using (Graphics edgeGfx = Graphics.FromImage(edgedBitmap))
      {
        edgeGfx.Clear(Color.Transparent);

        edgeGfx.InterpolationMode = InterpolationMode.NearestNeighbor;
        edgeGfx.DrawImage(TargetBitmap, new Rectangle(0, 0, TargetBitmap.Width, TargetBitmap.Height), 0, 0, TargetBitmap.Width, TargetBitmap.Height, GraphicsUnit.Pixel);
      }

      foreach (ExtractedObject eo in ObjectExtents)
      {
        StateObject ob = new StateObject();
        ob.Name = compName;

        if (alignToCenter.Checked)
          assembleAtPoint = new Point(MidPoint - eo.bounds.Width / 2, MidPoint - eo.bounds.Height / 2);
        else
          assembleAtPoint = new Point(0, 0);

        foreach (Rectangle r in eo.slices)
        {
          Sprite b = new Sprite();

          b.SliceFromBitmap(edgedBitmap, r.Left, r.Top, 128);
          b.Name = compName;

          rp.Add(b);
          ob.AddSprite(b, assembleAtPoint.X + (r.Left - eo.bounds.Left), assembleAtPoint.Y + (r.Top - eo.bounds.Top), 1.0f, false);
        }

        rp.Add(ob);
      }
    }


    private void RefreshPreviewPanel()
    {
      ImageImportForm iif = (Parent.Parent.Parent as ImageImportForm);
      iif.imagePreview.Refresh();
    }

    private void previewNone_CheckedChanged(object sender, EventArgs e)
    {
      chooseFG.Enabled = (!previewNone.Checked);
      RefreshPreviewPanel();
    }

    private void chooseFG_Click(object sender, EventArgs e)
    {
      if (colourDialog.ShowDialog() == DialogResult.OK)
      {
        colourSwatch.BackColor = colourDialog.Color;
      }
      RefreshPreviewPanel();
    }

    private void ExtractionValueChanged(object sender, EventArgs e)
    {
      FindObjectExtents();
      RefreshPreviewPanel();
    }

    private void lbSubs_SelectedIndexChanged(object sender, EventArgs e)
    {
      RefreshPreviewPanel();
    }

    private void extractMultiple_CheckedChanged(object sender, EventArgs e)
    {
      bool uiEnable = extractMultiple.Checked;
      lbSubs.Enabled = uiEnable;
      spacingX.Enabled = uiEnable;
      spacingY.Enabled = uiEnable;
      previewSel.Enabled = uiEnable;

      FindObjectExtents();
      RefreshPreviewPanel();
    }

    private void previewSel_CheckedChanged(object sender, EventArgs e)
    {
      RefreshPreviewPanel();
    }
  }
}
