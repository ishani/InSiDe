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
  public partial class CPImageToTile : ControlPanelForm
  {
    public CPImageToTile()
    {
      InitializeComponent();
    }

    public override void Process(String compName, ResourcePack rp)
    {
      Int32 gapX = (Int32)gapInX.Value;
      Int32 gapY = (Int32)gapInY.Value;

      Bitmap edgedBitmap = new Bitmap(TargetBitmap, TargetBitmap.Width + Constants.TileSize, TargetBitmap.Height + Constants.TileSize);
      using (Graphics edgeGfx = Graphics.FromImage(edgedBitmap))
      {
        edgeGfx.Clear(colourSwatch.BackColor);

        edgeGfx.InterpolationMode = InterpolationMode.NearestNeighbor;
        edgeGfx.DrawImage(TargetBitmap, new Rectangle(0, 0, TargetBitmap.Width, TargetBitmap.Height), 0, 0, TargetBitmap.Width, TargetBitmap.Height, GraphicsUnit.Pixel);
      }

      Int32 curX = 0, curY = 0;
      while (curY < TargetBitmap.Height)
      {
        while (curX < TargetBitmap.Width)
        {
          Tile b = new Tile();

          b.SliceFromBitmap(edgedBitmap, curX, curY);
          b.Name = compName;

          rp.Add(b);

          curX += Constants.TileSize + gapX;
        }

        curX = 0;
        curY += Constants.TileSize + gapY;
      }
    }

    private void chooseBG_Click(object sender, EventArgs e)
    {
      if (colourDialog.ShowDialog() == DialogResult.OK)
      {
        colourSwatch.BackColor = colourDialog.Color;
      }
    }
  }
}
