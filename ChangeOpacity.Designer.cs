namespace xyuntoswitcher
{
    partial class ChangeOpacity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_opacity = new System.Windows.Forms.TrackBar();
            this.bt_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sssdsddf";
            // 
            // tb_opacity
            // 
            this.tb_opacity.Location = new System.Drawing.Point(12, 25);
            this.tb_opacity.Maximum = 9;
            this.tb_opacity.Minimum = 1;
            this.tb_opacity.Name = "tb_opacity";
            this.tb_opacity.Size = new System.Drawing.Size(190, 45);
            this.tb_opacity.TabIndex = 1;
            this.tb_opacity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_opacity.Value = 5;
            // 
            // bt_confirm
            // 
            this.bt_confirm.Location = new System.Drawing.Point(69, 76);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(75, 23);
            this.bt_confirm.TabIndex = 2;
            this.bt_confirm.Text = "OK";
            this.bt_confirm.UseVisualStyleBackColor = true;
            // 
            // ChangeOpacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 107);
            this.Controls.Add(this.bt_confirm);
            this.Controls.Add(this.tb_opacity);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeOpacity";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Opacity";
            ((System.ComponentModel.ISupportInitialize)(this.tb_opacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_opacity;
        private System.Windows.Forms.Button bt_confirm;
    }
}