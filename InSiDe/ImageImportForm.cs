using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SiDcore;

namespace InSiDe
{
  public partial class ImageImportForm : Form
  {
    Bitmap InputBitmap;
    Type SiDType;
    ResourcePack HostPack;
    ControlPanelForm ControlForm;

    float ZoomLevel = 1.0f;
    bool DarkBG = true;

    public ImageImportForm(Bitmap toSlice, Type configureToSiDType, ResourcePack rp, ControlPanelForm cpf)
    {
      InputBitmap = toSlice;
      SiDType = configureToSiDType;
      HostPack = rp;

      InitializeComponent();

      ControlForm = cpf;
      ControlPanel.SuspendLayout();
      {
        ControlForm.SetTargetBitmap(toSlice);
        ControlForm.TopLevel = false;
        ControlPanel.Controls.Add(ControlForm);
        ControlForm.Show();
      }
      ControlPanel.ResumeLayout();

      Text += String.Format("({0}) - {1}x{2}", configureToSiDType.Name, toSlice.Width, toSlice.Height);
    }

    private void doImport_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      ControlForm.Process(tbNameText.Text, HostPack);
      Cursor.Current = Cursors.Default;
    }


    private void imagePreview_Paint(object sender, PaintEventArgs e)
    {
      base.OnPaint(e);

      e.Graphics.ScaleTransform(ZoomLevel, ZoomLevel);
      e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;
      e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

      ControlForm.Underlay(e.Graphics);
      e.Graphics.DrawImage(InputBitmap, 0, 0);
      ControlForm.Overlay(e.Graphics);
    }

    private void zoomReset_Click(object sender, EventArgs e)
    {
      ZoomLevel = 1.0f;
      imagePreview.Refresh();
    
      zoomIn.Enabled = true;
    }

    private void zoomIn_Click(object sender, EventArgs e)
    {
      ZoomLevel += 1.0f;
      imagePreview.Refresh();

      if (ZoomLevel >= 8.0f)
        zoomIn.Enabled = false;
    }

    private void cycleBG_Click(object sender, EventArgs e)
    {
      DarkBG = !DarkBG;

      if (DarkBG)
        imagePreview.BackgroundImage = global::InSiDe.Properties.Resources.DarkBg;
      else
        imagePreview.BackgroundImage = global::InSiDe.Properties.Resources.LightBg;

      imagePreview.Refresh();
    }
  }
}
