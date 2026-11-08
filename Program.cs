using System;
using System.Windows.Forms;

namespace GSX_Studio
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // The recovered updater is no longer started automatically. Preserve
            // direct project-file opening without passing flags to the form.
            string[] projectArgs = args.Length > 0 &&
                args[0].EndsWith(".gsxp", StringComparison.OrdinalIgnoreCase)
                ? new[] { args[0] }
                : new string[0];
            Application.Run(new MyForm(projectArgs));
        }
    }
}
