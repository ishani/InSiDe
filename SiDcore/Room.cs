/**
 * SiDcore ~ a C# class library for creating and manipulating data for Jason Rohrer's Sleep Is Death (http://sleepisdeath.net/)
 * 
 * Written by Harry Denholm (Ishani) April 2010
 * http://www.ishani.org/
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace SiDcore
{
  /**
   * Room is a 13x13 pile of Tiles, making up a background panel for a story
   */
  [ResourceTypeAttribute("room")]
  public class Room : SiDComponent
  {
    public delegate void IterateRoomDataDelegate(Int32 x, Int32 y, ref UID uid);

    /**
     * set individual tile at x,y
     */
    public void SetTile(Int32 x, Int32 y, Tile t)
    {
      layout[x, y] = t.getUID();
    }


    /**
     * iterator for general purpose access to internal data
     */
    public void Iterate(IterateRoomDataDelegate irdd)
    {
      for (Int32 y = 0; y < Constants.RoomSize; y++)
      {
        for (Int32 x = 0; x < Constants.RoomSize; x++)
        {
          irdd(x, y, ref layout[x, y]);
        }
      }
    }

    // SiDComponent
    override public Bitmap RenderToBitmap(ResourcePack rp)
    {
      Bitmap tb = new Bitmap(Constants.RoomSize * Constants.TileSize, Constants.RoomSize * Constants.TileSize, PixelFormat.Format24bppRgb);
      Graphics gfx = Graphics.FromImage(tb);

      // rendering a room is pretty simple; just draw each tile, unscaled, in a grid
      Iterate((Int32 x, Int32 y, ref UID uid) =>
      {
        if (uid != null)
        {
          Tile t = rp.LookupByUID(uid) as Tile;
          if (t != null)
          {
            Bitmap tBmp = t.RenderToBitmap(rp);
            gfx.DrawImageUnscaled(tBmp, x * Constants.TileSize, y * Constants.TileSize);
          }
          else
          {
            // missing tile
            gfx.FillRectangle(Brushes.Magenta, x * Constants.TileSize, y * Constants.TileSize, 16.0f, 16.0f);
          }
        }
      });

      gfx.Dispose();
      return tb;
    }

    // SiDComponent
    override public void LoadFromByteStream(BinaryReader br, Int32 streamLength)
    {
      Iterate((Int32 x, Int32 y, ref UID uid) =>
      {
        byte[] uidbytes = br.ReadBytes(6);
        uid = new UID(uidbytes);
      });

      for (Int32 y = 0; y < Constants.RoomSize; y++)
      {
        for (Int32 x = 0; x < Constants.RoomSize; x++)
        {
          wallFlags[x, y] = br.ReadByte();
        }
      }

      Name = ByteUtils.readNullTermString11(br);
    }

    // SiDComponent
    override public byte[] SaveToByteStream()
    {
      List<byte> byteStream = new List<byte>(1064);

      Iterate((Int32 x, Int32 y, ref UID uid) =>
      {
        // this magic number is the SHA1 of a blank, empty tile
        UID uidToStore = new UID(new byte[6] { 0x88, 0xBB, 0xE0, 0xFB, 0x7B, 0x40 });
        if (uid != null)
        {
          uidToStore = uid;
        }

        // each tile is stored by UID
        byteStream.AddRange(uidToStore.UIDBytes);
      });

      for (Int32 y = 0; y < Constants.RoomSize; y++)
      {
        for (Int32 x = 0; x < Constants.RoomSize; x++)
        {
          byteStream.Add(wallFlags[x, y]);
        }
      }

      // append tile name
      byte[] stringBytes = ASCIIEncoding.UTF8.GetBytes(Name);
      byteStream.AddRange(stringBytes);
      byteStream.Add(0); // terminate

      return byteStream.ToArray();
    }

    private UID[,] layout = new UID[Constants.RoomSize, Constants.RoomSize];
    private byte[,] wallFlags = new byte[Constants.RoomSize, Constants.RoomSize];
  }
}
