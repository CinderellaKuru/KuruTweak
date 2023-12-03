using System;
using System.Windows.Forms;

namespace KuruTweakGUI
{
    internal static class Program
    {
        public static readonly Version Version = new Version(major: DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
    }
}
