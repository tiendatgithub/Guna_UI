namespace Guna_UI
{
    partial class frmConfigSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigSQL));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_TestConnect = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_Exit = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.hyperlinkLabelControl5 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.hyperlinkLabelControl3 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txt_ServerName = new System.Windows.Forms.TextBox();
            this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txt_NameDB = new System.Windows.Forms.TextBox();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.gunaPanel1.Controls.Add(this.iconPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(137, 327);
            this.gunaPanel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconPictureBox1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconSize = 131;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 78);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(134, 131);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // btn_TestConnect
            // 
            this.btn_TestConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_TestConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TestConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_TestConnect.FlatAppearance.BorderSize = 0;
            this.btn_TestConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_TestConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_TestConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TestConnect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_TestConnect.Location = new System.Drawing.Point(281, 270);
            this.btn_TestConnect.Name = "btn_TestConnect";
            this.btn_TestConnect.Size = new System.Drawing.Size(134, 32);
            this.btn_TestConnect.TabIndex = 6;
            this.btn_TestConnect.Text = "KIỂM TRA KẾT NỐI";
            this.btn_TestConnect.UseVisualStyleBackColor = false;
            // 
            // pic_Exit
            // 
            this.pic_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
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
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.Location = new System.Drawing.Point(429, 270);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(134, 32);
            this.btn_Save.TabIndex = 44;
            this.btn_Save.Text = "LƯU";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(225, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "CẤU HÌNH CƠ SỞ DỮ LIỆU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(149, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mật khẩu :";
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Pass.Location = new System.Drawing.Point(281, 214);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(282, 18);
            this.txt_Pass.TabIndex = 37;
            this.toolTip1.SetToolTip(this.txt_Pass, "Mật khẩu hiện tại");
            // 
            // hyperlinkLabelControl5
            // 
            this.hyperlinkLabelControl5.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl5.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl5.LineColor = System.Drawing.Color.Maroon;
            this.hyperlinkLabelControl5.Location = new System.Drawing.Point(281, 223);
            this.hyperlinkLabelControl5.Name = "hyperlinkLabelControl5";
            this.hyperlinkLabelControl5.Size = new System.Drawing.Size(282, 13);
            this.hyperlinkLabelControl5.TabIndex = 36;
            this.hyperlinkLabelControl5.Text = "                                                                                 " +
    "             ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(149, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tên người dùng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(149, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên cơ sở dữ liệu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(149, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên máy chủ SQL :";
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_User.Location = new System.Drawing.Point(281, 160);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(282, 18);
            this.txt_User.TabIndex = 32;
            this.txt_User.Text = "                                                                                 " +
    "             ";
            this.toolTip1.SetToolTip(this.txt_User, "Xác nhận mật khẩu mới");
            // 
            // hyperlinkLabelControl3
            // 
            this.hyperlinkLabelControl3.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl3.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl3.LineColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl3.Location = new System.Drawing.Point(281, 166);
            this.hyperlinkLabelControl3.Name = "hyperlinkLabelControl3";
            this.hyperlinkLabelControl3.Size = new System.Drawing.Size(282, 13);
            this.hyperlinkLabelControl3.TabIndex = 31;
            this.hyperlinkLabelControl3.Text = "                                                                                 " +
    "             ";
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_ServerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ServerName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ServerName.Location = new System.Drawing.Point(281, 53);
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Size = new System.Drawing.Size(282, 18);
            this.txt_ServerName.TabIndex = 29;
            this.toolTip1.SetToolTip(this.txt_ServerName, "Mật khẩu hiện tại");
            // 
            // hyperlinkLabelControl2
            // 
            this.hyperlinkLabelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl2.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl2.LineColor = System.Drawing.Color.Maroon;
            this.hyperlinkLabelControl2.Location = new System.Drawing.Point(281, 62);
            this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
            this.hyperlinkLabelControl2.Size = new System.Drawing.Size(282, 13);
            this.hyperlinkLabelControl2.TabIndex = 28;
            this.hyperlinkLabelControl2.Text = "                                                                                 " +
    "             ";
            // 
            // txt_NameDB
            // 
            this.txt_NameDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_NameDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NameDB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_NameDB.Location = new System.Drawing.Point(281, 105);
            this.txt_NameDB.Name = "txt_NameDB";
            this.txt_NameDB.Size = new System.Drawing.Size(282, 18);
            this.txt_NameDB.TabIndex = 30;
            this.txt_NameDB.Text = "          ";
            this.toolTip1.SetToolTip(this.txt_NameDB, "Mật khẩu mới");
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl1.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl1.LineColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(281, 114);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(282, 13);
            this.hyperlinkLabelControl1.TabIndex = 27;
            this.hyperlinkLabelControl1.Text = "                                                                                 " +
    "             ";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // frmConfigSQL
            // 
            this.AcceptButton = this.btn_TestConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(588, 327);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.hyperlinkLabelControl5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.hyperlinkLabelControl3);
            this.Controls.Add(this.txt_ServerName);
            this.Controls.Add(this.hyperlinkLabelControl2);
            this.Controls.Add(this.txt_NameDB);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.btn_TestConnect);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConfigSQL";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Button btn_TestConnect;
        private FontAwesome.Sharp.IconPictureBox pic_Exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Pass;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_User;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl3;
        private System.Windows.Forms.TextBox txt_ServerName;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl2;
        private System.Windows.Forms.TextBox txt_NameDB;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
    }
}