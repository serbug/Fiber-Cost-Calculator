//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kruskal
{
    static class Program
    {
      //START
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
