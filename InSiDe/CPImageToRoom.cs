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
  public partial class CPImageToRoom : ControlPanelForm
  {
    public CPImageToRoom()
    {
      InitializeComponent();
    }

    public override void Process(String compName, ResourcePack rp)
    {
      Int32 numTilesWide = (TargetBitmap.Width) / (Constants.TileSize);
      Int32 numTilesHigh = (TargetBitmap.Height) / (Constants.TileSize);

      Room r = new Room();
      r.Name = compName;

      Int32 numTilesAdded = 0;
      for (Int32 y = 0; y < numTilesHigh; y++)
      {
        for (Int32 x = 0; x < numTilesWide; x++)
        {
          Tile b = new Tile();

          Int32 tileX = x * (Constants.TileSize);
          Int32 tileY = y * (Constants.TileSize);

          b.SliceFromBitmap(TargetBitmap, tileX, tileY);
          b.Name = compName;

          if (rp.Add(b))
          {
            numTilesAdded++;
          }

          r.SetTile(x, y, b);
        }
      }

      rp.Add(r);
    }
  }
}
