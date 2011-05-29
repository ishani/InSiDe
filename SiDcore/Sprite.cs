/**
 * SiDcore ~ a C# class library for creating and manipulating data for Jason Rohrer's Sleep Is Death (http://sleepisdeath.net/)
 * 
 * Written by Harry Denholm (Ishani) April 2010
 * http://ishanisv.org/sid/
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
   * 
   *
   */
  [ResourceTypeAttribute("sprite")]
  public class Sprite : SiDComponent
  {
    public delegate void IterateSpriteDataDelegate(Int32 x, Int32 y, ref PixelRGBA pixel, ref byte transFlags);

    /**
     * iterator for general purpose access to internal data
     */
    public void Iterate(IterateSpriteDataDelegate isdd)
    {
      for (Int32 y = 0; y < Constants.TileSize; y++)
      {
        for (Int32 x = 0; x < Constants.TileSize; x++)
        {
          isdd(x, y, ref image[x, y], ref transFlags[x, y]);
        }
      }
    }

    /**
     * Cut a 16x16 block from the given bitmap, starting at pixel [xTile,yTile]
     */
    public void SliceFromBitmap(Bitmap img, Int32 xStart, Int32 yStart, Int32 transThresh)
    {
      Iterate((Int32 x, Int32 y, ref PixelRGBA pixel, ref byte transFlags) =>
      {
        Int32 clampX = xStart + x, clampY = yStart + y;

        if (clampX < 0 || 
            clampY < 0 ||
            clampX > img.Width ||
            clampY > img.Height)
        {
          pixel.R = pixel.G = pixel.B = pixel.A = 0;
          transFlags = 1;
        }
        else
        {
          Color imgCol = img.GetPixel(clampX, clampY);

          pixel.R = imgCol.R;
          pixel.G = imgCol.G;
          pixel.B = imgCol.B;
          pixel.A = imgCol.A;

          transFlags = (byte)((imgCol.A <= transThresh) ? 1 : 0);
        }
      });
    }

    // SiDComponent
    override public Bitmap RenderToBitmap(ResourcePack rp)
    {
      Bitmap tb = new Bitmap(Constants.TileSize, Constants.TileSize, PixelFormat.Format32bppArgb);
      Iterate((Int32 x, Int32 y, ref PixelRGBA pixel, ref byte transFlags) =>
      {
        tb.SetPixel(x, y, Color.FromArgb(transFlags == 1 ? 0 : 255, pixel.R, pixel.G, pixel.B));
      });

      return tb;
    }

    // SiDComponent
    override public void LoadFromByteStream(BinaryReader br, Int32 streamLength)
    {
      Iterate((Int32 x, Int32 y, ref PixelRGBA pixel, ref byte transFlags) =>
      {
        pixel.R = br.ReadByte();
        pixel.G = br.ReadByte();
        pixel.B = br.ReadByte();
        pixel.A = br.ReadByte();
      });

      Iterate((Int32 x, Int32 y, ref PixelRGBA pixel, ref byte transFlags) =>
      {
        transFlags = br.ReadByte();
      });

      Name = ByteUtils.readNullTermString11(br);
    }

    // SiDComponent
    override public byte[] SaveToByteStream()
    {
      List<byte> byteStream = new List<byte>(1064);

      // manually stream out the pixel data
      Iterate((Int32 x, Int32 y, ref PixelRGBA pixel, ref byte transFlags) =>
      {
        byteStream.Add(pixel.R);
        byteStream.Add(pixel.G);
        byteStream.Add(pixel.B);
        byteStream.Add(pixel.A);
      });

      Iterate((Int32 x, Int32 y, ref PixelRGBA pixel, ref byte transFlags) =>
      {
        byteStream.Add(transFlags);
      });

      // append tile name
      byte[] stringBytes = ASCIIEncoding.UTF8.GetBytes(Name);
      byteStream.AddRange(stringBytes);
      byteStream.Add(0); // terminate

      return byteStream.ToArray();
    }

    // a sprite is like a tile, but takes notice of the alpha
    private PixelRGBA[,] image = new PixelRGBA[Constants.TileSize, Constants.TileSize];
    private byte[,] transFlags = new byte[Constants.TileSize, Constants.TileSize];
  }
}
