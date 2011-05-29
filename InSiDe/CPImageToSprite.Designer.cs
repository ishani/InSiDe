namespace InSiDe
{
  partial class CPImageToSprite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPImageToSprite));
      this.gapInY = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.gapInX = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.colourDialog = new System.Windows.Forms.ColorDialog();
      this.colourSwatch = new System.Windows.Forms.PictureBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.bgTrans = new System.Windows.Forms.CheckBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.chooseBG = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gapInY)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gapInX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.colourSwatch)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // gapInY
      // 
      this.gapInY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gapInY.Location = new System.Drawing.Point(126, 77);
      this.gapInY.Name = "gapInY";
      this.gapInY.Size = new System.Drawing.Size(48, 21);
      this.gapInY.TabIndex = 0;
      this.gapInY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(98, 77);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(22, 21);
      this.label1.TabIndex = 1;
      this.label1.Text = "Y :";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.pictureBox1);
      this.groupBox1.Controls.Add(this.gapInX);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.gapInY);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(9, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(189, 115);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Gap Between Each Tile";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(48, 25);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(92, 38);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // gapInX
      // 
      this.gapInX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gapInX.Location = new System.Drawing.Point(43, 77);
      this.gapInX.Name = "gapInX";
      this.gapInX.Size = new System.Drawing.Size(48, 21);
      this.gapInX.TabIndex = 2;
      this.gapInX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(15, 77);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(22, 21);
      this.label2.TabIndex = 3;
      this.label2.Text = "X :";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // colourDialog
      // 
      this.colourDialog.AnyColor = true;
      // 
      // colourSwatch
      // 
      this.colourSwatch.BackColor = System.Drawing.Color.Black;
      this.colourSwatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.colourSwatch.Location = new System.Drawing.Point(121, 94);
      this.colourSwatch.Name = "colourSwatch";
      this.colourSwatch.Size = new System.Drawing.Size(48, 23);
      this.colourSwatch.TabIndex = 3;
      this.colourSwatch.TabStop = false;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.bgTrans);
      this.groupBox2.Controls.Add(this.pictureBox2);
      this.groupBox2.Controls.Add(this.chooseBG);
      this.groupBox2.Controls.Add(this.colourSwatch);
      this.groupBox2.Location = new System.Drawing.Point(9, 133);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(189, 133);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Background Fill";
      // 
      // bgTrans
      // 
      this.bgTrans.AutoSize = true;
      this.bgTrans.Checked = true;
      this.bgTrans.CheckState = System.Windows.Forms.CheckState.Checked;
      this.bgTrans.Location = new System.Drawing.Point(27, 72);
      this.bgTrans.Name = "bgTrans";
      this.bgTrans.Size = new System.Drawing.Size(83, 17);
      this.bgTrans.TabIndex = 6;
      this.bgTrans.Text = "Transparent";
      this.bgTrans.UseVisualStyleBackColor = true;
      this.bgTrans.CheckedChanged += new System.EventHandler(this.bgTrans_CheckedChanged);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::InSiDe.Properties.Resources.HelpBG;
      this.pictureBox2.Location = new System.Drawing.Point(56, 25);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(77, 38);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox2.TabIndex = 5;
      this.pictureBox2.TabStop = false;
      // 
      // chooseBG
      // 
      this.chooseBG.Enabled = false;
      this.chooseBG.Location = new System.Drawing.Point(20, 94);
      this.chooseBG.Name = "chooseBG";
      this.chooseBG.Size = new System.Drawing.Size(95, 23);
      this.chooseBG.TabIndex = 4;
      this.chooseBG.Text = "Choose...";
      this.chooseBG.UseVisualStyleBackColor = true;
      this.chooseBG.Click += new System.EventHandler(this.chooseBG_Click);
      // 
      // CPImageToSprite
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(206, 278);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "CPImageToSprite";
      this.Text = "CPImageToTile";
      ((System.ComponentModel.ISupportInitialize)(this.gapInY)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gapInX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.colourSwatch)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NumericUpDown gapInY;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.NumericUpDown gapInX;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ColorDialog colourDialog;
    private System.Windows.Forms.PictureBox colourSwatch;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button chooseBG;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.CheckBox bgTrans;
  }
}