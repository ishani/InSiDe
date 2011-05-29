/**
 * SiDcore ~ a C# class library for creating and manipulating data for Jason Rohrer's Sleep Is Death (http://sleepisdeath.net/)
 * 
 * Written by Harry Denholm (Ishani) April 2010
 * http://ishanisv.org/sid/
 *
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;

namespace SiDcore
{
  public abstract class SiDComponent
  {
    #region NameAndType
    private String componentName = "nothing";

    // generic component name, 10 character maximum
    public String Name
    {
      set 
      { 
        // maximum allowed component name length is 10 - SiD stores names as 11 byte arrays (inc null terminator)
        componentName = value.Substring(0, Math.Min(value.Length, 10)); 
      }
      get { return componentName; }
    }

    virtual public String ResourceTypeName
    {
      get
      {
        return getResourceTypeName(this.GetType());
      }
    }

    // used to identify this component in a Resource Pack (or used in factory function)
    public static String getResourceTypeName(Type t)
    {
      ResourceTypeAttribute[] attributes = (ResourceTypeAttribute[])t.GetCustomAttributes(typeof(ResourceTypeAttribute), false);
      if (attributes.Length == 0)
      {
        throw (new InvalidDataException("trying to get resource type name of unsupported component type (Blob?)"));
      }
      return attributes[0].RTName;
    }
    #endregion

    /**
      * Load data from an unpacked SiD resource (eg. "SleepIsDeath_v13\resourceCache\sprite\0D7DF32654AF")
      */
    public void LoadFromFile(String filename)
    {
      FileStream fs = File.Open(filename, FileMode.Open);
      using (fs)
      {
        using (BinaryReader b = new BinaryReader(fs))
        {
          LoadFromByteStream(b, (Int32)b.BaseStream.Length);
        }
      }
    }

    public void SaveToFile(String filename)
    {
      FileStream fs = File.Open(filename, FileMode.Create);
      using (fs)
      {
        using (BinaryWriter b = new BinaryWriter(fs))
        {
          byte[] rawBytes = SaveToByteStream();
          b.Write(rawBytes, 0, rawBytes.Length);
        }
      }
    }

    #region Abstracts

    // load component data from a byte stream
    abstract public void LoadFromByteStream(BinaryReader br, Int32 streamLength);

    // serialize component data to a byte stream
    abstract public byte[] SaveToByteStream();

    // render the component to a bitmap; we must pass in an RP for any dependant-asset look-up
    abstract public Bitmap RenderToBitmap(ResourcePack rp);

    #endregion

    #region UID

    // default UID is the SHA1 of the byte stream representing this resource
    public virtual UID getUID()
    {
      byte[] buffer = SaveToByteStream();

      SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
      byte[] hashResult = cryptoTransformSHA1.ComputeHash(buffer);

      // UID is only the first 6 bytes of the SHA1
      UID uid = new UID(hashResult);

      return uid;
    }

    #endregion
  }
}
