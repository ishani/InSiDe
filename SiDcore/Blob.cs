using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;

namespace SiDcore
{
  public class Blob : SiDComponent
  {
    private String CachedResourceType = "unknown";

    public Blob(String ResType)
    {
      CachedResourceType = ResType;
    }

    override public String ResourceTypeName
    {
      get
      {
        return CachedResourceType;
      }
    }

    override public Bitmap RenderToBitmap(ResourcePack rp)
    {
      throw (new InvalidOperationException("cannot convert Blob type to bitmap"));
    }

    // SiDComponent
    override public void LoadFromByteStream(BinaryReader br, Int32 streamLength)
    {
      blobBytes = br.ReadBytes(streamLength);
    }

    // SiDComponent
    override public byte[] SaveToByteStream()
    {
      return blobBytes;
    }

    protected byte[] blobBytes;
  }
}
