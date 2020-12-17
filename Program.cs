using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace xyuntoswitcher
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            foreach(Process p in Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)))
            {
                if (p.Id == Process.GetCurrentProcess().Id) continue;
                p.Kill();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (s, e) =>
            {
                MessageBox.Show("Oops, something went wrong :(", Form.ActiveForm.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(123);
            };
            Application.Run(new Form1());
        }
    }
}
