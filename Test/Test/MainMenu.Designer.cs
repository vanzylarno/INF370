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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAdminFeatures = new MetroFramework.Controls.MetroButton();
            this.mtSettings = new MetroFramework.Controls.MetroTile();
            this.mtLogout = new MetroFramework.Controls.MetroTile();
            this.mtSuppliers = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(171, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "User signed in:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserName.Location = new System.Drawing.Point(274, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 16);
            this.lblUserName.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(147, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(18, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "|";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.Location = new System.Drawing.Point(366, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(18, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "|";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnAdminFeatures
            // 
            this.btnAdminFeatures.Location = new System.Drawing.Point(401, 22);
            this.btnAdminFeatures.Name = "btnAdminFeatures";
            this.btnAdminFeatures.Size = new System.Drawing.Size(231, 23);
            this.btnAdminFeatures.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAdminFeatures.TabIndex = 9;
            this.btnAdminFeatures.Text = "Admin Features";
            this.btnAdminFeatures.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdminFeatures.UseSelectable = true;
            this.btnAdminFeatures.Click += new System.EventHandler(this.btnAdminFeatures_Click);
            // 
            // mtSettings
            // 
            this.mtSettings.ActiveControl = null;
            this.mtSettings.Location = new System.Drawing.Point(1097, 292);
            this.mtSettings.Name = "mtSettings";
            this.mtSettings.Size = new System.Drawing.Size(251, 202);
            this.mtSettings.TabIndex = 13;
            this.mtSettings.Text = "Settings";
            this.mtSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSettings.TileImage = global::Test.Properties.Resources.if_settings_115801;
            this.mtSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSettings.UseSelectable = true;
            this.mtSettings.UseTileImage = true;
            this.mtSettings.Click += new System.EventHandler(this.mtSettings_Click);
            // 
            // mtLogout
            // 
            this.mtLogout.ActiveControl = null;
            this.mtLogout.Location = new System.Drawing.Point(1097, 500);
            this.mtLogout.Name = "mtLogout";
            this.mtLogout.Size = new System.Drawing.Size(251, 174);
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
            // 
            // mtSuppliers
            // 
            this.mtSuppliers.ActiveControl = null;
            this.mtSuppliers.Location = new System.Drawing.Point(23, 90);
            this.mtSuppliers.Name = "mtSuppliers";
            this.mtSuppliers.Size = new System.Drawing.Size(251, 195);
            this.mtSuppliers.TabIndex = 10;
            this.mtSuppliers.Text = "Suppliers";
            this.mtSuppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSuppliers.TileImage = global::Test.Properties.Resources.if_truck_115775;
            this.mtSuppliers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSuppliers.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSuppliers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSuppliers.UseSelectable = true;
            this.mtSuppliers.UseTileImage = true;
            this.mtSuppliers.Click += new System.EventHandler(this.mtSuppliers_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 685);
            this.Controls.Add(this.mtSettings);
            this.Controls.Add(this.mtLogout);
            this.Controls.Add(this.mtSuppliers);
            this.Controls.Add(this.btnAdminFeatures);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Main Menu";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAdminFeatures;
        private MetroFramework.Controls.MetroTile mtSuppliers;
        private MetroFramework.Controls.MetroTile mtLogout;
        private MetroFramework.Controls.MetroTile mtSettings;
    }
}