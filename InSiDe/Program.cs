using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

using SiDcore;

namespace InSiDe
{
  static public class PlatformUtils
  {
    static public bool IsRunningMono()
    {
      return Type.GetType("Mono.Runtime") != null;
    }
  }

  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      if (PlatformUtils.IsRunningMono())
      {
        Console.WriteLine("Mono, eh? Good to know. InSiDe will adapt accordingly.");
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new InSiDeForm());
    }
  }
}
