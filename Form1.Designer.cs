using System.Drawing;

namespace xyuntoswitcher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb_in = new System.Windows.Forms.RichTextBox();
            this.rtb_out = new System.Windows.Forms.RichTextBox();
            this.cb_alwaysontop = new System.Windows.Forms.CheckBox();
            this.cms_opacity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeOpacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_trayonhide = new System.Windows.Forms.CheckBox();
            this.ni_tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_opacity.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_in
            // 
            this.rtb_in.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_in.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtb_in.Location = new System.Drawing.Point(0, 0);
            this.rtb_in.Name = "rtb_in";
            this.rtb_in.Size = new System.Drawing.Size(524, 100);
            this.rtb_in.TabIndex = 0;
            this.rtb_in.Text = "";
            // 
            // rtb_out
            // 
            this.rtb_out.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtb_out.Location = new System.Drawing.Point(0, 141);
            this.rtb_out.Name = "rtb_out";
            this.rtb_out.ReadOnly = true;
            this.rtb_out.Size = new System.Drawing.Size(524, 100);
            this.rtb_out.TabIndex = 1;
            this.rtb_out.Text = "";
            // 
            // cb_alwaysontop
            // 
            this.cb_alwaysontop.AutoSize = true;
            this.cb_alwaysontop.ContextMenuStrip = this.cms_opacity;
            this.cb_alwaysontop.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_alwaysontop.Location = new System.Drawing.Point(0, 100);
            this.cb_alwaysontop.Name = "cb_alwaysontop";
            this.cb_alwaysontop.Size = new System.Drawing.Size(68, 41);
            this.cb_alwaysontop.TabIndex = 2;
            this.cb_alwaysontop.Text = "TopMost";
            this.cb_alwaysontop.UseVisualStyleBackColor = true;
            // 
            // cms_opacity
            // 
            this.cms_opacity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeOpacityToolStripMenuItem});
            this.cms_opacity.Name = "cms_opacity";
            this.cms_opacity.Size = new System.Drawing.Size(150, 26);
            // 
            // changeOpacityToolStripMenuItem
            // 
            this.changeOpacityToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeOpacityToolStripMenuItem.Name = "changeOpacityToolStripMenuItem";
            this.changeOpacityToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.changeOpacityToolStripMenuItem.Text = "Change opacity";
            this.changeOpacityToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // cb_trayonhide
            // 
            this.cb_trayonhide.AutoSize = true;
            this.cb_trayonhide.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_trayonhide.Dock = System.Windows.Forms.DockStyle.Right;
            this.cb_trayonhide.Location = new System.Drawing.Point(445, 100);
            this.cb_trayonhide.Name = "cb_trayonhide";
            this.cb_trayonhide.Size = new System.Drawing.Size(79, 41);
            this.cb_trayonhide.TabIndex = 3;
            this.cb_trayonhide.Text = "Hide in tray";
            this.cb_trayonhide.UseVisualStyleBackColor = true;
            // 
            // ni_tray
            // 
            this.ni_tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ni_tray.BalloonTipText = "Click to show";
            this.ni_tray.BalloonTipTitle = "xyintoswitcher";
            this.ni_tray.Icon = global::xyuntoswitcher.Properties.Resources.xyinto;
            this.ni_tray.Text = "xyintoswitcher";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 241);
            this.Controls.Add(this.cb_trayonhide);
            this.Controls.Add(this.cb_alwaysontop);
            this.Controls.Add(this.rtb_out);
            this.Controls.Add(this.rtb_in);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(300, 160);
            this.Name = "Form1";
            this.Text = "xyintoswitcher";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Changed);
            this.cms_opacity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_in;
        private System.Windows.Forms.RichTextBox rtb_out;
        private System.Windows.Forms.CheckBox cb_alwaysontop;
        private System.Windows.Forms.CheckBox cb_trayonhide;
        private System.Windows.Forms.NotifyIcon ni_tray;
        private System.Windows.Forms.ContextMenuStrip cms_opacity;
        private System.Windows.Forms.ToolStripMenuItem changeOpacityToolStripMenuItem;
    }
}

