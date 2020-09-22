using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xyuntoswitcher
{
    public partial class ChangeOpacity : Form
    {
        public ChangeOpacity()
        {
            InitializeComponent();
            TopMost = true;
            using (RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\xyintoswitcher"))
            {
                object sdd = rk.GetValue("Opacity");
                tb_opacity.Value = sdd == null ? 5 : (int)sdd;
            }
            Parallel.Invoke(
                () =>
                {
                    tb_opacity.Scroll += (s, e) =>
                    {
                        label1.Text = $"x {(double)tb_opacity.Value / 10}";
                    };
                },
                () =>
                {
                    bt_confirm.Click += (s, e) =>
                    {
                        using (RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"Software\xyintoswitcher", true))
                            rk.SetValue("Opacity", tb_opacity.Value);
                        DialogResult = DialogResult.OK;
                        Close();
                    };
                },
                () =>
                {
                    label1.Text = $"x {(double)tb_opacity.Value / 10}";
                }
                );
        }
    }
}
