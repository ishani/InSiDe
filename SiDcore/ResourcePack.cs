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
using System.Reflection;
using System.Reflection.Emit;
using System.Drawing;
using System.Security.Cryptography;

using ComponentAce.Compression.Libs.zlib;


namespace SiDcore
{
  public delegate void ComponentAddedToPackHandler(ResourcePack sender, SiDComponent comp);
  public delegate void ComponentRemovedFromPackHandler(ResourcePack sender, SiDComponent comp);
  public delegate void PackClearedHandler(ResourcePack sender);

  public class ResourcePack
  {
    public event ComponentAddedToPackHandler ComponentAdded;
    public event ComponentRemovedFromPackHandler ComponentRemoved;
    public event PackClearedHandler PackCleared;

    public delegate void IterateResourcePackDelegate(SiDComponent comp);


    Dictionary<String, Type> mComponentFactory = new Dictionary<String, Type>(6);

    List<SiDComponent> mComponents = new List<SiDComponent>(256);
    Dictionary<String, SiDComponent> mComponentsByUID = new Dictionary<String, SiDComponent>(256);
    MultiMap<Type, SiDComponent> mComponentsByType = new MultiMap<Type, SiDComponent>(6, 256);


    public ResourcePack()
    {
      mComponentFactory.Add(SiDComponent.getResourceTypeName(typeof(Tile)), typeof(Tile));
      mComponentFactory.Add(SiDComponent.getResourceTypeName(typeof(Room)), typeof(Room));
      mComponentFactory.Add(SiDComponent.getResourceTypeName(typeof(Sprite)), typeof(Sprite));
      mComponentFactory.Add(SiDComponent.getResourceTypeName(typeof(StateObject)), typeof(StateObject));
    }

    public void Iterate(IterateResourcePackDelegate irpd)
    {
      foreach (SiDComponent sidc in mComponents)
      {
        irpd(sidc);
      }
    }

    // 
    public void Clear()
    {
      mComponents.Clear();
      mComponentsByUID.Clear();
      mComponentsByType.Clear();

      // ping event handler
      if (PackCleared != null)
        PackCleared(this);

      GC.Collect();
    }

    //
    public bool Add(SiDComponent component)
    {
      if (component == null)
        return false;

      String compUIDStr = component.getUID().ToString();

      // check for duplicates
      if (mComponentsByUID.ContainsKey(compUIDStr))
      {
        return false;
      }

      mComponentsByUID.Add(compUIDStr, component);
      mComponents.Add(component);
      mComponentsByType.Add(component.GetType(), component);

      // ping event handler
      if (ComponentAdded != null)
        ComponentAdded(this, component);

      return true;
    }

    //
    public bool Remove(SiDComponent component)
    {
      if (component == null)
        return false;

      String compUIDStr = component.getUID().ToString();

      if (mComponentsByUID.ContainsKey(compUIDStr))
      {
        mComponents.Remove(component);
        mComponentsByUID.Remove(compUIDStr);
        mComponentsByType[component.GetType()].Remove(component);

        // ping event handler
        if (ComponentRemoved != null)
          ComponentRemoved(this, component);

        return true;
      }

      return false;
    }

    // get a component by its UID; may return null
    public SiDComponent LookupByUID(UID compUID)
    {
      SiDComponent dupeComponent = null;
      mComponentsByUID.TryGetValue(compUID.ToString(), out dupeComponent);

      return dupeComponent;
    }

    //
    public void Save(String filename)
    {
      MemoryStream ms = new MemoryStream(mComponents.Count * 1064);
      using (ms)
      {
        using (BinaryWriter b = new BinaryWriter(ms))
        {
          b.Write(ByteUtils.SwapUInt32((UInt32)mComponents.Count));

          foreach (SiDComponent exC in mComponents)
          {
            byte[] compName = ASCIIEncoding.UTF8.GetBytes(exC.Name);
            byte[] typeName = ASCIIEncoding.UTF8.GetBytes(exC.ResourceTypeName);
            UID uid = exC.getUID();

            b.Write(typeName);
            b.Write('\0');

            b.Write(uid.UIDBytes);

            b.Write(compName);
            b.Write('\0');

            byte[] dataBuf = exC.SaveToByteStream();
            b.Write(ByteUtils.SwapUInt32((UInt32)dataBuf.Length));
            b.Write(dataBuf);
          }

          Int32 uncompressedSize = (Int32)ms.Length;

          MemoryStream packMem = new MemoryStream(uncompressedSize);
          using (ZOutputStream zStream = new ZOutputStream(packMem, 9))
          {
            zStream.Write(ms.ToArray(), 0, (Int32)ms.Length);
            zStream.finish();

            using (FileStream fs = File.Open(filename, FileMode.Create))
            {
              using (BinaryWriter fb = new BinaryWriter(fs))
              {
                fb.Write(ByteUtils.SwapUInt32((UInt32)uncompressedSize));
                fb.Write(packMem.ToArray(), 0, (Int32)packMem.Length);
              }

              fs.Close();
            }
          }
        }
      }
    }

    //
    public bool Load(String filename)
    {
      Console.WriteLine("ResourcePack::Load - {0}", filename);
      using (FileStream fs = File.Open(filename, FileMode.Open))
      {
        byte[] unpackBuffer = null;

        using (BinaryReader br = new BinaryReader(fs))
        {
          UInt32 sizeUncompressed = ByteUtils.SwapUInt32(br.ReadUInt32());
          unpackBuffer = new byte[sizeUncompressed];

          byte[] packedBuf = new byte[br.BaseStream.Length - 4];
          br.Read(packedBuf, 0, packedBuf.Length);

          Console.WriteLine("  ... uncompressed size is {0}", sizeUncompressed);
          using (MemoryStream ms = new MemoryStream(packedBuf))
          {
            using (ZInputStream zStream = new ZInputStream(ms))
            {
              Int32 bOffset = 0;
              while (bOffset < sizeUncompressed)
              {
                Int32 decS = zStream.read(unpackBuffer, bOffset, (Int32)sizeUncompressed - bOffset);
                bOffset += decS;
              }
            }
          }
          
        }
        fs.Close();


        using (MemoryStream ms = new MemoryStream(unpackBuffer))
        {
          using (BinaryReader ir = new BinaryReader(ms))
          {
            UInt32 numChunks = ByteUtils.SwapUInt32(ir.ReadUInt32());
            Console.WriteLine("  ... processing {0} chunks", numChunks);
            for (UInt32 i = 0; i < numChunks; i++)
            {
              String componentTypeName = ByteUtils.readNullTermString11(ir);
              UID componentUID = new UID(ir.ReadBytes(6));
              String componentName = ByteUtils.readNullTermString11(ir);

              UInt32 componentDataLength = ByteUtils.SwapUInt32(ir.ReadUInt32());

              // go see if we know how to build a component from this data type
              Type typeToBuild = null;
              if (mComponentFactory.TryGetValue(componentTypeName, out typeToBuild))
              {
                // yes; so instantiate the returned type
                SiDComponent newComponent = Activator.CreateInstance(typeToBuild) as SiDComponent;
                newComponent.Name = componentName;

                // ask it to load from the bytestream
                newComponent.LoadFromByteStream(ir, (Int32)componentDataLength);

                // record it
                if (!Add(newComponent))
                {
                  Console.WriteLine("Warning! duplicate item in single resource pack? {0}", componentUID);
                }

                Console.WriteLine("    + {0}:{1}: - {2}", componentUID, SiDComponent.getResourceTypeName(typeToBuild), newComponent.Name);
              }
              else
              {
                // we don't know how to construct this type; store as a 'black box' blob
                Blob newBlob = new Blob(componentTypeName);
                newBlob.Name = componentName;

                // blobs just hold onto the data as raw bytes, ready to parrot it back out on Save
                newBlob.LoadFromByteStream(ir, (Int32)componentDataLength);

                // record it
                if (!Add(newBlob))
                {
                  Console.WriteLine("Warning! duplicate (blob) item in single resource pack? {0}", componentUID);
                }

                Console.WriteLine("    + {0}:{1}:BLOB: - {2}", componentUID, componentTypeName, componentName);
              }
            }
          }
        }
     
      }

      return true;
    }

    // changing a Tile or Sprite will mean that any Room or Object that uses them will then have an invalid UID; we avoid
    // this by recording Before & After UIDs when changing Tiles or Sprites, then patching up any Room or Object components that
    // have references to the Before UID as a post-process
    #region Dep Patching

    public void PatchRoomsForTileChanges(IList<ComponentReplacementExchange> componentReplacements)
    {
      List<SiDComponent> rooms = mComponentsByType[typeof(Room)];

      // patch rooms with Tile UID changes
      foreach (Room r in rooms)
      {
        // this is a shitty n-squared search. slow and horrible :(
        r.Iterate((Int32 x, Int32 y, ref UID uid) =>
        {
          foreach (ComponentReplacementExchange crt in componentReplacements)
          {
            if (crt.Old.Equals(uid))
              uid = crt.New;
          }
        });
      }
    }

    public void PatchObjectsForSpriteChanges(IList<ComponentReplacementExchange> componentReplacements)
    {
      List<SiDComponent> objects = mComponentsByType[typeof(StateObject)];

      // patch rooms with Tile UID changes
      foreach (StateObject ob in objects)
      {
        // this is a shitty n-squared search. slow and horrible :(
        ob.Iterate((Int32 index, ref StateObject.SpriteLayer layer) =>
        {
          foreach (ComponentReplacementExchange crt in componentReplacements)
          {
            if (crt.Old.Equals(layer.uid))
              layer.uid = crt.New;
          }
        });
      }
    }

    #endregion

    #region FindUsedOrUnused

    public Dictionary<Tile, Room> FindTilesUsedByRooms()
    {
      List<SiDComponent> rooms = mComponentsByType[typeof(Room)];

      Dictionary<Tile, Room> usageDic = new Dictionary<Tile, Room>(rooms.Count * 16);

      foreach (Room r in rooms)
      {
        r.Iterate((Int32 x, Int32 y, ref UID uid) =>
        {
          Tile t = LookupByUID(uid) as Tile;
          if (t != null && (!usageDic.ContainsKey(t)))
          {
            usageDic.Add(t, r);
          }
        });
      }

      return usageDic;
    }

    public List<Tile> FindUnusedTiles()
    {
      Dictionary<Tile, Room> usageDic = FindTilesUsedByRooms();

      List<SiDComponent> tiles = mComponentsByType[typeof(Tile)];
      List<Tile> unused = new List<Tile>(16);

      foreach (Tile t in tiles)
      {
        if (!usageDic.ContainsKey(t))
          unused.Add(t);
      }

      return unused;
    }

    public Dictionary<Sprite, StateObject> FindSpritesUsedByObjects()
    {
      List<SiDComponent> objects = mComponentsByType[typeof(StateObject)];

      Dictionary<Sprite, StateObject> usageDic = new Dictionary<Sprite, StateObject>(objects.Count * 16);

      foreach (StateObject ob in objects)
      {
        ob.Iterate((Int32 index, ref StateObject.SpriteLayer layer) =>
        {
          Sprite s = LookupByUID(layer.uid) as Sprite;
          if (s != null && (!usageDic.ContainsKey(s)))
          {
            usageDic.Add(s, ob);
          }
        });
      }

      return usageDic;
    }

    public List<Sprite> FindUnusedSprites()
    {
      Dictionary<Sprite, StateObject> usageDic = FindSpritesUsedByObjects();

      List<SiDComponent> sprites = mComponentsByType[typeof(Sprite)];
      List<Sprite> unused = new List<Sprite>(16);

      foreach (Sprite s in sprites)
      {
        if (!usageDic.ContainsKey(s))
          unused.Add(s);
      }

      return unused;
    }

    #endregion

  }
}
