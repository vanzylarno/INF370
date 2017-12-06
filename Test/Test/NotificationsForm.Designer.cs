namespace Test
{
    partial class NotificationsForm
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
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(280, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(251, 396);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 20;
            this.metroTile2.Text = "Create New Notification";
            this.metroTile2.TileImage = global::Test.Properties.Resources.Add_Product;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 264);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(251, 195);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 19;
            this.metroTile1.Text = "Update a Notidication";
            this.metroTile1.TileImage = global::Test.Properties.Resources.Update;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(23, 63);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(251, 195);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 18;
            this.metroTile3.Text = "Delete a Notification";
            this.metroTile3.TileImage = global::Test.Properties.Resources.Delete;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 476);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(554, 476);
            this.Name = "NotificationsForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.NotificationsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}