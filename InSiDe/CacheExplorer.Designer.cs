namespace InSiDe
{
  partial class CacheExplorer
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      Manina.Windows.Forms.ImageListViewColor imageListViewColor1 = new Manina.Windows.Forms.ImageListViewColor();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CacheExplorer));
      Manina.Windows.Forms.ImageListViewColor imageListViewColor2 = new Manina.Windows.Forms.ImageListViewColor();
      Manina.Windows.Forms.ImageListViewColor imageListViewColor3 = new Manina.Windows.Forms.ImageListViewColor();
      Manina.Windows.Forms.ImageListViewColor imageListViewColor4 = new Manina.Windows.Forms.ImageListViewColor();
      this.tcMain = new System.Windows.Forms.TabControl();
      this.tileTabPage = new System.Windows.Forms.TabPage();
      this.tilesCache = new Manina.Windows.Forms.ImageListView();
      this.ctxTiles = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ctxTileImport = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ctxTileDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.spriteTabPage = new System.Windows.Forms.TabPage();
      this.spriteCache = new Manina.Windows.Forms.ImageListView();
      this.ctxSprites = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ctxSpriteImport = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ctxSpriteDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.roomTabPage = new System.Windows.Forms.TabPage();
      this.roomCache = new Manina.Windows.Forms.ImageListView();
      this.objectTabPage = new System.Windows.Forms.TabPage();
      this.objectCache = new Manina.Windows.Forms.ImageListView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.selByName = new System.Windows.Forms.Button();
      this.tbSearchText = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.ctxRooms = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ctxRoomImport = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.ctxRoomDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxObjects = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ctxObjectImport = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.ctxObjectDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.tcMain.SuspendLayout();
      this.tileTabPage.SuspendLayout();
      this.ctxTiles.SuspendLayout();
      this.spriteTabPage.SuspendLayout();
      this.ctxSprites.SuspendLayout();
      this.roomTabPage.SuspendLayout();
      this.objectTabPage.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.ctxRooms.SuspendLayout();
      this.ctxObjects.SuspendLayout();
      this.SuspendLayout();
      // 
      // tcMain
      // 
      this.tcMain.Controls.Add(this.tileTabPage);
      this.tcMain.Controls.Add(this.spriteTabPage);
      this.tcMain.Controls.Add(this.roomTabPage);
      this.tcMain.Controls.Add(this.objectTabPage);
      this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tcMain.Location = new System.Drawing.Point(0, 0);
      this.tcMain.Name = "tcMain";
      this.tcMain.SelectedIndex = 0;
      this.tcMain.Size = new System.Drawing.Size(1050, 521);
      this.tcMain.TabIndex = 0;
      // 
      // tileTabPage
      // 
      this.tileTabPage.Controls.Add(this.tilesCache);
      this.tileTabPage.Location = new System.Drawing.Point(4, 22);
      this.tileTabPage.Name = "tileTabPage";
      this.tileTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.tileTabPage.Size = new System.Drawing.Size(1042, 495);
      this.tileTabPage.TabIndex = 0;
      this.tileTabPage.Text = "Tiles";
      this.tileTabPage.UseVisualStyleBackColor = true;
      // 
      // tilesCache
      // 
      this.tilesCache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      imageListViewColor1.BackColor = System.Drawing.SystemColors.Window;
      imageListViewColor1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor1.CellForeColor = System.Drawing.SystemColors.ControlText;
      imageListViewColor1.ColumnHeaderBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
      imageListViewColor1.ColumnHeaderBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
      imageListViewColor1.ColumnHeaderForeColor = System.Drawing.SystemColors.WindowText;
      imageListViewColor1.ColumnHeaderHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor1.ColumnHeaderHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor1.ColumnSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor1.ColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor1.ControlBackColor = System.Drawing.SystemColors.Window;
      imageListViewColor1.ForeColor = System.Drawing.SystemColors.ControlText;
      imageListViewColor1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor1.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor1.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor1.ImageInnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      imageListViewColor1.ImageOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor1.InsertionCaretColor = System.Drawing.SystemColors.Highlight;
      imageListViewColor1.PaneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor1.PaneLabelColor = System.Drawing.SystemColors.GrayText;
      imageListViewColor1.PaneSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor1.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor1.SelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor1.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor1.SelectionRectangleBorderColor = System.Drawing.SystemColors.Highlight;
      imageListViewColor1.SelectionRectangleColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor1.SelectionRectangleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor1.UnFocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor1.UnFocusedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor1.UnFocusedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.tilesCache.Colors = imageListViewColor1;
      this.tilesCache.ContextMenuStrip = this.ctxTiles;
      this.tilesCache.Cursor = System.Windows.Forms.Cursors.Default;
      this.tilesCache.DefaultImage = ((System.Drawing.Image)(resources.GetObject("tilesCache.DefaultImage")));
      this.tilesCache.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tilesCache.ErrorImage = ((System.Drawing.Image)(resources.GetObject("tilesCache.ErrorImage")));
      this.tilesCache.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tilesCache.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tilesCache.Location = new System.Drawing.Point(3, 3);
      this.tilesCache.Name = "tilesCache";
      this.tilesCache.PaneWidth = 200;
      this.tilesCache.Size = new System.Drawing.Size(1036, 489);
      this.tilesCache.SortOrder = System.Windows.Forms.SortOrder.Ascending;
      this.tilesCache.TabIndex = 3;
      this.tilesCache.Text = "";
      this.tilesCache.ThumbnailSize = new System.Drawing.Size(72, 64);
      // 
      // ctxTiles
      // 
      this.ctxTiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxTileImport,
            this.toolStripSeparator2,
            this.ctxTileDelete});
      this.ctxTiles.Name = "ctxSprites";
      this.ctxTiles.Size = new System.Drawing.Size(255, 76);
      // 
      // ctxTileImport
      // 
      this.ctxTileImport.Name = "ctxTileImport";
      this.ctxTileImport.Size = new System.Drawing.Size(254, 22);
      this.ctxTileImport.Text = "Import into current Resource Pack";
      this.ctxTileImport.Click += new System.EventHandler(this.ctxTileImport_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
      // 
      // ctxTileDelete
      // 
      this.ctxTileDelete.Name = "ctxTileDelete";
      this.ctxTileDelete.Size = new System.Drawing.Size(254, 22);
      this.ctxTileDelete.Text = "Move File to Recycle Bin";
      this.ctxTileDelete.Click += new System.EventHandler(this.ctxTileDelete_Click);
      // 
      // spriteTabPage
      // 
      this.spriteTabPage.Controls.Add(this.spriteCache);
      this.spriteTabPage.Location = new System.Drawing.Point(4, 22);
      this.spriteTabPage.Name = "spriteTabPage";
      this.spriteTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.spriteTabPage.Size = new System.Drawing.Size(1042, 495);
      this.spriteTabPage.TabIndex = 1;
      this.spriteTabPage.Text = "Sprites";
      this.spriteTabPage.UseVisualStyleBackColor = true;
      // 
      // spriteCache
      // 
      this.spriteCache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      imageListViewColor2.BackColor = System.Drawing.SystemColors.Window;
      imageListViewColor2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor2.CellForeColor = System.Drawing.SystemColors.ControlText;
      imageListViewColor2.ColumnHeaderBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
      imageListViewColor2.ColumnHeaderBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
      imageListViewColor2.ColumnHeaderForeColor = System.Drawing.SystemColors.WindowText;
      imageListViewColor2.ColumnHeaderHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor2.ColumnHeaderHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor2.ColumnSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor2.ColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor2.ControlBackColor = System.Drawing.SystemColors.Window;
      imageListViewColor2.ForeColor = System.Drawing.SystemColors.ControlText;
      imageListViewColor2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor2.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor2.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor2.ImageInnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      imageListViewColor2.ImageOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor2.InsertionCaretColor = System.Drawing.SystemColors.Highlight;
      imageListViewColor2.PaneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor2.PaneLabelColor = System.Drawing.SystemColors.GrayText;
      imageListViewColor2.PaneSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor2.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor2.SelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor2.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor2.SelectionRectangleBorderColor = System.Drawing.SystemColors.Highlight;
      imageListViewColor2.SelectionRectangleColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor2.SelectionRectangleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor2.UnFocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor2.UnFocusedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor2.UnFocusedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.spriteCache.Colors = imageListViewColor2;
      this.spriteCache.ContextMenuStrip = this.ctxSprites;
      this.spriteCache.Cursor = System.Windows.Forms.Cursors.Default;
      this.spriteCache.DefaultImage = ((System.Drawing.Image)(resources.GetObject("spriteCache.DefaultImage")));
      this.spriteCache.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spriteCache.ErrorImage = ((System.Drawing.Image)(resources.GetObject("spriteCache.ErrorImage")));
      this.spriteCache.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.spriteCache.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.spriteCache.Location = new System.Drawing.Point(3, 3);
      this.spriteCache.Name = "spriteCache";
      this.spriteCache.PaneWidth = 200;
      this.spriteCache.Size = new System.Drawing.Size(1036, 489);
      this.spriteCache.SortOrder = System.Windows.Forms.SortOrder.Ascending;
      this.spriteCache.TabIndex = 4;
      this.spriteCache.Text = "";
      this.spriteCache.ThumbnailSize = new System.Drawing.Size(72, 64);
      // 
      // ctxSprites
      // 
      this.ctxSprites.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSpriteImport,
            this.toolStripSeparator1,
            this.ctxSpriteDelete});
      this.ctxSprites.Name = "ctxSprites";
      this.ctxSprites.Size = new System.Drawing.Size(255, 54);
      // 
      // ctxSpriteImport
      // 
      this.ctxSpriteImport.Name = "ctxSpriteImport";
      this.ctxSpriteImport.Size = new System.Drawing.Size(254, 22);
      this.ctxSpriteImport.Text = "Import into current Resource Pack";
      this.ctxSpriteImport.Click += new System.EventHandler(this.ctxSpriteImport_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
      // 
      // ctxSpriteDelete
      // 
      this.ctxSpriteDelete.Name = "ctxSpriteDelete";
      this.ctxSpriteDelete.Size = new System.Drawing.Size(254, 22);
      this.ctxSpriteDelete.Text = "Move File to Recycle Bin";
      this.ctxSpriteDelete.Click += new System.EventHandler(this.ctxSpriteDelete_Click);
      // 
      // roomTabPage
      // 
      this.roomTabPage.Controls.Add(this.roomCache);
      this.roomTabPage.Location = new System.Drawing.Point(4, 22);
      this.roomTabPage.Name = "roomTabPage";
      this.roomTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.roomTabPage.Size = new System.Drawing.Size(1042, 495);
      this.roomTabPage.TabIndex = 2;
      this.roomTabPage.Text = "Rooms";
      this.roomTabPage.UseVisualStyleBackColor = true;
      // 
      // roomCache
      // 
      this.roomCache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      imageListViewColor3.BackColor = System.Drawing.SystemColors.Window;
      imageListViewColor3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor3.CellForeColor = System.Drawing.SystemColors.ControlText;
      imageListViewColor3.ColumnHeaderBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
      imageListViewColor3.ColumnHeaderBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
      imageListViewColor3.ColumnHeaderForeColor = System.Drawing.SystemColors.WindowText;
      imageListViewColor3.ColumnHeaderHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor3.ColumnHeaderHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor3.ColumnSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor3.ColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor3.ControlBackColor = System.Drawing.SystemColors.Window;
      imageListViewColor3.ForeColor = System.Drawing.SystemColors.ControlText;
      imageListViewColor3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor3.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor3.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor3.ImageInnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      imageListViewColor3.ImageOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor3.InsertionCaretColor = System.Drawing.SystemColors.Highlight;
      imageListViewColor3.PaneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor3.PaneLabelColor = System.Drawing.SystemColors.GrayText;
      imageListViewColor3.PaneSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor3.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor3.SelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor3.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor3.SelectionRectangleBorderColor = System.Drawing.SystemColors.Highlight;
      imageListViewColor3.SelectionRectangleColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor3.SelectionRectangleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor3.UnFocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor3.UnFocusedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor3.UnFocusedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.roomCache.Colors = imageListViewColor3;
      this.roomCache.Cursor = System.Windows.Forms.Cursors.Default;
      this.roomCache.DefaultImage = ((System.Drawing.Image)(resources.GetObject("roomCache.DefaultImage")));
      this.roomCache.Dock = System.Windows.Forms.DockStyle.Fill;
      this.roomCache.ErrorImage = ((System.Drawing.Image)(resources.GetObject("roomCache.ErrorImage")));
      this.roomCache.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.roomCache.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.roomCache.Location = new System.Drawing.Point(3, 3);
      this.roomCache.Name = "roomCache";
      this.roomCache.PaneWidth = 200;
      this.roomCache.Size = new System.Drawing.Size(1036, 489);
      this.roomCache.SortOrder = System.Windows.Forms.SortOrder.Ascending;
      this.roomCache.TabIndex = 4;
      this.roomCache.Text = "";
      this.roomCache.ThumbnailSize = new System.Drawing.Size(208, 208);
      // 
      // objectTabPage
      // 
      this.objectTabPage.Controls.Add(this.objectCache);
      this.objectTabPage.Location = new System.Drawing.Point(4, 22);
      this.objectTabPage.Name = "objectTabPage";
      this.objectTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.objectTabPage.Size = new System.Drawing.Size(1042, 495);
      this.objectTabPage.TabIndex = 3;
      this.objectTabPage.Text = "Objects";
      this.objectTabPage.UseVisualStyleBackColor = true;
      // 
      // objectCache
      // 
      this.objectCache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      imageListViewColor4.BackColor = System.Drawing.SystemColors.Window;
      imageListViewColor4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor4.CellForeColor = System.Drawing.SystemColors.ControlText;
      imageListViewColor4.ColumnHeaderBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
      imageListViewColor4.ColumnHeaderBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
      imageListViewColor4.ColumnHeaderForeColor = System.Drawing.SystemColors.WindowText;
      imageListViewColor4.ColumnHeaderHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor4.ColumnHeaderHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor4.ColumnSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor4.ColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor4.ControlBackColor = System.Drawing.SystemColors.Window;
      imageListViewColor4.ForeColor = System.Drawing.SystemColors.ControlText;
      imageListViewColor4.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor4.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor4.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor4.ImageInnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      imageListViewColor4.ImageOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor4.InsertionCaretColor = System.Drawing.SystemColors.Highlight;
      imageListViewColor4.PaneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor4.PaneLabelColor = System.Drawing.SystemColors.GrayText;
      imageListViewColor4.PaneSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor4.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor4.SelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor4.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor4.SelectionRectangleBorderColor = System.Drawing.SystemColors.Highlight;
      imageListViewColor4.SelectionRectangleColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor4.SelectionRectangleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
      imageListViewColor4.UnFocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor4.UnFocusedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      imageListViewColor4.UnFocusedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.objectCache.Colors = imageListViewColor4;
      this.objectCache.Cursor = System.Windows.Forms.Cursors.Default;
      this.objectCache.DefaultImage = ((System.Drawing.Image)(resources.GetObject("objectCache.DefaultImage")));
      this.objectCache.Dock = System.Windows.Forms.DockStyle.Fill;
      this.objectCache.ErrorImage = ((System.Drawing.Image)(resources.GetObject("objectCache.ErrorImage")));
      this.objectCache.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.objectCache.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.objectCache.Location = new System.Drawing.Point(3, 3);
      this.objectCache.Name = "objectCache";
      this.objectCache.PaneWidth = 200;
      this.objectCache.Size = new System.Drawing.Size(1036, 489);
      this.objectCache.SortOrder = System.Windows.Forms.SortOrder.Ascending;
      this.objectCache.TabIndex = 4;
      this.objectCache.Text = "";
      this.objectCache.ThumbnailSize = new System.Drawing.Size(208, 208);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.selByName);
      this.panel1.Controls.Add(this.tbSearchText);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 521);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1050, 45);
      this.panel1.TabIndex = 1;
      // 
      // selByName
      // 
      this.selByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.selByName.Location = new System.Drawing.Point(730, 7);
      this.selByName.Name = "selByName";
      this.selByName.Size = new System.Drawing.Size(116, 30);
      this.selByName.TabIndex = 2;
      this.selByName.Text = "Select By Name :";
      this.selByName.UseVisualStyleBackColor = true;
      this.selByName.Click += new System.EventHandler(this.selByName_Click);
      // 
      // tbSearchText
      // 
      this.tbSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.tbSearchText.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbSearchText.Location = new System.Drawing.Point(851, 6);
      this.tbSearchText.MaxLength = 10;
      this.tbSearchText.Name = "tbSearchText";
      this.tbSearchText.Size = new System.Drawing.Size(188, 31);
      this.tbSearchText.TabIndex = 1;
      this.tbSearchText.Text = "default";
      this.tbSearchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchText_KeyUp);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.tcMain);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1050, 521);
      this.panel2.TabIndex = 2;
      // 
      // ctxRooms
      // 
      this.ctxRooms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxRoomImport,
            this.toolStripSeparator3,
            this.ctxRoomDelete});
      this.ctxRooms.Name = "ctxSprites";
      this.ctxRooms.Size = new System.Drawing.Size(255, 54);
      // 
      // ctxRoomImport
      // 
      this.ctxRoomImport.Name = "ctxRoomImport";
      this.ctxRoomImport.Size = new System.Drawing.Size(254, 22);
      this.ctxRoomImport.Text = "Import into current Resource Pack";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(251, 6);
      // 
      // ctxRoomDelete
      // 
      this.ctxRoomDelete.Name = "ctxRoomDelete";
      this.ctxRoomDelete.Size = new System.Drawing.Size(254, 22);
      this.ctxRoomDelete.Text = "Move File to Recycle Bin";
      // 
      // ctxObjects
      // 
      this.ctxObjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxObjectImport,
            this.toolStripSeparator4,
            this.ctxObjectDelete});
      this.ctxObjects.Name = "ctxSprites";
      this.ctxObjects.Size = new System.Drawing.Size(255, 54);
      // 
      // ctxObjectImport
      // 
      this.ctxObjectImport.Name = "ctxObjectImport";
      this.ctxObjectImport.Size = new System.Drawing.Size(254, 22);
      this.ctxObjectImport.Text = "Import into current Resource Pack";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(251, 6);
      // 
      // ctxObjectDelete
      // 
      this.ctxObjectDelete.Name = "ctxObjectDelete";
      this.ctxObjectDelete.Size = new System.Drawing.Size(254, 22);
      this.ctxObjectDelete.Text = "Move File to Recycle Bin";
      // 
      // CacheExplorer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1050, 566);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "CacheExplorer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Cache Explorer";
      this.Load += new System.EventHandler(this.CacheExplorer_Load);
      this.tcMain.ResumeLayout(false);
      this.tileTabPage.ResumeLayout(false);
      this.ctxTiles.ResumeLayout(false);
      this.spriteTabPage.ResumeLayout(false);
      this.ctxSprites.ResumeLayout(false);
      this.roomTabPage.ResumeLayout(false);
      this.objectTabPage.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.ctxRooms.ResumeLayout(false);
      this.ctxObjects.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tcMain;
    private System.Windows.Forms.TabPage tileTabPage;
    private System.Windows.Forms.TabPage spriteTabPage;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    public Manina.Windows.Forms.ImageListView tilesCache;
    public Manina.Windows.Forms.ImageListView spriteCache;
    private System.Windows.Forms.ToolStripMenuItem ctxSpriteImport;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ctxSpriteDelete;
    private System.Windows.Forms.ToolStripMenuItem ctxTileImport;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem ctxTileDelete;
    private System.Windows.Forms.Button selByName;
    private System.Windows.Forms.TextBox tbSearchText;
    private System.Windows.Forms.TabPage roomTabPage;
    public Manina.Windows.Forms.ImageListView roomCache;
    private System.Windows.Forms.TabPage objectTabPage;
    public Manina.Windows.Forms.ImageListView objectCache;
    internal System.Windows.Forms.ContextMenuStrip ctxSprites;
    internal System.Windows.Forms.ContextMenuStrip ctxTiles;
    internal System.Windows.Forms.ContextMenuStrip ctxRooms;
    private System.Windows.Forms.ToolStripMenuItem ctxRoomImport;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem ctxRoomDelete;
    internal System.Windows.Forms.ContextMenuStrip ctxObjects;
    private System.Windows.Forms.ToolStripMenuItem ctxObjectImport;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem ctxObjectDelete;
  }
}