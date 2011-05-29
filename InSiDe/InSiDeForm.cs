/**
 * InSiDe ~ tools for mucking about with Jason Rohrer's Sleep Is Death (http://sleepisdeath.net/)
 * 
 * Written by Harry Denholm (Ishani) April 2010
 * http://www.ishani.org/
 *
 */

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
using Manina.Windows.Forms;

using SiDcore;

namespace InSiDe
{
  public partial class InSiDeForm : Form
  {
    ResourcePack resourcePack = new ResourcePack();
    Dictionary<SiDComponent, ImageListViewItem> TrackedComponents = new Dictionary<SiDComponent, ImageListViewItem>(128);

    public InSiDeForm()
    {
      InitializeComponent();

      ilvTiles.SetRenderer(new ThumbRenderer(4, false));
      ilvRooms.SetRenderer(new ThumbRenderer(4, false));
      ilvSprites.SetRenderer(new ThumbRenderer(4, true));
      ilvObjects.SetRenderer(new ThumbRenderer(4, true));

      resourcePack.ComponentAdded += new ComponentAddedToPackHandler(resourcePack_ComponentAdded);
      resourcePack.ComponentRemoved += new ComponentRemovedFromPackHandler(resourcePack_ComponentRemoved);
      resourcePack.PackCleared += new PackClearedHandler(resourcePack_PackCleared);
    }

    public Bitmap ResizeBitmap(Bitmap b, float scaleFactor)
    {
      Bitmap result = new Bitmap((Int32)((float)b.Width * scaleFactor), (Int32)((float)b.Height * scaleFactor));
      using (Graphics gfx = Graphics.FromImage((Image)result))
      {
        gfx.ScaleTransform(scaleFactor, scaleFactor);
        gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
        gfx.SmoothingMode = SmoothingMode.None;
        gfx.DrawImage(b, 0, 0);
      }

      return result;
    }

    private Bitmap LoadImageAs32ARGB(String filename)
    {
      Bitmap toSlice = new Bitmap(Image.FromFile(filename));
      Bitmap fullBPP = new Bitmap(toSlice.Width, toSlice.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
      using (Graphics gfx = Graphics.FromImage(fullBPP))
      {
        gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
        gfx.SmoothingMode = SmoothingMode.None;
        gfx.DrawImage(toSlice, new Rectangle(0, 0, toSlice.Width, toSlice.Height), 0, 0, toSlice.Width, toSlice.Height, GraphicsUnit.Pixel);
      }
      toSlice.Dispose();

      return fullBPP;
    }


    #region RP Events

    void resourcePack_PackCleared(ResourcePack sender)
    {
      TrackedComponents.Clear();
      ilvTiles.Items.Clear();
      ilvRooms.Items.Clear();
      ilvSprites.Items.Clear();
      ilvObjects.Items.Clear();
      blobList.Items.Clear();
    }

    internal void ViewsSuspendLayout()
    {
      ilvTiles.SuspendLayout();
      ilvRooms.SuspendLayout();
      ilvSprites.SuspendLayout();
      ilvObjects.SuspendLayout();
    }

    internal void ViewsResumeLayout()
    {
      ilvObjects.ResumeLayout();
      ilvSprites.ResumeLayout();
      ilvRooms.ResumeLayout();
      ilvTiles.ResumeLayout();
    }

    void resourcePack_ComponentRemoved(ResourcePack sender, SiDComponent comp)
    {
      ImageListViewItem ilvi = TrackedComponents[comp];
      TrackedComponents.Remove(comp);

      if (comp is Tile)
      {
        ilvTiles.Items.Remove(ilvi);
      }
      else if (comp is Room)
      {
        ilvRooms.Items.Remove(ilvi);
      }
      else if (comp is Sprite)
      {
        ilvSprites.Items.Remove(ilvi);
      }
      else if (comp is StateObject)
      {
        ilvObjects.Items.Remove(ilvi);
      }
    }

    void resourcePack_ComponentAdded(ResourcePack sender, SiDComponent comp)
    {
      String UIDstr = comp.getUID().ToString();

      if (comp is Tile)
      {
        Bitmap rep = ResizeBitmap(comp.RenderToBitmap(resourcePack), 4.0f);

        ilvTiles.Items.Add(UIDstr, comp.Name, rep);

        ImageListViewItem ilvi = ilvTiles.Items[ilvTiles.Items.Count - 1];
        ilvi.Tag = comp;

        TrackedComponents.Add(comp, ilvi);
      }
      else if (comp is Room)
      {
        Bitmap rep = comp.RenderToBitmap(resourcePack);

        ilvRooms.Items.Add(UIDstr, comp.Name, rep);

        ImageListViewItem ilvi = ilvRooms.Items[ilvRooms.Items.Count - 1];
        ilvi.Tag = comp;

        TrackedComponents.Add(comp, ilvi);
      }
      else if (comp is Sprite)
      {
        Bitmap rep = ResizeBitmap(comp.RenderToBitmap(resourcePack), 4.0f);

        ilvSprites.Items.Add(UIDstr, comp.Name, rep);

        ImageListViewItem ilvi = ilvSprites.Items[ilvSprites.Items.Count - 1];
        ilvi.Tag = comp;

        TrackedComponents.Add(comp, ilvi);
      }
      else if (comp is StateObject)
      {
        Bitmap rep = comp.RenderToBitmap(resourcePack);

        ilvObjects.Items.Add(UIDstr, comp.Name, rep);

        ImageListViewItem ilvi = ilvObjects.Items[ilvObjects.Items.Count - 1];
        ilvi.Tag = comp;

        TrackedComponents.Add(comp, ilvi);
      }
      else
      {
        byte [] stream = comp.SaveToByteStream();
        blobList.Items.Add(String.Format("{0} : {1}  ({2} bytes)", comp.ResourceTypeName, comp.Name, stream.Length));
      }
    }

    #endregion

    #region Menus

    private void mmClearPack_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("This will remove all current assets. Are you sure?", "InSiDe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        ViewsSuspendLayout();
        resourcePack.Clear();
        ViewsResumeLayout();
      }
    }

    private void mmOpenExisting_Click(object sender, EventArgs e)
    {
      if (fdOpenResourcePack.ShowDialog() == DialogResult.OK)
      {
        try
        {
          ViewsSuspendLayout();
          resourcePack.Load(fdOpenResourcePack.FileName);
          ViewsResumeLayout();
        }
        catch (System.Exception ex)
        {
          MessageBox.Show(String.Format("Could not load Resource Pack!\n\n{0}", ex.Message), "InSiDe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void mmSaveAs_Click(object sender, EventArgs e)
    {
      if (fdSaveResourcePack.ShowDialog() == DialogResult.OK)
      {
        try
        {
          resourcePack.Save(fdSaveResourcePack.FileName);
        }
        catch (System.Exception ex)
        {
          MessageBox.Show(String.Format("Could not save Resource Pack!\n\n{0}", ex.Message), "InSiDe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void mmQuit_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Quitting, eh? Sure about that?", "InSiDe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        Environment.Exit(0);
      }
    }

    #endregion

    #region RCMenu-Removing

    private void ctxRemoveTiles_Click(object sender, EventArgs e)
    {
      ilvTiles.SuspendLayout();

      // check if the use is about to delete something that is depended upon by something else
      Dictionary<Tile, Room> tilesInUse = resourcePack.FindTilesUsedByRooms();
      foreach (ImageListViewItem ilvi in ilvTiles.SelectedItems)
      {
        if (tilesInUse.ContainsKey(ilvi.Tag as Tile))
        {
          DialogResult dr = MessageBox.Show(
            "One or more of the tiles you're about to delete are used by Rooms in this pack\n\nDeleting them will break those Room layouts.\n\nAre you sure you want to delete?", 
            "InSiDe", 
            MessageBoxButtons.YesNo, 
            MessageBoxIcon.Stop);

          if (dr == DialogResult.No)
          {
            ilvTiles.ResumeLayout();
            return;
          }

          break;
        }
      }

      foreach (ImageListViewItem ilvi in ilvTiles.SelectedItems)
      {
        SiDComponent comp = ilvi.Tag as SiDComponent;
        resourcePack.Remove(comp);
      }
      ilvTiles.ResumeLayout();
    }

    private void ctxRemoveRooms_Click(object sender, EventArgs e)
    {
      ilvRooms.SuspendLayout();
      foreach (ImageListViewItem ilvi in ilvRooms.SelectedItems)
      {
        SiDComponent comp = ilvi.Tag as SiDComponent;
        resourcePack.Remove(comp);
      }
      ilvRooms.ResumeLayout();
    }

    private void ctxRemoveSprites_Click(object sender, EventArgs e)
    {
      ilvSprites.SuspendLayout();

      // check if the use is about to delete something that is depended upon by something else
      Dictionary<Sprite, StateObject> spritesInUse = resourcePack.FindSpritesUsedByObjects();
      foreach (ImageListViewItem ilvi in ilvSprites.SelectedItems)
      {
        if (spritesInUse.ContainsKey(ilvi.Tag as Sprite))
        {
          DialogResult dr = MessageBox.Show(
            "One or more of the sprites you're about to delete are used by Objects in this pack\n\nDeleting them will break those Object layouts.\n\nAre you sure you want to delete?",
            "InSiDe",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Stop);

          if (dr == DialogResult.No)
          {
            ilvSprites.ResumeLayout();
            return;
          }

          break;
        }
      }

      foreach (ImageListViewItem ilvi in ilvSprites.SelectedItems)
      {
        SiDComponent comp = ilvi.Tag as SiDComponent;
        resourcePack.Remove(comp);
      }
      ilvSprites.ResumeLayout();
    }

    private void ctxRemoveObjects_Click(object sender, EventArgs e)
    {
      ilvObjects.SuspendLayout();
      foreach (ImageListViewItem ilvi in ilvObjects.SelectedItems)
      {
        SiDComponent comp = ilvi.Tag as SiDComponent;
        resourcePack.Remove(comp);
      }
      ilvObjects.ResumeLayout();
    }

    #endregion

    #region RCMenu-Renaming

    internal String DisplayCommonRenamingDialog(ImageListView.ImageListViewSelectedItemCollection items)
    {
      RenameComponentDialog rcd = new RenameComponentDialog();
      String commonName = null;

      foreach (ImageListViewItem ilvi in items)
      {
        SiDComponent comp = ilvi.Tag as SiDComponent;
        if (commonName == null)
        {
          commonName = comp.Name;
        }
        else if (commonName != comp.Name)
        {
          commonName = "";
          rcd.noCommonality.Visible = true;
        }
      }

      if (commonName != null)
      {
        rcd.tbNameText.Text = commonName;
        if (rcd.ShowDialog() == DialogResult.OK)
        {
          return rcd.tbNameText.Text;
        }
      }

      return null;
    }

    private void ctxRenameTile_Click(object sender, EventArgs e)
    {
      String newName = DisplayCommonRenamingDialog(ilvTiles.SelectedItems);
      if (newName != null)
      {
        List<ComponentReplacementExchange> componentReplacements = new List<ComponentReplacementExchange>(ilvTiles.SelectedItems.Count);

        foreach (ImageListViewItem ilvi in ilvTiles.SelectedItems)
        {
          SiDComponent comp = ilvi.Tag as SiDComponent;

          // store a mapping from old-UID to new-UID so we can patch up dependent components
          ComponentReplacementExchange crt;
          crt.Old = comp.getUID();

          ilvi.Text = newName;
          comp.Name = newName;

          // UID changes after name does...
          crt.New = comp.getUID();
          componentReplacements.Add(crt);
        }

        // patch changes into Room components
        resourcePack.PatchRoomsForTileChanges(componentReplacements);

        ilvTiles.Invalidate();
        ilvRooms.Invalidate();
      }
    }

    private void ctxRenameSprite_Click(object sender, EventArgs e)
    {
      String newName = DisplayCommonRenamingDialog(ilvSprites.SelectedItems);
      if (newName != null)
      {
        List<ComponentReplacementExchange> componentReplacements = new List<ComponentReplacementExchange>(ilvTiles.SelectedItems.Count);

        foreach (ImageListViewItem ilvi in ilvSprites.SelectedItems)
        {
          SiDComponent comp = ilvi.Tag as SiDComponent;

          // store a mapping from old-UID to new-UID so we can patch up dependent components
          ComponentReplacementExchange crt;
          crt.Old = comp.getUID();

          ilvi.Text = newName;
          comp.Name = newName;

          // UID changes after name does...
          crt.New = comp.getUID();
          componentReplacements.Add(crt);
        }

        // patch changes into Object components
        resourcePack.PatchObjectsForSpriteChanges(componentReplacements);

        ilvSprites.Invalidate();
        ilvObjects.Invalidate();
      }
    }

    private void ctxRenameRoom_Click(object sender, EventArgs e)
    {
      String newName = DisplayCommonRenamingDialog(ilvRooms.SelectedItems);
      if (newName != null)
      {
        foreach (ImageListViewItem ilvi in ilvRooms.SelectedItems)
        {
          SiDComponent comp = ilvi.Tag as SiDComponent;

          ilvi.Text = newName;
          comp.Name = newName;
        }
      }
    }

    private void ctxRenameObject_Click(object sender, EventArgs e)
    {
      String newName = DisplayCommonRenamingDialog(ilvObjects.SelectedItems);
      if (newName != null)
      {
        foreach (ImageListViewItem ilvi in ilvObjects.SelectedItems)
        {
          SiDComponent comp = ilvi.Tag as SiDComponent;

          ilvi.Text = newName;
          comp.Name = newName;
        }
      }
    }

    #endregion

    #region ResourcePackImport

    CacheExplorer ce = null;

    private void mmImportResDir_Click(object sender, EventArgs e)
    {
      if (ce != null)
      {
        ce.BringToFront();
        return;
      }

      if (findResourceCache.ShowDialog() == DialogResult.OK)
      {
        // show progress dialog
        ProcessingProgressForm ip = new ProcessingProgressForm();
        ip.Show();
        Application.DoEvents();

        ce = new CacheExplorer();
        ce.hostPack = resourcePack;

        ce.FormClosed += new FormClosedEventHandler((object _send, FormClosedEventArgs _e) => { ce = null; GC.Collect(); });

        ResourcePack dummyPack = new ResourcePack();
        Cursor.Current = Cursors.WaitCursor;

        // formulate directories to search
        String rootResDir = findResourceCache.SelectedPath;
        String tileDir = rootResDir + Path.DirectorySeparatorChar + "tile" + Path.DirectorySeparatorChar;
        String spriteDir = rootResDir + Path.DirectorySeparatorChar + "sprite" + Path.DirectorySeparatorChar;
        String objectDir = rootResDir + Path.DirectorySeparatorChar + "object" + Path.DirectorySeparatorChar;
        String roomDir = rootResDir + Path.DirectorySeparatorChar + "room" + Path.DirectorySeparatorChar;

        // go look up all the files we'll need to import
        Console.WriteLine("Gathering {0}...", tileDir);
        String[] tileFiles = (Directory.Exists(tileDir)) ? Directory.GetFiles(tileDir) : new String[] {};
        Console.WriteLine("Gathering {0}...", spriteDir);
        String[] spriteFiles = (Directory.Exists(spriteDir)) ? Directory.GetFiles(spriteDir) : new String[] {};
        Console.WriteLine("Gathering {0}...", objectDir);
        String[] objectFiles = (Directory.Exists(objectDir)) ? Directory.GetFiles(objectDir) : new String[] {};
        Console.WriteLine("Gathering {0}...", roomDir);
        String[] roomFiles = (Directory.Exists(roomDir)) ? Directory.GetFiles(roomDir) : new String[] { };
        Application.DoEvents();

        // setup progress bar for all files to load
        ip.progressBarLoad.Maximum = (tileFiles.Length + spriteFiles.Length + objectFiles.Length + roomFiles.Length);

        foreach (String tileFile in tileFiles)
        {
          ip.progressBarLoad.Value++;
          if (Path.GetExtension(tileFile) != "")
            continue;

          try
          {
            Tile t = new Tile();
            t.LoadFromFile(tileFile);
            dummyPack.Add(t);

            Bitmap rep = ResizeBitmap(t.RenderToBitmap(dummyPack), 4.0f);

            ce.tilesCache.Items.Add(t.getUID().ToString(), t.Name, rep);

            ImageListViewItem ilvi = ce.tilesCache.Items[ce.tilesCache.Items.Count - 1];
            ilvi.Tag = tileFile;
          }
          catch (System.Exception ex)
          {
            Console.WriteLine(ex.Message);
          }

          ce.tilesCache.Sort();
        }
      
        foreach (String spriteFile in spriteFiles)
        {
          ip.progressBarLoad.Value++;
          if (Path.GetExtension(spriteFile) != "")
            continue;

          try
          {
            Sprite s = new Sprite();
            s.LoadFromFile(spriteFile);

            Bitmap rep = ResizeBitmap(s.RenderToBitmap(dummyPack), 3.0f);
            dummyPack.Add(s);

            ce.spriteCache.Items.Add(s.getUID().ToString(), s.Name, rep);

            ImageListViewItem ilvi = ce.spriteCache.Items[ce.spriteCache.Items.Count - 1];
            ilvi.Tag = spriteFile;
          }
          catch (System.Exception ex)
          {
            Console.WriteLine(ex.Message);
          }

          ce.spriteCache.Sort();
        }

        foreach (String roomFile in roomFiles)
        {
          ip.progressBarLoad.Value++;
          if (Path.GetExtension(roomFile) != "")
            continue;

          try
          {
            Room r = new Room();
            r.LoadFromFile(roomFile);

            Bitmap rep = r.RenderToBitmap(dummyPack);
            dummyPack.Add(r);

            ce.roomCache.Items.Add(r.getUID().ToString(), r.Name, rep);

            ImageListViewItem ilvi = ce.roomCache.Items[ce.roomCache.Items.Count - 1];
            ilvi.Tag = roomFile;
          }
          catch (System.Exception ex)
          {
            Console.WriteLine(ex.Message);
          }

          ce.roomCache.Sort();
        }

        foreach (String objectFile in objectFiles)
        {
          ip.progressBarLoad.Value++;
          if (Path.GetExtension(objectFile) != "")
            continue;

          try
          {
            StateObject ob = new StateObject();
            ob.LoadFromFile(objectFile);

            Bitmap rep = ob.RenderToBitmap(dummyPack);
            dummyPack.Add(ob);

            ce.objectCache.Items.Add(ob.getUID().ToString(), ob.Name, rep);

            ImageListViewItem ilvi = ce.objectCache.Items[ce.objectCache.Items.Count - 1];
            ilvi.Tag = objectFile;
          }
          catch (System.Exception ex)
          {
            Console.WriteLine(ex.Message);
          }

          ce.objectCache.Sort();
        }

        ip.Close();

        Cursor.Current = Cursors.Default;
        ce.Show();

        GC.Collect();
      }
    }


    #endregion

    #region ImageImport

    private void mmImportTiles_Click(object sender, EventArgs e)
    {
      if (fdImageOpen.ShowDialog() == DialogResult.OK)
      {
        Bitmap toSliceUp = LoadImageAs32ARGB(fdImageOpen.FileName);

        ImageImportForm iif = new ImageImportForm(toSliceUp, typeof(Tile), resourcePack, new CPImageToTile());
        if (iif.ShowDialog() == DialogResult.OK)
          tabControl1.SelectTab(tabPage1);

        toSliceUp.Dispose();
      }
    }

    private void mmImportSprites_Click(object sender, EventArgs e)
    {
      if (fdImageOpen.ShowDialog() == DialogResult.OK)
      {
        Bitmap toSliceUp = LoadImageAs32ARGB(fdImageOpen.FileName);

        ImageImportForm iif = new ImageImportForm(toSliceUp, typeof(Sprite), resourcePack, new CPImageToSprite());
        if (iif.ShowDialog() == DialogResult.OK)
          tabControl1.SelectTab(tabPage2);

        toSliceUp.Dispose();
      }
    }

    private void mmImportRoom_Click(object sender, EventArgs e)
    {
      if (fdImageOpen.ShowDialog() == DialogResult.OK)
      {
        Bitmap toSliceUp = LoadImageAs32ARGB(fdImageOpen.FileName);

        if (toSliceUp.Width != 208 ||
            toSliceUp.Height != 208)
        {
          MessageBox.Show("Input image for slicing into a Room must be exactly 208 x 208 pixels", "InSiDe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          ImageImportForm iif = new ImageImportForm(toSliceUp, typeof(Room), resourcePack, new CPImageToRoom());
          if (iif.ShowDialog() == DialogResult.OK)
            tabControl1.SelectTab(tabPage1);
        }

        toSliceUp.Dispose();
      }
    }

    private void mmImportObject_Click(object sender, EventArgs e)
    {
      if (fdImageOpen.ShowDialog() == DialogResult.OK)
      {
        Bitmap toSliceUp = LoadImageAs32ARGB(fdImageOpen.FileName);

        if (toSliceUp.Width > 208 ||
            toSliceUp.Height > 208)
        {
          MessageBox.Show("Input image for slicing into an Object must be equal to or smaller than 208 x 208 pixels", "InSiDe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          ImageImportForm iif = new ImageImportForm(toSliceUp, typeof(StateObject), resourcePack, new CPImageToObject());
          if (iif.ShowDialog() == DialogResult.OK)
            tabControl1.SelectTab(tabPage2);
        }

        toSliceUp.Dispose();
      }
    }

    #endregion


    private void mmUnpack_Click(object sender, EventArgs e)
    {
      if (fbUnpack.ShowDialog() == DialogResult.OK)
      {
        Directory.CreateDirectory(fbUnpack.SelectedPath);

        String rootDir = fbUnpack.SelectedPath + Path.DirectorySeparatorChar;

        resourcePack.Iterate((SiDComponent comp) =>
          {
            String subdir = rootDir + comp.ResourceTypeName + Path.DirectorySeparatorChar;
            Directory.CreateDirectory(subdir);

            String UIDstr = comp.getUID().ToString();

            if (!(comp is Blob))
            {
              Bitmap render = comp.RenderToBitmap(resourcePack);
              render.Save(subdir + UIDstr + ".png");
            }

            using (FileStream fs = new FileStream(subdir + UIDstr, FileMode.Create))
            {
              byte[] data = comp.SaveToByteStream();
              fs.Write(data, 0, data.Length);
              fs.Close();
            }
          });
      }
    }

    #region ToolsFindUnused

    private void toolsSelectUnusedTiles_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      Int32 indexToMakeVisible = -1;
      List<Tile> unusedTiles = resourcePack.FindUnusedTiles();

      ilvTiles.ClearSelection();
      foreach (Tile t in unusedTiles)
      {
        if (indexToMakeVisible == -1)
          indexToMakeVisible = TrackedComponents[t].Index;

        TrackedComponents[t].Selected = true;
      }

      if (indexToMakeVisible != -1)
        ilvTiles.EnsureVisible(indexToMakeVisible);

      tabControl1.SelectTab(tabPage1);
      ilvTiles.Invalidate();
      MessageBox.Show(String.Format("Found {0} unused tile(s)", unusedTiles.Count), "InSiDe", MessageBoxButtons.OK, MessageBoxIcon.Information);
      Cursor.Current = Cursors.Default;
    }

    private void toolsSelectUnusedSprites_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      Int32 indexToMakeVisible = -1;
      List<Sprite> unusedSprites = resourcePack.FindUnusedSprites();

      ilvSprites.ClearSelection();
      foreach (Sprite s in unusedSprites)
      {
        if (indexToMakeVisible == -1)
          indexToMakeVisible = TrackedComponents[s].Index;

        TrackedComponents[s].Selected = true;
      }

      if (indexToMakeVisible != -1)
        ilvSprites.EnsureVisible(indexToMakeVisible);

      tabControl1.SelectTab(tabPage2);
      ilvSprites.Invalidate();
      MessageBox.Show(String.Format("Found {0} unused sprite(s)", unusedSprites.Count), "InSiDe", MessageBoxButtons.OK, MessageBoxIcon.Information);
      Cursor.Current = Cursors.Default;
    }

    #endregion


    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBox ab = new AboutBox();
      ab.ShowDialog();
    }
  }
}
