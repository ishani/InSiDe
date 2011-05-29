namespace InSiDe
{
  partial class CPImageToObject
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
      this.colourDialog = new System.Windows.Forms.ColorDialog();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.colourSwatch = new System.Windows.Forms.PictureBox();
      this.previewSel = new System.Windows.Forms.CheckBox();
      this.chooseFG = new System.Windows.Forms.Button();
      this.previewUnder = new System.Windows.Forms.RadioButton();
      this.previewOver = new System.Windows.Forms.RadioButton();
      this.previewNone = new System.Windows.Forms.RadioButton();
      this.alignToCenter = new System.Windows.Forms.CheckBox();
      this.edgeTL = new System.Windows.Forms.RadioButton();
      this.edgeBL = new System.Windows.Forms.RadioButton();
      this.edgeTR = new System.Windows.Forms.RadioButton();
      this.edgeBR = new System.Windows.Forms.RadioButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lbSubs = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.extractMultiple = new System.Windows.Forms.CheckBox();
      this.spacingX = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.spacingY = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.findInnerEdges = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.colourSwatch)).BeginInit();
      this.panel1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spacingX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spacingY)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // colourDialog
      // 
      this.colourDialog.AnyColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.colourSwatch);
      this.groupBox1.Controls.Add(this.previewSel);
      this.groupBox1.Controls.Add(this.chooseFG);
      this.groupBox1.Controls.Add(this.previewUnder);
      this.groupBox1.Controls.Add(this.previewOver);
      this.groupBox1.Controls.Add(this.previewNone);
      this.groupBox1.Location = new System.Drawing.Point(9, 263);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(189, 100);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Preview Sprite Slicing";
      // 
      // colourSwatch
      // 
      this.colourSwatch.BackColor = System.Drawing.Color.Magenta;
      this.colourSwatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.colourSwatch.Location = new System.Drawing.Point(129, 45);
      this.colourSwatch.Name = "colourSwatch";
      this.colourSwatch.Size = new System.Drawing.Size(48, 23);
      this.colourSwatch.TabIndex = 5;
      this.colourSwatch.TabStop = false;
      // 
      // previewSel
      // 
      this.previewSel.AutoSize = true;
      this.previewSel.Enabled = false;
      this.previewSel.Location = new System.Drawing.Point(17, 73);
      this.previewSel.Name = "previewSel";
      this.previewSel.Size = new System.Drawing.Size(92, 17);
      this.previewSel.TabIndex = 12;
      this.previewSel.Text = "Selected Only";
      this.previewSel.UseVisualStyleBackColor = true;
      this.previewSel.CheckedChanged += new System.EventHandler(this.previewSel_CheckedChanged);
      // 
      // chooseFG
      // 
      this.chooseFG.Location = new System.Drawing.Point(9, 45);
      this.chooseFG.Name = "chooseFG";
      this.chooseFG.Size = new System.Drawing.Size(106, 23);
      this.chooseFG.TabIndex = 6;
      this.chooseFG.Text = "Colour...";
      this.chooseFG.UseVisualStyleBackColor = true;
      this.chooseFG.Click += new System.EventHandler(this.chooseFG_Click);
      // 
      // previewUnder
      // 
      this.previewUnder.AutoSize = true;
      this.previewUnder.Location = new System.Drawing.Point(127, 21);
      this.previewUnder.Name = "previewUnder";
      this.previewUnder.Size = new System.Drawing.Size(54, 17);
      this.previewUnder.TabIndex = 2;
      this.previewUnder.Text = "Under";
      this.previewUnder.UseVisualStyleBackColor = true;
      this.previewUnder.CheckedChanged += new System.EventHandler(this.previewNone_CheckedChanged);
      // 
      // previewOver
      // 
      this.previewOver.AutoSize = true;
      this.previewOver.Checked = true;
      this.previewOver.Location = new System.Drawing.Point(67, 21);
      this.previewOver.Name = "previewOver";
      this.previewOver.Size = new System.Drawing.Size(48, 17);
      this.previewOver.TabIndex = 1;
      this.previewOver.TabStop = true;
      this.previewOver.Text = "Over";
      this.previewOver.UseVisualStyleBackColor = true;
      this.previewOver.CheckedChanged += new System.EventHandler(this.previewNone_CheckedChanged);
      // 
      // previewNone
      // 
      this.previewNone.AutoSize = true;
      this.previewNone.Location = new System.Drawing.Point(9, 21);
      this.previewNone.Name = "previewNone";
      this.previewNone.Size = new System.Drawing.Size(51, 17);
      this.previewNone.TabIndex = 0;
      this.previewNone.Text = "None";
      this.previewNone.UseVisualStyleBackColor = true;
      this.previewNone.CheckedChanged += new System.EventHandler(this.previewNone_CheckedChanged);
      // 
      // alignToCenter
      // 
      this.alignToCenter.AutoSize = true;
      this.alignToCenter.Checked = true;
      this.alignToCenter.CheckState = System.Windows.Forms.CheckState.Checked;
      this.alignToCenter.Location = new System.Drawing.Point(9, 369);
      this.alignToCenter.Name = "alignToCenter";
      this.alignToCenter.Size = new System.Drawing.Size(168, 17);
      this.alignToCenter.TabIndex = 4;
      this.alignToCenter.Text = "Align Sprites To Object Center";
      this.alignToCenter.UseVisualStyleBackColor = true;
      // 
      // edgeTL
      // 
      this.edgeTL.AutoSize = true;
      this.edgeTL.Checked = true;
      this.edgeTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.edgeTL.Location = new System.Drawing.Point(3, 3);
      this.edgeTL.Name = "edgeTL";
      this.edgeTL.Size = new System.Drawing.Size(13, 12);
      this.edgeTL.TabIndex = 5;
      this.edgeTL.TabStop = true;
      this.edgeTL.UseVisualStyleBackColor = true;
      this.edgeTL.CheckedChanged += new System.EventHandler(this.ExtractionValueChanged);
      // 
      // edgeBL
      // 
      this.edgeBL.AutoSize = true;
      this.edgeBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.edgeBL.Location = new System.Drawing.Point(3, 28);
      this.edgeBL.Name = "edgeBL";
      this.edgeBL.Size = new System.Drawing.Size(13, 12);
      this.edgeBL.TabIndex = 6;
      this.edgeBL.UseVisualStyleBackColor = true;
      this.edgeBL.CheckedChanged += new System.EventHandler(this.ExtractionValueChanged);
      // 
      // edgeTR
      // 
      this.edgeTR.AutoSize = true;
      this.edgeTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.edgeTR.Location = new System.Drawing.Point(27, 3);
      this.edgeTR.Name = "edgeTR";
      this.edgeTR.Size = new System.Drawing.Size(13, 12);
      this.edgeTR.TabIndex = 7;
      this.edgeTR.UseVisualStyleBackColor = true;
      this.edgeTR.CheckedChanged += new System.EventHandler(this.ExtractionValueChanged);
      // 
      // edgeBR
      // 
      this.edgeBR.AutoSize = true;
      this.edgeBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.edgeBR.Location = new System.Drawing.Point(27, 28);
      this.edgeBR.Name = "edgeBR";
      this.edgeBR.Size = new System.Drawing.Size(13, 12);
      this.edgeBR.TabIndex = 8;
      this.edgeBR.UseVisualStyleBackColor = true;
      this.edgeBR.CheckedChanged += new System.EventHandler(this.ExtractionValueChanged);
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.edgeBL);
      this.panel1.Controls.Add(this.edgeBR);
      this.panel1.Controls.Add(this.edgeTL);
      this.panel1.Controls.Add(this.edgeTR);
      this.panel1.Location = new System.Drawing.Point(125, 35);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(45, 45);
      this.panel1.TabIndex = 9;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lbSubs);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.extractMultiple);
      this.groupBox2.Controls.Add(this.spacingX);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.spacingY);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Location = new System.Drawing.Point(9, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(189, 145);
      this.groupBox2.TabIndex = 10;
      this.groupBox2.TabStop = false;
      // 
      // lbSubs
      // 
      this.lbSubs.Enabled = false;
      this.lbSubs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbSubs.FormattingEnabled = true;
      this.lbSubs.ItemHeight = 14;
      this.lbSubs.Location = new System.Drawing.Point(9, 76);
      this.lbSubs.Name = "lbSubs";
      this.lbSubs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.lbSubs.Size = new System.Drawing.Size(172, 60);
      this.lbSubs.TabIndex = 6;
      this.lbSubs.SelectedIndexChanged += new System.EventHandler(this.lbSubs_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 26);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Spacing :";
      // 
      // extractMultiple
      // 
      this.extractMultiple.AutoSize = true;
      this.extractMultiple.Location = new System.Drawing.Point(9, 0);
      this.extractMultiple.Name = "extractMultiple";
      this.extractMultiple.Size = new System.Drawing.Size(137, 17);
      this.extractMultiple.TabIndex = 4;
      this.extractMultiple.Text = "Extract Multiple Objects";
      this.extractMultiple.UseVisualStyleBackColor = true;
      this.extractMultiple.CheckedChanged += new System.EventHandler(this.extractMultiple_CheckedChanged);
      // 
      // spacingX
      // 
      this.spacingX.Enabled = false;
      this.spacingX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.spacingX.Location = new System.Drawing.Point(43, 45);
      this.spacingX.Name = "spacingX";
      this.spacingX.Size = new System.Drawing.Size(48, 21);
      this.spacingX.TabIndex = 2;
      this.spacingX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.spacingX.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
      this.spacingX.ValueChanged += new System.EventHandler(this.ExtractionValueChanged);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(15, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(22, 21);
      this.label2.TabIndex = 3;
      this.label2.Text = "X :";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // spacingY
      // 
      this.spacingY.Enabled = false;
      this.spacingY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.spacingY.Location = new System.Drawing.Point(126, 45);
      this.spacingY.Name = "spacingY";
      this.spacingY.Size = new System.Drawing.Size(48, 21);
      this.spacingY.TabIndex = 0;
      this.spacingY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.spacingY.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
      this.spacingY.ValueChanged += new System.EventHandler(this.ExtractionValueChanged);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(98, 45);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(22, 21);
      this.label1.TabIndex = 1;
      this.label1.Text = "Y :";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.findInnerEdges);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.panel1);
      this.groupBox3.Location = new System.Drawing.Point(9, 163);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(189, 94);
      this.groupBox3.TabIndex = 11;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Sprite Slicing";
      // 
      // findInnerEdges
      // 
      this.findInnerEdges.AutoSize = true;
      this.findInnerEdges.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
      this.findInnerEdges.Checked = true;
      this.findInnerEdges.CheckState = System.Windows.Forms.CheckState.Checked;
      this.findInnerEdges.Location = new System.Drawing.Point(9, 35);
      this.findInnerEdges.Name = "findInnerEdges";
      this.findInnerEdges.Size = new System.Drawing.Size(91, 31);
      this.findInnerEdges.TabIndex = 11;
      this.findInnerEdges.Text = "Find Inner Edges";
      this.findInnerEdges.UseVisualStyleBackColor = true;
      this.findInnerEdges.CheckedChanged += new System.EventHandler(this.ExtractionValueChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(118, 18);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(59, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Initial Edge";
      // 
      // CPImageToObject
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(206, 396);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.alignToCenter);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "CPImageToObject";
      this.Text = "CPImageToTile";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.colourSwatch)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spacingX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spacingY)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ColorDialog colourDialog;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton previewUnder;
    private System.Windows.Forms.RadioButton previewOver;
    private System.Windows.Forms.RadioButton previewNone;
    private System.Windows.Forms.CheckBox alignToCenter;
    private System.Windows.Forms.Button chooseFG;
    private System.Windows.Forms.PictureBox colourSwatch;
    private System.Windows.Forms.RadioButton edgeTL;
    private System.Windows.Forms.RadioButton edgeBL;
    private System.Windows.Forms.RadioButton edgeTR;
    private System.Windows.Forms.RadioButton edgeBR;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox extractMultiple;
    private System.Windows.Forms.NumericUpDown spacingX;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown spacingY;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox lbSubs;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.CheckBox previewSel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox findInnerEdges;
  }
}