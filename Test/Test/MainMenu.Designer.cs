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
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mtInventory = new MetroFramework.Controls.MetroTile();
            this.mtSettings = new MetroFramework.Controls.MetroTile();
            this.mtLogout = new MetroFramework.Controls.MetroTile();
            this.mtSuppliers = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnAdminFeatures
            // 
            this.btnAdminFeatures.Location = new System.Drawing.Point(401, 22);
            this.btnAdminFeatures.Name = "btnAdminFeatures";
            this.btnAdminFeatures.Size = new System.Drawing.Size(231, 23);
            this.btnAdminFeatures.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAdminFeatures.TabIndex = 9;
            this.btnAdminFeatures.Text = "Admin Features";
            this.btnAdminFeatures.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdminFeatures.UseSelectable = true;
            this.btnAdminFeatures.Click += new System.EventHandler(this.btnAdminFeatures_Click);
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
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(1097, 91);
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
            // 
            // mtSettings
            // 
            this.mtSettings.ActiveControl = null;
            this.mtSettings.Location = new System.Drawing.Point(1097, 292);
            this.mtSettings.Name = "mtSettings";
            this.mtSettings.Size = new System.Drawing.Size(251, 202);
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
            // 
            // mtLogout
            // 
            this.mtLogout.ActiveControl = null;
            this.mtLogout.Location = new System.Drawing.Point(1097, 500);
            this.mtLogout.Name = "mtLogout";
            this.mtLogout.Size = new System.Drawing.Size(251, 174);
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
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 711);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mtInventory);
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
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Main Menu";
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
        private MetroFramework.Controls.MetroTile mtInventory;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}