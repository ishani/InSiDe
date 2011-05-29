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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SiDcore
{
  /**
   * 
   *
   */
  [ResourceTypeAttribute("object")]
  public class StateObject : SiDComponent
  {
    internal const Int32 StateObjectVersionNumber = 3;
    public delegate void IterateObjectLayerDelegate(Int32 index, ref StateObject.SpriteLayer layer);

    /**
     * iterator for general purpose access to internal data
     */
    public void Iterate(IterateObjectLayerDelegate iold)
    {
      for (Int32 index = 0; index < layers.Count; index++)
      {
        SpriteLayer sl = layers[index];
        iold(index, ref sl);
        layers[index] = sl;
      }
    }

    public void AddSprite(Sprite s, Int32 x, Int32 y, float t, bool additive)
    {
      // shift into object space
      const Int32 MidPoint = (Constants.RoomSize * Constants.TileSize) / 2;
      x = (-MidPoint + (Constants.TileSize / 2)) + x;
      y = (MidPoint - (Constants.TileSize / 2)) - (y - Constants.TileSize);

      SpriteLayer sl = new SpriteLayer();
      sl.uid = s.getUID();
      sl.x = (byte)x;
      sl.y = (byte)y;
      sl.trans = (byte)(t * 255.0f);
      sl.glow = (byte)(additive ? 1 : 0);

      layers.Add(sl);
    }

    // SiDComponent
    override public Bitmap RenderToBitmap(ResourcePack rp)
    {
      Bitmap tb = new Bitmap(Constants.RoomSize * Constants.TileSize, Constants.RoomSize * Constants.TileSize, PixelFormat.Format32bppArgb);
      tb.MakeTransparent();
      Graphics gfx = Graphics.FromImage(tb);

      ImageAttributes ia = new ImageAttributes();
      ColorMatrix cm = new ColorMatrix();

      foreach (SpriteLayer layer in layers)
      {
        Sprite spr = rp.LookupByUID(layer.uid) as Sprite;

        const Int32 MidPoint = (Constants.RoomSize * Constants.TileSize) / 2;
        Int32 sX = MidPoint + (Int32)((sbyte)layer.x);
        Int32 sY = MidPoint - (Int32)((sbyte)layer.y);
        Int32 spriteSpaceX = (sX - (Constants.TileSize / 2));
        Int32 spriteSpaceY = ((Constants.TileSize + sY) - (Constants.TileSize / 2));

        if (spr != null)
        {
          Bitmap sprBmp = spr.RenderToBitmap(rp);
          Rectangle destRect = new Rectangle(spriteSpaceX, spriteSpaceY, sprBmp.Width, sprBmp.Height);

          float transpF = (float)(layer.trans) / 255.0f;
          if (layer.glow == 1)
          {
            // additive blending in GDI+?
            // couldn't find a built-in way to do this. annnooyyyinngg

            Int32 readOffsetX = 0, readOffsetY = 0;
            if (destRect.Y < 0)
            {
              destRect.Height += destRect.Y;
              readOffsetY = -destRect.Y;
              destRect.Y = 0;
            }
            if (destRect.X < 0)
            {
              destRect.Width += destRect.X;
              readOffsetX = -destRect.X;
              destRect.X = 0;
            }

            BitmapData bmpData = tb.LockBits(destRect, ImageLockMode.ReadWrite, tb.PixelFormat);
            unsafe
            {
              for (int y = 0; y < bmpData.Height; y++)
              {
                byte* row = (byte*)bmpData.Scan0 + (y * bmpData.Stride);
                for (int x = 0; x < bmpData.Width; x++)
                {
                  Color topPixel = sprBmp.GetPixel(readOffsetX + x, readOffsetY + y);

                  Int32 xP = x * 4;
                  row[xP + 0] = (byte)Math.Min(255, (Int32)row[xP + 0] + topPixel.B);
                  row[xP + 1] = (byte)Math.Min(255, (Int32)row[xP + 1] + topPixel.G);
                  row[xP + 2] = (byte)Math.Min(255, (Int32)row[xP + 2] + topPixel.R);
                  row[xP + 3] = (byte)Math.Min(255, (Int32)row[xP + 3] + topPixel.A);
                }
              }
            }
            tb.UnlockBits(bmpData);
          }
          else
          {
            // standard alpha composite
            cm.Matrix33 = transpF;
            ia.SetColorMatrix(cm);
            gfx.DrawImage(sprBmp, destRect, 0, 0, 16.0f, 16.0f, GraphicsUnit.Pixel, ia);
          }

        }
        else
        {
          // missing sprite
          gfx.FillRectangle(Brushes.Magenta, spriteSpaceX, spriteSpaceY, 16.0f, 16.0f);
        }
      }

      gfx.Dispose();
      return tb;
    }

    // SiDComponent
    override public void LoadFromByteStream(BinaryReader br, Int32 streamLength)
    {
      // check magic bytes
      byte[] magic = br.ReadBytes(Constants.SID_MAGIC_CODE.Length);
      String magicString = ASCIIEncoding.UTF8.GetString(magic, 0, Constants.SID_MAGIC_CODE.Length);
      if (magicString != Constants.SID_MAGIC_CODE)
      {
        throw new InvalidDataException("loading StateObject - data did not start with SID_MAGIC_CODE");
      }

      // validate version
      Int32 objectVersion = (Int32)br.ReadByte();

      // we support loading V2 assets
      if (objectVersion == 2)
      {
        upgradedFromV2 = true;
      }
      else
      {
        if (objectVersion != StateObjectVersionNumber)
        {
          throw new InvalidDataException(String.Format("loading StateObject - version mismatch (got {0}, expected {1})", objectVersion, StateObjectVersionNumber));
        }
      }

      Int32 numLayers = (Int32)br.ReadByte();
      for (Int32 i = 0; i < numLayers; i++)
      {
        SpriteLayer layer = new SpriteLayer();

        byte[] uidbytes = br.ReadBytes(6);
        layer.uid = new UID(uidbytes);

        layer.x = br.ReadByte();
        layer.y = br.ReadByte();
        layer.trans = br.ReadByte();

        // handle V3 glow byte
        if (!upgradedFromV2)
        {
          layer.glow = br.ReadByte();
        }
        else
        {
          layer.glow = 0;
        }

        layers.Add(layer);
      }

      Name = ByteUtils.readNullTermString11(br);
    }

    // SiDComponent
    override public byte[] SaveToByteStream()
    {
      List<byte> byteStream = new List<byte>(1064);

      // magic header
      byte[] magicBytes = ASCIIEncoding.UTF8.GetBytes(Constants.SID_MAGIC_CODE);
      byteStream.AddRange(magicBytes);

      // versioning
      byteStream.Add((byte)StateObjectVersionNumber);

      if (layers.Count > 255)
      {
        throw new InvalidDataException("StateObject has too many sprite layers");
      }

      byteStream.Add((byte)layers.Count);
      foreach (SpriteLayer layer in layers)
      {
        byteStream.AddRange(layer.uid.UIDBytes);
        byteStream.Add(layer.x);
        byteStream.Add(layer.y);
        byteStream.Add(layer.trans);
        byteStream.Add(layer.glow);
      }

      // append tile name
      byte[] stringBytes = ASCIIEncoding.UTF8.GetBytes(Name);
      byteStream.AddRange(stringBytes);
      byteStream.Add(0); // terminate

      return byteStream.ToArray();
    }

    public struct SpriteLayer
    {
      public UID uid;
      public byte x, y;
      public byte trans;
      public byte glow;
    }
    private List<SpriteLayer> layers = new List<SpriteLayer>(8);
    private bool upgradedFromV2 = false;
  }
}
