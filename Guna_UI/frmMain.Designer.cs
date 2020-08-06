namespace Guna_UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Panel_Function = new Guna.UI.WinForms.GunaPanel();
            this.lb_CPU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cir_CPU = new CircularProgressBar.CircularProgressBar();
            this.datetime_calendar = new Guna.UI.WinForms.GunaDateTimePicker();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Panel_Title = new Guna.UI.WinForms.GunaPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.pic_Exit = new FontAwesome.Sharp.IconPictureBox();
            this.pic_Minimize = new FontAwesome.Sharp.IconPictureBox();
            this.btn_InfoUser = new DevExpress.XtraEditors.SimpleButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btn_Taophien = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Main = new System.Windows.Forms.Panel();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.timer_Main = new System.Windows.Forms.Timer(this.components);
            this.cir_HD = new CircularProgressBar.CircularProgressBar();
            this.lb_HD = new System.Windows.Forms.Label();
            this.HD = new System.Diagnostics.PerformanceCounter();
            this.label = new System.Windows.Forms.Label();
            this.Panel_Function.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Title.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HD)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Function
            // 
            this.Panel_Function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.Panel_Function.Controls.Add(this.label);
            this.Panel_Function.Controls.Add(this.lb_HD);
            this.Panel_Function.Controls.Add(this.lb_CPU);
            this.Panel_Function.Controls.Add(this.label1);
            this.Panel_Function.Controls.Add(this.cir_HD);
            this.Panel_Function.Controls.Add(this.cir_CPU);
            this.Panel_Function.Controls.Add(this.datetime_calendar);
            this.Panel_Function.Controls.Add(this.iconButton3);
            this.Panel_Function.Controls.Add(this.iconButton2);
            this.Panel_Function.Controls.Add(this.iconButton1);
            this.Panel_Function.Controls.Add(this.gunaPanel1);
            this.Panel_Function.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Function.Location = new System.Drawing.Point(0, 0);
            this.Panel_Function.Name = "Panel_Function";
            this.Panel_Function.Size = new System.Drawing.Size(131, 729);
            this.Panel_Function.TabIndex = 0;
            // 
            // lb_CPU
            // 
            this.lb_CPU.AutoSize = true;
            this.lb_CPU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CPU.Location = new System.Drawing.Point(12, 597);
            this.lb_CPU.Name = "lb_CPU";
            this.lb_CPU.Size = new System.Drawing.Size(35, 15);
            this.lb_CPU.TabIndex = 9;
            this.lb_CPU.Text = "100%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPU";
            // 
            // cir_CPU
            // 
            this.cir_CPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cir_CPU.AnimationSpeed = 500;
            this.cir_CPU.BackColor = System.Drawing.Color.Transparent;
            this.cir_CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cir_CPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cir_CPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cir_CPU.InnerMargin = 2;
            this.cir_CPU.InnerWidth = -1;
            this.cir_CPU.Location = new System.Drawing.Point(2, 545);
            this.cir_CPU.MarqueeAnimationSpeed = 2000;
            this.cir_CPU.Name = "cir_CPU";
            this.cir_CPU.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.cir_CPU.OuterMargin = -25;
            this.cir_CPU.OuterWidth = 26;
            this.cir_CPU.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.cir_CPU.ProgressWidth = 25;
            this.cir_CPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cir_CPU.Size = new System.Drawing.Size(52, 49);
            this.cir_CPU.StartAngle = 270;
            this.cir_CPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cir_CPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cir_CPU.SubscriptText = ".23";
            this.cir_CPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cir_CPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cir_CPU.SuperscriptText = "°C";
            this.cir_CPU.TabIndex = 6;
            this.cir_CPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cir_CPU.Value = 68;
            // 
            // datetime_calendar
            // 
            this.datetime_calendar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.datetime_calendar.BorderColor = System.Drawing.Color.Silver;
            this.datetime_calendar.BorderSize = 0;
            this.datetime_calendar.CustomFormat = null;
            this.datetime_calendar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datetime_calendar.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datetime_calendar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datetime_calendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime_calendar.ForeColor = System.Drawing.Color.White;
            this.datetime_calendar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetime_calendar.Location = new System.Drawing.Point(0, 695);
            this.datetime_calendar.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_calendar.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_calendar.Name = "datetime_calendar";
            this.datetime_calendar.OnHoverBaseColor = System.Drawing.Color.White;
            this.datetime_calendar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datetime_calendar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datetime_calendar.OnPressedColor = System.Drawing.Color.Black;
            this.datetime_calendar.Size = new System.Drawing.Size(131, 34);
            this.datetime_calendar.TabIndex = 5;
            this.datetime_calendar.Text = "8:38:08 SA";
            this.datetime_calendar.Value = new System.DateTime(2020, 8, 5, 8, 38, 8, 538);
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButton3.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton3.IconSize = 40;
            this.iconButton3.Location = new System.Drawing.Point(0, 288);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(131, 69);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Cấu hình";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.iconButton2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(0, 180);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(131, 67);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Phòng thẩm vấn";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(2, 73);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(129, 67);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Phiên thẩm vấn";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(131, 46);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaLabel2.Location = new System.Drawing.Point(3, 28);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(119, 15);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Interrogation System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guna_UI.Properties.Resources.pngwave;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(40, 4);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(50, 24);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "HTi";
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.Panel_Title.Controls.Add(this.panel1);
            this.Panel_Title.Controls.Add(this.iconButton5);
            this.Panel_Title.Controls.Add(this.btn_Taophien);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(131, 0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(1219, 46);
            this.Panel_Title.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.panel1.Controls.Add(this.pic_Exit);
            this.panel1.Controls.Add(this.pic_Minimize);
            this.panel1.Controls.Add(this.btn_InfoUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1002, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 46);
            this.panel1.TabIndex = 20;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::Guna_UI.Properties.Resources.me;
            this.gunaCirclePictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.InitialImage")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(3, 7);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(38, 36);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 14;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // pic_Exit
            // 
            this.pic_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.pic_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pic_Exit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.pic_Exit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.pic_Exit.IconSize = 17;
            this.pic_Exit.Location = new System.Drawing.Point(193, 1);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(17, 17);
            this.pic_Exit.TabIndex = 9;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // pic_Minimize
            // 
            this.pic_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.pic_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Minimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pic_Minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.pic_Minimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.pic_Minimize.IconSize = 17;
            this.pic_Minimize.Location = new System.Drawing.Point(170, 2);
            this.pic_Minimize.Name = "pic_Minimize";
            this.pic_Minimize.Size = new System.Drawing.Size(17, 17);
            this.pic_Minimize.TabIndex = 9;
            this.pic_Minimize.TabStop = false;
            // 
            // btn_InfoUser
            // 
            this.btn_InfoUser.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.btn_InfoUser.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btn_InfoUser.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InfoUser.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_InfoUser.Appearance.Options.UseBackColor = true;
            this.btn_InfoUser.Appearance.Options.UseBorderColor = true;
            this.btn_InfoUser.Appearance.Options.UseFont = true;
            this.btn_InfoUser.Appearance.Options.UseForeColor = true;
            this.btn_InfoUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InfoUser.ImageOptions.Image")));
            this.btn_InfoUser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_InfoUser.Location = new System.Drawing.Point(44, 17);
            this.btn_InfoUser.Margin = new System.Windows.Forms.Padding(0);
            this.btn_InfoUser.Name = "btn_InfoUser";
            this.btn_InfoUser.Size = new System.Drawing.Size(166, 25);
            this.btn_InfoUser.TabIndex = 16;
            this.btn_InfoUser.Text = "Phạm Tiến Đạt";
            this.btn_InfoUser.ToolTip = "Đổi mật khẩu";
            this.btn_InfoUser.Click += new System.EventHandler(this.btn_InfoUser_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton5.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton5.IconSize = 16;
            this.iconButton5.Location = new System.Drawing.Point(18, 13);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(22, 22);
            this.iconButton5.TabIndex = 19;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // btn_Taophien
            // 
            this.btn_Taophien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Taophien.FlatAppearance.BorderSize = 0;
            this.btn_Taophien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Taophien.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Taophien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Taophien.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Taophien.IconColor = System.Drawing.Color.White;
            this.btn_Taophien.IconSize = 10;
            this.btn_Taophien.Location = new System.Drawing.Point(0, 0);
            this.btn_Taophien.Name = "btn_Taophien";
            this.btn_Taophien.Rotation = 0D;
            this.btn_Taophien.Size = new System.Drawing.Size(190, 46);
            this.btn_Taophien.TabIndex = 18;
            this.btn_Taophien.Text = "Tạo phiên thẩm vấn";
            this.btn_Taophien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Taophien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Taophien.UseVisualStyleBackColor = true;
            this.btn_Taophien.Click += new System.EventHandler(this.btn_Taophien_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Location = new System.Drawing.Point(131, 46);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1017, 620);
            this.panel_Main.TabIndex = 2;
            this.panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_Paint);
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // timer_Main
            // 
            this.timer_Main.Tick += new System.EventHandler(this.timer_Main_Tick);
            // 
            // cir_HD
            // 
            this.cir_HD.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cir_HD.AnimationSpeed = 500;
            this.cir_HD.BackColor = System.Drawing.Color.Transparent;
            this.cir_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cir_HD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cir_HD.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cir_HD.InnerMargin = 2;
            this.cir_HD.InnerWidth = -1;
            this.cir_HD.Location = new System.Drawing.Point(70, 545);
            this.cir_HD.MarqueeAnimationSpeed = 2000;
            this.cir_HD.Name = "cir_HD";
            this.cir_HD.OuterColor = System.Drawing.Color.IndianRed;
            this.cir_HD.OuterMargin = -25;
            this.cir_HD.OuterWidth = 26;
            this.cir_HD.ProgressColor = System.Drawing.Color.WhiteSmoke;
            this.cir_HD.ProgressWidth = 25;
            this.cir_HD.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cir_HD.Size = new System.Drawing.Size(52, 49);
            this.cir_HD.StartAngle = 270;
            this.cir_HD.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cir_HD.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cir_HD.SubscriptText = ".23";
            this.cir_HD.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cir_HD.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cir_HD.SuperscriptText = "°C";
            this.cir_HD.TabIndex = 6;
            this.cir_HD.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cir_HD.Value = 68;
            // 
            // lb_HD
            // 
            this.lb_HD.AutoSize = true;
            this.lb_HD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HD.Location = new System.Drawing.Point(80, 597);
            this.lb_HD.Name = "lb_HD";
            this.lb_HD.Size = new System.Drawing.Size(35, 15);
            this.lb_HD.TabIndex = 9;
            this.lb_HD.Text = "100%";
            // 
            // HD
            // 
            this.HD.CategoryName = "LogicalDisk";
            this.HD.CounterName = "% Free Space";
            this.HD.InstanceName = "_Total";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(59, 614);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 15);
            this.label.TabIndex = 11;
            this.label.Text = "Storage used";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.Panel_Function);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý phiên thẩm vấn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Panel_Function.ResumeLayout(false);
            this.Panel_Function.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Title.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel Panel_Function;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI.WinForms.GunaDateTimePicker datetime_calendar;
        private Guna.UI.WinForms.GunaPanel Panel_Title;
        private FontAwesome.Sharp.IconPictureBox pic_Minimize;
        private FontAwesome.Sharp.IconPictureBox pic_Exit;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_InfoUser;
        private FontAwesome.Sharp.IconButton btn_Taophien;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar cir_CPU;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Windows.Forms.Timer timer_Main;
        private System.Windows.Forms.Label lb_CPU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_HD;
        private CircularProgressBar.CircularProgressBar cir_HD;
        private System.Diagnostics.PerformanceCounter HD;
        private System.Windows.Forms.Label label;
    }
}

