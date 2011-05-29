namespace InSiDe
{
  partial class ImageImportForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageImportForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.ControlPanel = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.cycleBG = new System.Windows.Forms.Button();
      this.zoomIn = new System.Windows.Forms.Button();
      this.zoomReset = new System.Windows.Forms.Button();
      this.tbNameText = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.doImport = new System.Windows.Forms.Button();
      this.doCancel = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.imagePreview = new System.Windows.Forms.PictureBox();
      this.panel1.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imagePreview)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ControlPanel);
      this.panel1.Controls.Add(this.panel4);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(381, 0);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(2);
      this.panel1.Size = new System.Drawing.Size(230, 516);
      this.panel1.TabIndex = 1;
      // 
      // ControlPanel
      // 
      this.ControlPanel.AutoScroll = true;
      this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ControlPanel.Location = new System.Drawing.Point(2, 2);
      this.ControlPanel.Name = "ControlPanel";
      this.ControlPanel.Size = new System.Drawing.Size(226, 404);
      this.ControlPanel.TabIndex = 7;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.cycleBG);
      this.panel4.Controls.Add(this.zoomIn);
      this.panel4.Controls.Add(this.zoomReset);
      this.panel4.Controls.Add(this.tbNameText);
      this.panel4.Controls.Add(this.label1);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel4.Location = new System.Drawing.Point(2, 406);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(226, 65);
      this.panel4.TabIndex = 6;
      // 
      // cycleBG
      // 
      this.cycleBG.AutoSize = true;
      this.cycleBG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.cycleBG.Image = global::InSiDe.Properties.Resources.Contrast;
      this.cycleBG.Location = new System.Drawing.Point(32, 34);
      this.cycleBG.Name = "cycleBG";
      this.cycleBG.Size = new System.Drawing.Size(22, 22);
      this.cycleBG.TabIndex = 8;
      this.cycleBG.UseVisualStyleBackColor = true;
      this.cycleBG.Click += new System.EventHandler(this.cycleBG_Click);
      // 
      // zoomIn
      // 
      this.zoomIn.AutoSize = true;
      this.zoomIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.zoomIn.Image = global::InSiDe.Properties.Resources.MagnifierZoomIn;
      this.zoomIn.Location = new System.Drawing.Point(7, 34);
      this.zoomIn.Name = "zoomIn";
      this.zoomIn.Size = new System.Drawing.Size(22, 22);
      this.zoomIn.TabIndex = 7;
      this.zoomIn.UseVisualStyleBackColor = true;
      this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
      // 
      // zoomReset
      // 
      this.zoomReset.AutoSize = true;
      this.zoomReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.zoomReset.Image = global::InSiDe.Properties.Resources.Magnifier;
      this.zoomReset.Location = new System.Drawing.Point(7, 9);
      this.zoomReset.Name = "zoomReset";
      this.zoomReset.Size = new System.Drawing.Size(22, 22);
      this.zoomReset.TabIndex = 6;
      this.zoomReset.UseVisualStyleBackColor = true;
      this.zoomReset.Click += new System.EventHandler(this.zoomReset_Click);
      // 
      // tbNameText
      // 
      this.tbNameText.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbNameText.Location = new System.Drawing.Point(73, 25);
      this.tbNameText.MaxLength = 10;
      this.tbNameText.Name = "tbNameText";
      this.tbNameText.Size = new System.Drawing.Size(145, 31);
      this.tbNameText.TabIndex = 4;
      this.tbNameText.Text = "imported";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(70, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Name for Components :";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.doImport);
      this.panel3.Controls.Add(this.doCancel);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(2, 471);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(226, 43);
      this.panel3.TabIndex = 3;
      // 
      // doImport
      // 
      this.doImport.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.doImport.Location = new System.Drawing.Point(143, 10);
      this.doImport.Name = "doImport";
      this.doImport.Size = new System.Drawing.Size(75, 23);
      this.doImport.TabIndex = 1;
      this.doImport.Text = "Import";
      this.doImport.UseVisualStyleBackColor = true;
      this.doImport.Click += new System.EventHandler(this.doImport_Click);
      // 
      // doCancel
      // 
      this.doCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.doCancel.Location = new System.Drawing.Point(13, 10);
      this.doCancel.Name = "doCancel";
      this.doCancel.Size = new System.Drawing.Size(75, 23);
      this.doCancel.TabIndex = 2;
      this.doCancel.Text = "Cancel";
      this.doCancel.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.imagePreview);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(381, 516);
      this.panel2.TabIndex = 2;
      // 
      // imagePreview
      // 
      this.imagePreview.BackColor = System.Drawing.Color.Silver;
      this.imagePreview.BackgroundImage = global::InSiDe.Properties.Resources.DarkBg;
      this.imagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imagePreview.Location = new System.Drawing.Point(0, 0);
      this.imagePreview.Name = "imagePreview";
      this.imagePreview.Size = new System.Drawing.Size(381, 516);
      this.imagePreview.TabIndex = 0;
      this.imagePreview.TabStop = false;
      this.imagePreview.Paint += new System.Windows.Forms.PaintEventHandler(this.imagePreview_Paint);
      // 
      // ImageImportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(611, 516);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.DoubleBuffered = true;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(500, 300);
      this.Name = "ImageImportForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Image Import ";
      this.panel1.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.imagePreview)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button doImport;
    private System.Windows.Forms.Button doCancel;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox tbNameText;
    private System.Windows.Forms.Panel ControlPanel;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Button zoomReset;
    private System.Windows.Forms.Button zoomIn;
    private System.Windows.Forms.Button cycleBG;
    public System.Windows.Forms.PictureBox imagePreview;
  }
}