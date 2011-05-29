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

namespace SiDcore
{
  /**
   * Tile represents a single 16x16 background sprite, used to construct Rooms (Scenes)
   *
   */
  [ResourceTypeAttribute("tile")]
  public class Tile : SiDComponent
  {
    public delegate void IterateTileDataDelegate(Int32 x, Int32 y, ref PixelRGBA pixel);

    /**
     * iterator for general purpose access to internal data
     */
    public void Iterate(IterateTileDataDelegate itdd)
    {
      for (Int32 y = 0; y < Constants.TileSize; y++)
      {
        for (Int32 x = 0; x < Constants.TileSize; x++)
        {
          itdd(x, y, ref image[x, y]);
        }
      }
    }

    /**
     * Cut a 16x16 block from the given bitmap, starting at pixel [xTile,yTile]
     */
    public void SliceFromBitmap(Bitmap img, Int32 xStart, Int32 yStart)
    {
      Iterate((Int32 x, Int32 y, ref PixelRGBA pixel) =>
      {
        Int32 clampX = xStart + x, clampY = yStart + y;

        if (clampX < 0 ||
            clampY < 0 ||
            clampX > img.Width ||
            clampY > img.Height)
        {
          pixel.R = pixel.G = pixel.B = 0;
          pixel.A = 255;
        }
        else
        {
          Color imgCol = img.GetPixel(xStart + x, yStart + y);

          pixel.R = imgCol.R;
          pixel.G = imgCol.G;
          pixel.B = imgCol.B;
          pixel.A = 255;
        }
      });
    }

    // SiDComponent
    override public Bitmap RenderToBitmap(ResourcePack rp)
    {
      Bitmap tb = new Bitmap(Constants.TileSize, Constants.TileSize);
      Iterate((Int32 x, Int32 y, ref PixelRGBA pixel) =>
      {
        tb.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.G, pixel.B));
      });

      return tb;
    }

    // SiDComponent
    override public void LoadFromByteStream(BinaryReader br, Int32 streamLength)
    {
      Iterate((Int32 x, Int32 y, ref PixelRGBA pixel) =>
      {
        pixel.R = br.ReadByte();
        pixel.G = br.ReadByte();
        pixel.B = br.ReadByte();
        pixel.A = br.ReadByte();
      });

      Name = ByteUtils.readNullTermString11(br);
    }

    // SiDComponent
    override public byte[] SaveToByteStream()
    {
      List<byte> byteStream = new List<byte>(1064);

      // manually stream out the pixel data
      Iterate((Int32 x, Int32 y, ref PixelRGBA pixel) =>
      {
        byteStream.Add(pixel.R);
        byteStream.Add(pixel.G);
        byteStream.Add(pixel.B);
        byteStream.Add(pixel.A);
      });
      
      // append tile name
      byte[] stringBytes = ASCIIEncoding.UTF8.GetBytes(Name);
      byteStream.AddRange(stringBytes);
      byteStream.Add(0); // terminate

      return byteStream.ToArray();
    }

    // a tile is simply a square block of RGB pixels, alpha is stored but ignored
    private PixelRGBA[,] image = new PixelRGBA[Constants.TileSize, Constants.TileSize];
  }
}
