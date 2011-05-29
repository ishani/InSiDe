using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace InSiDe
{
  public partial class AboutBox : Form
  {
    public AboutBox()
    {
      InitializeComponent();
    }

    private void AboutBox_Load(object sender, EventArgs e)
    {
      ClientSize = new System.Drawing.Size(512, 256);
    }

    private void label1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Delicious Illegal Space Beer", "InSiDe Recommends", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      ProcessStartInfo sInfo = new ProcessStartInfo(linkLabel1.Text);
      Process.Start(sInfo);
      Close();
    }
  }
}
