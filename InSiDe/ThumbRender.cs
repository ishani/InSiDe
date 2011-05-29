using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Manina.Windows.Forms;

namespace InSiDe
{

  public class ThumbRenderer : Manina.Windows.Forms.ImageListView.ImageListViewRenderer
  {
    private const Int32 mRefGap = 16;
    private int padding;
    private Font foreFont;
    private TextureBrush patternBrush = null;

    /// <summary>
    /// Initializes a new instance of the ThumbRenderer class.
    /// </summary>
    public ThumbRenderer(Int32 padding, bool patternBG)
    {
      this.padding = padding;
      foreFont = new Font("Courier New", 8);

      if (patternBG)
      {
        Bitmap pattern = new Bitmap(10, 10);
        using (Graphics gfx = Graphics.FromImage(pattern))
        {
          gfx.Clear(Color.FromArgb(16, 16, 16));
          gfx.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), 0, 0, 5.0f, 5.0f);
          gfx.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), 5.0f, 5.0f, 10.0f, 10.0f);
        }
        patternBrush = new TextureBrush(pattern);
      }
    }


    /// <summary>
    /// Draws the background of the control.
    /// </summary>
    /// <param name="g">The System.Drawing.Graphics to draw on.</param>
    /// <param name="bounds">The client coordinates of the item area.</param>
    public override void DrawBackground(Graphics g, Rectangle bounds)
    {
      if (patternBrush == null)
        g.Clear(Color.FromArgb(16, 16, 16));
      else
        g.FillRectangle(patternBrush, bounds);
    }

    /// <summary>
    /// Returns item size for the given view mode.
    /// </summary>
    /// <param name="view">The view mode for which the measurement should be made.</param>
    /// <returns></returns>
    public override Size MeasureItem(Manina.Windows.Forms.View view)
    {
      if (view == Manina.Windows.Forms.View.Details)
        return base.MeasureItem(view);
      else
        return new Size(ImageListView.ThumbnailSize.Width + 2 * padding,
            ImageListView.ThumbnailSize.Height + 2 * padding + mRefGap);
    }

    /// <summary>
    /// Draws the specified item on the given graphics.
    /// </summary>
    /// <param name="g">The System.Drawing.Graphics to draw on.</param>
    /// <param name="item">The ImageListViewItem to draw.</param>
    /// <param name="state">The current view state of item.</param>
    /// <param name="bounds">The bounding rectangle of item in client coordinates.</param>
    public override void DrawItem(Graphics g, ImageListViewItem item, ItemState state, Rectangle bounds)
    {
      // Item background color
      if (patternBrush == null)
      {
        using (Brush brush = new SolidBrush(Color.FromArgb(16, 16, 16)))
        {
          g.FillRectangle(brush, bounds);
        }
      }

      // Align images to bottom of bounds
      Image img = item.ThumbnailImage;
      Rectangle pos = Manina.Windows.Forms.Utility.GetSizedImageBounds(img,
          new Rectangle(bounds.X + padding, bounds.Y + padding, bounds.Width - 2 * padding, bounds.Height - 2 * padding - mRefGap),
          50.0f, 100.0f);

      int x = pos.X;
      int y = pos.Y;

      int surround = padding - 1;


      // Border
      if ((state & ItemState.Hovered) == ItemState.Hovered)
      {
        using (Brush brush = new LinearGradientBrush(
            new Point(x - surround, y - surround), new Point(x - surround, y + pos.Height + 2 * surround),
            Color.FromArgb(128, 250, 200, 40), Color.FromArgb(128, 250, 200, 40)))
        using (Pen pen = new Pen(brush, 2))
        {
          g.DrawRectangle(pen, x - surround, y - surround + 1, pos.Width + 2 * surround, pos.Height + 2 * surround);
        }
      }
      else if ((state & ItemState.Selected) == ItemState.Selected)
      {
        using (Brush brush = new LinearGradientBrush(
            new Point(x - surround, y - surround), new Point(x - surround, y + pos.Height + 2 * surround),
            Color.FromArgb(255, 220, 40), Color.FromArgb(250, 200, 40)))
        using (Pen pen = new Pen(brush, 2))
        {
          g.DrawRectangle(pen, x - surround, y - surround + 1, pos.Width + 2 * surround, pos.Height + 2 * surround);
        }
      }
      else
      {
        using (Brush brush = new SolidBrush(Color.FromArgb(64, 180, 180, 180)))
        using (Pen pen = new Pen(brush, 1))
        {
          g.DrawRectangle(pen, x - 1, y, pos.Width, pos.Height);
        }
      }

      g.DrawImageUnscaled(img, pos.X, pos.Y + 1);
      g.DrawString(item.Text, foreFont, Brushes.White, pos.X, pos.Y + img.Height + 4);
    }
    /// <summary>
    /// Draws the checkbox icon for the specified item on the given graphics.
    /// </summary>
    /// <param name="g">The System.Drawing.Graphics to draw on.</param>
    /// <param name="item">The ImageListViewItem to draw.</param>
    /// <param name="bounds">The bounding rectangle of the checkbox in client coordinates.</param>
    public override void DrawCheckBox(Graphics g, ImageListViewItem item, Rectangle bounds)
    {

    }
    /// <summary>
    /// Draws the file icon for the specified item on the given graphics.
    /// </summary>
    /// <param name="g">The System.Drawing.Graphics to draw on.</param>
    /// <param name="item">The ImageListViewItem to draw.</param>
    /// <param name="bounds">The bounding rectangle of the file icon in client coordinates.</param>
    public override void DrawFileIcon(Graphics g, ImageListViewItem item, Rectangle bounds)
    {
    }

    /// <summary>
    /// Draws the column headers.
    /// </summary>
    /// <param name="g">The System.Drawing.Graphics to draw on.</param>
    /// <param name="column">The ImageListViewColumnHeader to draw.</param>
    /// <param name="state">The current view state of column.</param>
    /// <param name="bounds">The bounding rectangle of column in client coordinates.</param>
    public override void DrawColumnHeader(Graphics g, ImageListView.ImageListViewColumnHeader column, ColumnState state, Rectangle bounds)
    {
    }

    /// <summary>
    /// Draws the extender after the last column.
    /// </summary>
    /// <param name="g">The System.Drawing.Graphics to draw on.</param>
    /// <param name="bounds">The bounding rectangle of extender column in client coordinates.</param>
    public override void DrawColumnExtender(Graphics g, Rectangle bounds)
    {
    }

    /// <summary>
    /// Draws the large preview image of the focused item in Gallery mode.
    /// </summary>
    /// <param name="g">The System.Drawing.Graphics to draw on.</param>
    /// <param name="item">The ImageListViewItem to draw.</param>
    /// <param name="image">The image to draw.</param>
    /// <param name="bounds">The bounding rectangle of the preview area.</param>
    public override void DrawGalleryImage(Graphics g, ImageListViewItem item, Image image, Rectangle bounds)
    {
    }

    /// <summary>
    /// Draws the left pane in Pane view mode.
    /// </summary>
    /// <param name="g">The System.Drawing.Graphics to draw on.</param>
    /// <param name="item">The ImageListViewItem to draw.</param>
    /// <param name="image">The image to draw.</param>
    /// <param name="bounds">The bounding rectangle of the pane.</param>
    public override void DrawPane(Graphics g, ImageListViewItem item, Image image, Rectangle bounds)
    {
    }

    /// <summary>
    /// Draws the selection rectangle.
    /// </summary>
    /// <param name="g">The System.Drawing.Graphics to draw on.</param>
    /// <param name="selection">The client coordinates of the selection rectangle.</param>
    public override void DrawSelectionRectangle(Graphics g, Rectangle selection)
    {
      using (Brush brush = new LinearGradientBrush(selection,
          Color.FromArgb(160, 96, 144, 240), Color.FromArgb(32, 96, 144, 240),
          LinearGradientMode.ForwardDiagonal))
      {
        g.FillRectangle(brush, selection);
      }
      using (Brush brush = new LinearGradientBrush(selection,
          Color.FromArgb(96, 144, 240), Color.FromArgb(128, 96, 144, 240),
          LinearGradientMode.ForwardDiagonal))
      using (Pen pen = new Pen(brush))
      {
        g.DrawRectangle(pen, selection);
      }
    }
    /// <summary>
    /// Draws the insertion caret for drag and drop operations.
    /// </summary>
    /// <param name="g">The System.Drawing.Graphics to draw on.</param>
    /// <param name="bounds">The bounding rectangle of the insertion caret.</param>
    public override void DrawInsertionCaret(Graphics g, Rectangle bounds)
    {
      using (Brush b = new SolidBrush(Color.FromArgb(96, 144, 240)))
      {
        g.FillRectangle(b, bounds);
      }
    }
  }

}
