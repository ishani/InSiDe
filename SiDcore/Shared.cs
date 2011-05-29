/**
 * SiDcore ~ a C# class library for creating and manipulating data for Jason Rohrer's Sleep Is Death (http://sleepisdeath.net/)
 * 
 * Written by Harry Denholm (Ishani) April 2010
 * http://www.ishani.org/
 *
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.IO;
using System.Linq;

namespace SiDcore
{
  // Unchangables from the SiD source code
  public static class Constants
  {
    public const String SID_MAGIC_CODE = "SiD1977";

    public const Int32 TileSize = 16;      // num pixels per tile edge
    public const Int32 RoomSize = 13;      // num tiles per room edge
  }

  // Metadata tag for various types of resource that we know about
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class ResourceTypeAttribute : Attribute
  {
    protected String mRTName;

    public String RTName
    {
      get { return mRTName; }
    }

    public ResourceTypeAttribute(String rtName)
    {
      mRTName = rtName;
    }
  }

  public struct PixelRGB
  {
    public Byte R, G, B;
  };

  public struct PixelRGBA
  {
    public Byte R, G, B, A;

    public PixelRGBA(PixelRGB rgb)
    {
      R = rgb.R;
      G = rgb.G;
      B = rgb.B;
      A = 255;
    }
  };

  // UIDs in SiD represent a unique resource entity and are formed from the first 6 bytes
  // of the SHA1 hash of the resource contents.
  public class UID
  {
    public UID(byte[] stream)
    {
      SetFromBytes(stream);
    }

    public void SetFromBytes(byte[] stream)
    {
      Array.Copy(stream, UIDBytes, 6);
    }

    public override String ToString()
    {
      String hash = BitConverter.ToString(UIDBytes).Replace("-", "");
      return hash.Substring(0, 6 * 2);
    }

    public bool Equals(UID rhs)
    {
      return (UIDBytes.SequenceEqual(rhs.UIDBytes));
    }

    public byte[] UIDBytes = new byte[6];
  }

  // little helper struct used when patching up changes to Tiles/Sprites with their dependent components
  public struct ComponentReplacementExchange
  {
    public UID Old;
    public UID New;
  }


  public static class ByteUtils
  {
    // read a component name/type null term string from a binary stream
    public static String readNullTermString11(BinaryReader ir)
    {
      // TODO doesn't check for overflow
      List<byte> dyn = new List<byte>(11);
      for (UInt32 d = 0; d < 11; d++)
      {
        byte strByte = ir.ReadByte();
        if (strByte == 0)
          break;

        dyn.Add(strByte);
      }

      return ASCIIEncoding.UTF8.GetString(dyn.ToArray());
    }

    // endian swap a UInt32
    public static UInt32 SwapUInt32(UInt32 inValue)
    {
      return (UInt32)(((inValue & 0xff000000) >> 24) |
                       ((inValue & 0x00ff0000) >> 8) |
                       ((inValue & 0x0000ff00) << 8) |
                       ((inValue & 0x000000ff) << 24));
    }
  }
}
