namespace Test
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbblDetails = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHelp = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNotification = new MetroFramework.Controls.MetroTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.refreshNotifications = new System.Windows.Forms.Timer(this.components);
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtAdmin = new MetroFramework.Controls.MetroTile();
            this.mtEmployees = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mtInventory = new MetroFramework.Controls.MetroTile();
            this.mtSettings = new MetroFramework.Controls.MetroTile();
            this.mtLogout = new MetroFramework.Controls.MetroTile();
            this.mtSuppliers = new MetroFramework.Controls.MetroTile();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSalesMade = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "User signed in:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserName.Location = new System.Drawing.Point(106, 14);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 16);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "UserName";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSalesMade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Location = new System.Drawing.Point(1435, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 153);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Location = new System.Drawing.Point(47, 76);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 16);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(1435, 62);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Welcome!";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbblDetails
            // 
            this.lbblDetails.AutoSize = true;
            this.lbblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbblDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbblDetails.Location = new System.Drawing.Point(4, 42);
            this.lbblDetails.Name = "lbblDetails";
            this.lbblDetails.Size = new System.Drawing.Size(50, 16);
            this.lbblDetails.TabIndex = 22;
            this.lbblDetails.Text = "Details";
            this.lbblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHelp);
            this.panel2.Controls.Add(this.lbblDetails);
            this.panel2.Location = new System.Drawing.Point(1435, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 178);
            this.panel2.TabIndex = 23;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHelp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblHelp.Location = new System.Drawing.Point(7, 10);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(54, 25);
            this.lblHelp.TabIndex = 24;
            this.lblHelp.Text = "Help!";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtNotification);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Location = new System.Drawing.Point(794, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 324);
            this.panel3.TabIndex = 29;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(16, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Daily Notifications:";
            this.metroLabel1.WrapToLine = true;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 260);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtNotification
            // 
            // 
            // 
            // 
            this.txtNotification.CustomButton.Image = null;
            this.txtNotification.CustomButton.Location = new System.Drawing.Point(81, 2);
            this.txtNotification.CustomButton.Name = "";
            this.txtNotification.CustomButton.Size = new System.Drawing.Size(253, 253);
            this.txtNotification.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotification.CustomButton.TabIndex = 1;
            this.txtNotification.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotification.CustomButton.UseSelectable = true;
            this.txtNotification.CustomButton.Visible = false;
            this.txtNotification.Lines = new string[0];
            this.txtNotification.Location = new System.Drawing.Point(255, 44);
            this.txtNotification.MaxLength = 32767;
            this.txtNotification.Multiline = true;
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.PasswordChar = '\0';
            this.txtNotification.ReadOnly = true;
            this.txtNotification.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotification.SelectedText = "";
            this.txtNotification.SelectionLength = 0;
            this.txtNotification.SelectionStart = 0;
            this.txtNotification.ShortcutsEnabled = true;
            this.txtNotification.Size = new System.Drawing.Size(337, 258);
            this.txtNotification.TabIndex = 3;
            this.txtNotification.UseSelectable = true;
            this.txtNotification.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotification.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(47, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 16);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "CurrentDate";
            // 
            // refreshNotifications
            // 
            this.refreshNotifications.Interval = 1000;
            this.refreshNotifications.Tick += new System.EventHandler(this.refreshNotifications_Tick);
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.Location = new System.Drawing.Point(537, 493);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(251, 195);
            this.metroTile9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile9.TabIndex = 28;
            this.metroTile9.Text = "Notifications";
            this.metroTile9.TileImage = global::Test.Properties.Resources.if_about_2639759;
            this.metroTile9.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile9.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile9.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile9.UseSelectable = true;
            this.metroTile9.UseTileImage = true;
            this.metroTile9.Click += new System.EventHandler(this.metroTile9_Click);
            this.metroTile9.MouseHover += new System.EventHandler(this.metroTile9_MouseHover);
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(537, 292);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(251, 195);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile8.TabIndex = 27;
            this.metroTile8.Text = "Messaging";
            this.metroTile8.TileImage = global::Test.Properties.Resources.if_sms_2639922;
            this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile8.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile8.UseSelectable = true;
            this.metroTile8.UseTileImage = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            this.metroTile8.MouseHover += new System.EventHandler(this.metroTile8_MouseHover);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(537, 90);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(251, 195);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile7.TabIndex = 26;
            this.metroTile7.Text = "Mailing";
            this.metroTile7.TileImage = global::Test.Properties.Resources.if_mail_24_103176;
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.UseTileImage = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            this.metroTile7.MouseHover += new System.EventHandler(this.metroTile7_MouseHover);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(1051, 818);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(251, 195);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile6.TabIndex = 25;
            this.metroTile6.Text = "Check Connection";
            this.metroTile6.TileImage = global::Test.Properties.Resources.if_radio_tower_298855;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            this.metroTile6.MouseHover += new System.EventHandler(this.metroTile6_MouseHover);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(794, 818);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(251, 195);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile5.TabIndex = 24;
            this.metroTile5.Text = "Reports";
            this.metroTile5.TileImage = global::Test.Properties.Resources.if_graph_298791;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            this.metroTile5.MouseHover += new System.EventHandler(this.metroTile5_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(295, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 121);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // mtAdmin
            // 
            this.mtAdmin.ActiveControl = null;
            this.mtAdmin.Location = new System.Drawing.Point(537, 818);
            this.mtAdmin.Name = "mtAdmin";
            this.mtAdmin.Size = new System.Drawing.Size(251, 195);
            this.mtAdmin.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtAdmin.TabIndex = 20;
            this.mtAdmin.Text = "Administrator ";
            this.mtAdmin.TileImage = global::Test.Properties.Resources.if_8_2135932;
            this.mtAdmin.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdmin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAdmin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdmin.UseSelectable = true;
            this.mtAdmin.UseTileImage = true;
            this.mtAdmin.Click += new System.EventHandler(this.mtAdmin_Click);
            this.mtAdmin.MouseHover += new System.EventHandler(this.mtAdmin_MouseHover);
            // 
            // mtEmployees
            // 
            this.mtEmployees.ActiveControl = null;
            this.mtEmployees.Location = new System.Drawing.Point(280, 493);
            this.mtEmployees.Name = "mtEmployees";
            this.mtEmployees.Size = new System.Drawing.Size(251, 195);
            this.mtEmployees.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtEmployees.TabIndex = 19;
            this.mtEmployees.Text = "Employees";
            this.mtEmployees.TileImage = global::Test.Properties.Resources.Employeesz;
            this.mtEmployees.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEmployees.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtEmployees.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtEmployees.UseSelectable = true;
            this.mtEmployees.UseTileImage = true;
            this.mtEmployees.Click += new System.EventHandler(this.mtEmployees_Click);
            this.mtEmployees.MouseHover += new System.EventHandler(this.mtEmployees_MouseHover);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(280, 292);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(251, 195);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile4.TabIndex = 18;
            this.metroTile4.Text = "Events";
            this.metroTile4.TileImage = global::Test.Properties.Resources.if_star_2639925;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            this.metroTile4.MouseHover += new System.EventHandler(this.metroTile4_MouseHover);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(280, 90);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(251, 195);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 17;
            this.metroTile3.Text = "Customers";
            this.metroTile3.TileImage = global::Test.Properties.Resources.Customer;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            this.metroTile3.MouseHover += new System.EventHandler(this.metroTile3_MouseHover);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(23, 493);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(251, 195);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 16;
            this.metroTile2.Text = "Sales";
            this.metroTile2.TileImage = global::Test.Properties.Resources.Sales;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            this.metroTile2.MouseHover += new System.EventHandler(this.metroTile2_MouseHover);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(280, 818);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(251, 195);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 15;
            this.metroTile1.Text = "Calculator";
            this.metroTile1.TileImage = global::Test.Properties.Resources.Calculator;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            this.metroTile1.MouseHover += new System.EventHandler(this.metroTile1_MouseHover);
            // 
            // mtInventory
            // 
            this.mtInventory.ActiveControl = null;
            this.mtInventory.Location = new System.Drawing.Point(23, 292);
            this.mtInventory.Name = "mtInventory";
            this.mtInventory.Size = new System.Drawing.Size(251, 195);
            this.mtInventory.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtInventory.TabIndex = 14;
            this.mtInventory.Text = "Inventory";
            this.mtInventory.TileImage = global::Test.Properties.Resources.Inventory;
            this.mtInventory.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtInventory.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtInventory.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtInventory.UseSelectable = true;
            this.mtInventory.UseTileImage = true;
            this.mtInventory.Click += new System.EventHandler(this.mtInventory_Click);
            this.mtInventory.MouseHover += new System.EventHandler(this.mtInventory_MouseHover);
            // 
            // mtSettings
            // 
            this.mtSettings.ActiveControl = null;
            this.mtSettings.Location = new System.Drawing.Point(23, 818);
            this.mtSettings.Name = "mtSettings";
            this.mtSettings.Size = new System.Drawing.Size(251, 195);
            this.mtSettings.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtSettings.TabIndex = 13;
            this.mtSettings.Text = "Settings";
            this.mtSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSettings.TileImage = global::Test.Properties.Resources.Settings;
            this.mtSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSettings.UseSelectable = true;
            this.mtSettings.UseTileImage = true;
            this.mtSettings.Click += new System.EventHandler(this.mtSettings_Click);
            this.mtSettings.MouseHover += new System.EventHandler(this.mtSettings_MouseHover);
            // 
            // mtLogout
            // 
            this.mtLogout.ActiveControl = null;
            this.mtLogout.Location = new System.Drawing.Point(1594, 818);
            this.mtLogout.Name = "mtLogout";
            this.mtLogout.Size = new System.Drawing.Size(251, 195);
            this.mtLogout.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtLogout.TabIndex = 12;
            this.mtLogout.Text = "Logout";
            this.mtLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtLogout.TileImage = global::Test.Properties.Resources.if_icons_exit2_1564506;
            this.mtLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtLogout.UseSelectable = true;
            this.mtLogout.UseTileImage = true;
            this.mtLogout.Click += new System.EventHandler(this.mtLogout_Click);
            this.mtLogout.MouseHover += new System.EventHandler(this.mtLogout_MouseHover);
            // 
            // mtSuppliers
            // 
            this.mtSuppliers.ActiveControl = null;
            this.mtSuppliers.Location = new System.Drawing.Point(23, 90);
            this.mtSuppliers.Name = "mtSuppliers";
            this.mtSuppliers.Size = new System.Drawing.Size(251, 195);
            this.mtSuppliers.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtSuppliers.TabIndex = 10;
            this.mtSuppliers.Text = "Suppliers";
            this.mtSuppliers.TileImage = global::Test.Properties.Resources.Suppliers;
            this.mtSuppliers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSuppliers.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSuppliers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSuppliers.UseSelectable = true;
            this.mtSuppliers.UseTileImage = true;
            this.mtSuppliers.Click += new System.EventHandler(this.mtSuppliers_Click);
            this.mtSuppliers.MouseHover += new System.EventHandler(this.mtSuppliers_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sales Made:";
            // 
            // lblSalesMade
            // 
            this.lblSalesMade.AutoSize = true;
            this.lblSalesMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesMade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalesMade.Location = new System.Drawing.Point(93, 119);
            this.lblSalesMade.Name = "lblSalesMade";
            this.lblSalesMade.Size = new System.Drawing.Size(42, 16);
            this.lblSalesMade.TabIndex = 11;
            this.lblSalesMade.Text = "Time:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.metroTile9);
            this.Controls.Add(this.metroTile8);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtAdmin);
            this.Controls.Add(this.mtEmployees);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mtInventory);
            this.Controls.Add(this.mtSettings);
            this.Controls.Add(this.mtLogout);
            this.Controls.Add(this.mtSuppliers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseHover += new System.EventHandler(this.MainMenu_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private MetroFramework.Controls.MetroTile mtSuppliers;
        private MetroFramework.Controls.MetroTile mtLogout;
        private MetroFramework.Controls.MetroTile mtSettings;
        private MetroFramework.Controls.MetroTile mtInventory;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile mtEmployees;
        private MetroFramework.Controls.MetroTile mtAdmin;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbblDetails;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel lblHelp;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile9;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNotification;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer refreshNotifications;
        private System.Windows.Forms.Label lblSalesMade;
        private System.Windows.Forms.Label label4;
    }
}