namespace Guna_UI
{
    partial class frmChangePass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txt_CurrentPass = new System.Windows.Forms.TextBox();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.hyperlinkLabelControl3 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_Exit = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.gunaPanel1.Controls.Add(this.iconPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(137, 265);
            this.gunaPanel1.TabIndex = 0;
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl1.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl1.LineColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(226, 108);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(243, 13);
            this.hyperlinkLabelControl1.TabIndex = 3;
            this.hyperlinkLabelControl1.Text = "                                                                                 " +
    "";
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_NewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NewPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_NewPass.Location = new System.Drawing.Point(226, 99);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Size = new System.Drawing.Size(243, 18);
            this.txt_NewPass.TabIndex = 5;
            this.txt_NewPass.Text = "Mật khẩu mới";
            this.toolTip1.SetToolTip(this.txt_NewPass, "Mật khẩu mới");
            // 
            // hyperlinkLabelControl2
            // 
            this.hyperlinkLabelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl2.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl2.LineColor = System.Drawing.Color.Maroon;
            this.hyperlinkLabelControl2.Location = new System.Drawing.Point(226, 56);
            this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
            this.hyperlinkLabelControl2.Size = new System.Drawing.Size(243, 13);
            this.hyperlinkLabelControl2.TabIndex = 3;
            this.hyperlinkLabelControl2.Text = "                                                                                 " +
    "";
            // 
            // txt_CurrentPass
            // 
            this.txt_CurrentPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_CurrentPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CurrentPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_CurrentPass.Location = new System.Drawing.Point(226, 47);
            this.txt_CurrentPass.Name = "txt_CurrentPass";
            this.txt_CurrentPass.Size = new System.Drawing.Size(243, 18);
            this.txt_CurrentPass.TabIndex = 5;
            this.txt_CurrentPass.Text = "Mật khẩu hiện tại";
            this.toolTip1.SetToolTip(this.txt_CurrentPass, "Mật khẩu hiện tại");
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_ChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_ChangePass.FlatAppearance.BorderSize = 0;
            this.btn_ChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_ChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChangePass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ChangePass.Location = new System.Drawing.Point(226, 214);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(243, 32);
            this.btn_ChangePass.TabIndex = 6;
            this.btn_ChangePass.Text = "ĐỔI MẬT KHẨU";
            this.btn_ChangePass.UseVisualStyleBackColor = false;
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_ConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ConfirmPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_ConfirmPass.Location = new System.Drawing.Point(226, 154);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(243, 18);
            this.txt_ConfirmPass.TabIndex = 10;
            this.txt_ConfirmPass.Text = "Xác nhận mật khẩu mới";
            this.toolTip1.SetToolTip(this.txt_ConfirmPass, "Xác nhận mật khẩu mới");
            // 
            // hyperlinkLabelControl3
            // 
            this.hyperlinkLabelControl3.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl3.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl3.LineColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl3.Location = new System.Drawing.Point(226, 160);
            this.hyperlinkLabelControl3.Name = "hyperlinkLabelControl3";
            this.hyperlinkLabelControl3.Size = new System.Drawing.Size(243, 13);
            this.hyperlinkLabelControl3.TabIndex = 9;
            this.hyperlinkLabelControl3.Text = "                                                                                 " +
    "";
            // 
            // pic_Exit
            // 
            this.pic_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.pic_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pic_Exit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.pic_Exit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.pic_Exit.IconSize = 17;
            this.pic_Exit.Location = new System.Drawing.Point(548, 3);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(17, 17);
            this.pic_Exit.TabIndex = 8;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconSize = 131;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 56);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(134, 131);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmChangePass
            // 
            this.AcceptButton = this.btn_ChangePass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(570, 265);
            this.Controls.Add(this.txt_ConfirmPass);
            this.Controls.Add(this.hyperlinkLabelControl3);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.btn_ChangePass);
            this.Controls.Add(this.txt_CurrentPass);
            this.Controls.Add(this.hyperlinkLabelControl2);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChangePass";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private System.Windows.Forms.TextBox txt_NewPass;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl2;
        private System.Windows.Forms.TextBox txt_CurrentPass;
        private System.Windows.Forms.Button btn_ChangePass;
        private FontAwesome.Sharp.IconPictureBox pic_Exit;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl3;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}