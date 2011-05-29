namespace InSiDe
{
  partial class RenameComponentDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameComponentDialog));
      this.tbNameText = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.noCommonality = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // tbNameText
      // 
      this.tbNameText.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbNameText.Location = new System.Drawing.Point(12, 12);
      this.tbNameText.MaxLength = 10;
      this.tbNameText.Name = "tbNameText";
      this.tbNameText.Size = new System.Drawing.Size(339, 31);
      this.tbNameText.TabIndex = 0;
      this.tbNameText.Text = "default";
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.Location = new System.Drawing.Point(276, 70);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Rename";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button2.Location = new System.Drawing.Point(12, 70);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // noCommonality
      // 
      this.noCommonality.AutoSize = true;
      this.noCommonality.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.noCommonality.Location = new System.Drawing.Point(88, 46);
      this.noCommonality.Name = "noCommonality";
      this.noCommonality.Size = new System.Drawing.Size(190, 13);
      this.noCommonality.TabIndex = 3;
      this.noCommonality.Text = "-- no common name in selected items --";
      this.noCommonality.Visible = false;
      // 
      // RenameComponentDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(363, 105);
      this.Controls.Add(this.noCommonality);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.tbNameText);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "RenameComponentDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Rename Component(s)...";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.TextBox tbNameText;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    public System.Windows.Forms.Label noCommonality;
  }
}