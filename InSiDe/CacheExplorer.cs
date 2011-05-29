using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Manina.Windows.Forms;

using SiDcore;

namespace InSiDe
{
  public partial class CacheExplorer : Form
  {
    public ResourcePack hostPack;

    public CacheExplorer()
    {
      InitializeComponent();

      tilesCache.SetRenderer(new ThumbRenderer(4, false));
      tileTabPage.Tag = tilesCache;

      spriteCache.SetRenderer(new ThumbRenderer(4, true));
      spriteTabPage.Tag = spriteCache;

      roomCache.SetRenderer(new ThumbRenderer(4, true));
      roomTabPage.Tag = roomCache;

      objectCache.SetRenderer(new ThumbRenderer(4, true));
      objectTabPage.Tag = objectCache;
    }

    private void CacheExplorer_Load(object sender, EventArgs e)
    {
      if (PlatformUtils.IsRunningMono())
      {
        ctxSpriteDelete.Enabled = false;
        ctxSpriteDelete.Text += " (disabled on Mono)";
        ctxTileDelete.Enabled = false;
        ctxTileDelete.Text += " (disabled on Mono)";
        ctxRoomDelete.Enabled = false;
        ctxRoomDelete.Text += " (disabled on Mono)";
        ctxObjectDelete.Enabled = false;
        ctxObjectDelete.Text += " (disabled on Mono)";
      }
    }

    private void ctxSpriteImport_Click(object sender, EventArgs e)
    {
      Int32 uniqueAdds = 0;
      foreach (ImageListViewItem ilvi in spriteCache.SelectedItems)
      {
        String compFilename = ilvi.Tag as String;

        Sprite sp = new Sprite();
        sp.LoadFromFile(compFilename);

        if (hostPack.Add(sp))
          uniqueAdds++;
      }

      MessageBox.Show(String.Format("Added {0} unique sprites to the current resource pack", uniqueAdds), "InSiDe", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ctxSpriteDelete_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      spriteCache.SuspendLayout();
      foreach (ImageListViewItem ilvi in spriteCache.SelectedItems)
      {
        String compFilename = ilvi.Tag as String;

        if (RecycleBin.RecycleFile(this, compFilename))
        {
          spriteCache.Items.Remove(ilvi);
        }
      }
      spriteCache.ResumeLayout();
      Cursor.Current = Cursors.Default;
    }

    private void ctxTileImport_Click(object sender, EventArgs e)
    {
      Int32 uniqueAdds = 0;
      foreach (ImageListViewItem ilvi in tilesCache.SelectedItems)
      {
        String compFilename = ilvi.Tag as String;

        Tile sp = new Tile();
        sp.LoadFromFile(compFilename);

        if (hostPack.Add(sp))
          uniqueAdds++;
      }

      MessageBox.Show(String.Format("Added {0} unique tiles to the current resource pack", uniqueAdds), "InSiDe", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ctxTileDelete_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      tilesCache.SuspendLayout();
      foreach (ImageListViewItem ilvi in tilesCache.SelectedItems)
      {
        String compFilename = ilvi.Tag as String;

        if (RecycleBin.RecycleFile(this, compFilename))
        {
          tilesCache.Items.Remove(ilvi);
        }
      }
      tilesCache.ResumeLayout();
      Cursor.Current = Cursors.Default;
    }

    private void selByName_Click(object sender, EventArgs e)
    {
      // ignore empty searches
      if (tbSearchText.Text.Length == 0)
        return;

      ImageListView ilv = tcMain.SelectedTab.Tag as ImageListView;
      if (ilv != null)
      {
        ilv.ClearSelection();
        Cursor.Current = Cursors.WaitCursor;

        String namesearch = tbSearchText.Text;
        foreach (ImageListViewItem ilvi in ilv.Items)
        {
          if (ilvi.Text.Contains(namesearch))
          {
            ilvi.Selected = true;
          }
        }

        Cursor.Current = Cursors.Default;
        ilv.Invalidate();

        if (ilv.SelectedItems.Count > 0)
          ilv.EnsureVisible(ilv.SelectedItems[0].Index);
      }
    }

    private void tbSearchText_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Return)
      {
        selByName_Click(sender, new EventArgs());
      }
    }
  }


  static class RecycleBin
  {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
    public struct SHFILEOPSTRUCT
    {
      public IntPtr hwnd;
      [MarshalAs(UnmanagedType.U4)]
      public int wFunc;
      public string pFrom;
      public string pTo;
      public short fFlags;
      [MarshalAs(UnmanagedType.Bool)]
      public bool fAnyOperationsAborted;
      public IntPtr hNameMappings;
      public string lpszProgressTitle;
    }

    [DllImport("shell32.dll", CharSet = CharSet.Auto)]
    static extern int SHFileOperation(ref SHFILEOPSTRUCT FileOp);
    const Int32 FO_DELETE = 3;
    const Int32 FOF_ALLOWUNDO = 0x40;
    const Int32 FOF_NOCONFIRMATION = 0x10;

    public static bool RecycleFile(Form parentForm, String filename)
    {
      SHFILEOPSTRUCT shf = new SHFILEOPSTRUCT();
      shf.hwnd = parentForm.Handle;
      shf.wFunc = FO_DELETE;
      shf.fFlags = FOF_ALLOWUNDO | FOF_NOCONFIRMATION;
      shf.pFrom = filename + "\0\0";

      int res = SHFileOperation(ref shf);
      return (res == 0);
    }
  }

}
