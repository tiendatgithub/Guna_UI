namespace Guna_UI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lnk_ConfigSQL = new System.Windows.Forms.LinkLabel();
            this.pic_Exit = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(137, 251);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.gunaLabel2.Location = new System.Drawing.Point(0, 114);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(140, 19);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Interrogation System";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(59, 77);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(66, 32);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "HTi";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl1.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl1.LineColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(226, 107);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(243, 13);
            this.hyperlinkLabelControl1.TabIndex = 3;
            this.hyperlinkLabelControl1.Text = "                                                                                 " +
    "";
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Pass.Location = new System.Drawing.Point(226, 98);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(243, 18);
            this.txt_Pass.TabIndex = 5;
            // 
            // hyperlinkLabelControl2
            // 
            this.hyperlinkLabelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.hyperlinkLabelControl2.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl2.LineColor = System.Drawing.Color.Maroon;
            this.hyperlinkLabelControl2.Location = new System.Drawing.Point(226, 55);
            this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
            this.hyperlinkLabelControl2.Size = new System.Drawing.Size(243, 13);
            this.hyperlinkLabelControl2.TabIndex = 3;
            this.hyperlinkLabelControl2.Text = "                                                                                 " +
    "";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Username.Location = new System.Drawing.Point(226, 46);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(243, 18);
            this.txt_Username.TabIndex = 5;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Login.Location = new System.Drawing.Point(230, 164);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(239, 32);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "ĐĂNG NHẬP";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // lnk_ConfigSQL
            // 
            this.lnk_ConfigSQL.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lnk_ConfigSQL.AutoSize = true;
            this.lnk_ConfigSQL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lnk_ConfigSQL.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lnk_ConfigSQL.Location = new System.Drawing.Point(280, 208);
            this.lnk_ConfigSQL.Name = "lnk_ConfigSQL";
            this.lnk_ConfigSQL.Size = new System.Drawing.Size(140, 17);
            this.lnk_ConfigSQL.TabIndex = 7;
            this.lnk_ConfigSQL.TabStop = true;
            this.lnk_ConfigSQL.Text = "Cấu hình Cơ sở dữ liệu";
            this.lnk_ConfigSQL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_ConfigSQL_LinkClicked);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guna_UI.Properties.Resources.pngwave;
            this.pictureBox1.Location = new System.Drawing.Point(9, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(570, 251);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.lnk_ConfigSQL);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.hyperlinkLabelControl2);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private System.Windows.Forms.TextBox txt_Pass;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl2;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel lnk_ConfigSQL;
        private FontAwesome.Sharp.IconPictureBox pic_Exit;
    }
}