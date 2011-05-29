using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using SiDcore;

namespace InSiDe
{
  public class ControlPanelForm : Form
  {
    internal Bitmap TargetBitmap = null;

    public virtual void SetTargetBitmap(Bitmap targetBitmap)
    {
      TargetBitmap = targetBitmap;
    }

    public virtual void Process(String compName, ResourcePack rp)
    {
      throw new NotImplementedException();
    }

    public virtual void Underlay(Graphics g)
    {
    }

    public virtual void Overlay(Graphics g)
    {
    }
  }
}
