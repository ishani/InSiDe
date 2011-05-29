namespace InSiDe
{
  partial class AboutBox
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 31);
      this.label1.TabIndex = 0;
      this.label1.Text = "InSiDe";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Gainsboro;
      this.label2.Location = new System.Drawing.Point(14, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(383, 26);
      this.label2.TabIndex = 1;
      this.label2.Text = "by Harry Denholm, aka. ishani";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Black;
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(384, 160);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(95, 63);
      this.button1.TabIndex = 2;
      this.button1.Text = "OK!";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // label3
      // 
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(15, 118);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(465, 39);
      this.label3.TabIndex = 3;
      this.label3.Text = "Thanks to everyone on sidtube forums && IRC for the feedback and testing!";
      // 
      // linkLabel1
      // 
      this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
      this.linkLabel1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      this.linkLabel1.Location = new System.Drawing.Point(15, 66);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(184, 16);
      this.linkLabel1.TabIndex = 4;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "http://www.ishani.org/";
      this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // AboutBox
      // 
      this.AcceptButton = this.button1;
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::InSiDe.Properties.Resources.Plate;
      this.CancelButton = this.button1;
      this.ClientSize = new System.Drawing.Size(506, 234);
      this.ControlBox = false;
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutBox";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "The who with the what now?";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.AboutBox_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.LinkLabel linkLabel1;
  }
}