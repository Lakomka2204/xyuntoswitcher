using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using xyuntoswitcher.Properties;

namespace xyuntoswitcher
{
    public partial class Form1 : Form
    {
        readonly Process Pr = Process.GetCurrentProcess();
        bool called = false;
        bool terminating = false;
        public Form1()
        {
            InitializeComponent();
            if (Registry.CurrentUser.OpenSubKey(@"Software\xyintoswitcher") == null)
            {
                MessageBox.Show("Ctrl + Alt to perform changing langs\nF1 to see this again",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Registry.CurrentUser.CreateSubKey(@"Software\xyintoswitcher");
            }
            cb_alwaysontop.CheckedChanged += (s, e) =>
            {
                CheckBox cdf = s as CheckBox;
                TopMost = cdf.Checked;
            };
            ni_tray.DoubleClick += ShowForm;
            FormClosing += (s, e) =>
            {
                /*
                 * terminating = true;
                 * called = false;
                 * rtb_in.ReadOnly = false;
                */
                if (called & e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult rde = MessageBox.Show("Text is still translating, do you want to exit program or " +
                        "just stop translating?\nYes - exit program\nNo - stop translating", Text,
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    e.Cancel = rde == DialogResult.Cancel | rde == DialogResult.No;
                    if (rde == DialogResult.Cancel) return;
                    if ((rde == DialogResult.No) | (rde == DialogResult.Yes & cb_trayonhide.Checked))
                    {
                        terminating = true;
                        called = rtb_in.ReadOnly = false;
                    }
                }
                if (!cb_trayonhide.Checked) return;
                e.Cancel = true;
                ni_tray.Visible = true;
                Pr.PriorityClass = ProcessPriorityClass.Idle;
                Pr.PriorityBoostEnabled = false;
                Hide();
            };
            SizeChanged += (s, e) =>
            {
                rtb_in.Size = new Size(rtb_in.Size.Width, (Size.Height - 100) / 2 + 10);
                rtb_out.Size = new Size(rtb_out.Size.Width, (Size.Height - 100) / 2 + 10);
            };
            cms_opacity.Click += (s, e) =>
            {
                ChangeOpacity changeOpacity = new ChangeOpacity();
                TopMost = false;
                changeOpacity.ShowDialog();
                TopMost = true;
            };
            rtb_in.TextChanged += (s, e) => Text = rtb_in.TextLength.ToString(); // debug
        }

        protected override void OnActivated(EventArgs e)
        {
            if (cb_alwaysontop.Checked) Opacity = 1;
        }
        protected override void OnDeactivate(EventArgs e)
        {
            try
            {
                if (cb_alwaysontop.Checked)
                {
                    using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\xyintoswitcher"))
                        Opacity = rk.GetValue("Opacity") == null ? 0.5 : ((double)(int)rk.GetValue("Opacity") / 10);
                }
            }
            catch (Win32Exception)
            {
                Application.Exit();
            }
        }
        private void ShowForm(object sender, EventArgs e)
        {
            ni_tray.Visible = false;
            Pr.PriorityClass = ProcessPriorityClass.Normal;
            Pr.PriorityBoostEnabled = true;
            Show();
            Focus();
        }
        async void ChangeText()
        {
#if DEBUG
            CheckForIllegalCrossThreadCalls = false;
#endif
            await Task.Run(() =>
            {
                string s = rtb_in.Text;
                string outt = "";
                for (int i = 0; i < s.Length; i++)
                {
                    if (terminating)
                    {
                        terminating = false;
                        return;
                    }
                    try
                    {
                        outt += Resources.Rus?[Resources.Eng.IndexOf(s[i])];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        outt += Resources.Eng?[Resources.Rus.IndexOf(s[i])];
                    }
                }
                rtb_out.Text = outt;
                rtb_in.ReadOnly = called = false;
            });
        }
        private void Changed(object sender, KeyEventArgs e)
        {
            if (e.Control & e.Alt)
            {
                if (called)
                {
                    MessageBox.Show("Please wait until translating finishes",
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (rtb_in.TextLength >= 10000)
                {
                    int duration = rtb_in.TextLength / 1000;
                    DialogResult x = MessageBox.Show($"Text length is over 10000 symbols length({rtb_in.TextLength})\n" +
                        "translating text will last about a " +
                        $"{(duration > 60 ? $"{duration / 60} minute(s)" + (duration - (duration / 60) * 60 == 0 ? $" and {duration - (duration / 60) * 60} second(s)" : "") : $"{duration} second(s)")}" +
                        ", continue?"
                        , Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (x == DialogResult.No) return;
                }
                rtb_out.Text = "";
                called = rtb_in.ReadOnly = true;
                ChangeText(); // executing
            }
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("Ctrl + Alt to perform changing langs\nF1 to see this again",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
