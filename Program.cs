using System;
using System.Windows.Forms;

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
