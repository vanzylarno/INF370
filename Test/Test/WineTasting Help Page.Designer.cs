namespace Test
{
    partial class WineTasting_Help_Page
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
            this.FindSupplier = new MetroFramework.Controls.MetroTile();
            this.UpdateSupplier = new MetroFramework.Controls.MetroTile();
            this.DeleteSupplier = new MetroFramework.Controls.MetroTile();
            this.AddSupplier = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // FindSupplier
            // 
            this.FindSupplier.ActiveControl = null;
            this.FindSupplier.Location = new System.Drawing.Point(265, 273);
            this.FindSupplier.Name = "FindSupplier";
            this.FindSupplier.Size = new System.Drawing.Size(236, 204);
            this.FindSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.FindSupplier.TabIndex = 15;
            this.FindSupplier.Text = "Find a Customer";
            this.FindSupplier.TileImage = global::Test.Properties.Resources.Search;
            this.FindSupplier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FindSupplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.FindSupplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.FindSupplier.UseSelectable = true;
            this.FindSupplier.UseTileImage = true;
            this.FindSupplier.Click += new System.EventHandler(this.FindSupplier_Click);
            // 
            // UpdateSupplier
            // 
            this.UpdateSupplier.ActiveControl = null;
            this.UpdateSupplier.Location = new System.Drawing.Point(23, 273);
            this.UpdateSupplier.Name = "UpdateSupplier";
            this.UpdateSupplier.Size = new System.Drawing.Size(236, 204);
            this.UpdateSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.UpdateSupplier.TabIndex = 14;
            this.UpdateSupplier.Text = "Update a Customer";
            this.UpdateSupplier.TileImage = global::Test.Properties.Resources.Update;
            this.UpdateSupplier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateSupplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UpdateSupplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.UpdateSupplier.UseSelectable = true;
            this.UpdateSupplier.UseTileImage = true;
            this.UpdateSupplier.Click += new System.EventHandler(this.UpdateSupplier_Click);
            // 
            // DeleteSupplier
            // 
            this.DeleteSupplier.ActiveControl = null;
            this.DeleteSupplier.Location = new System.Drawing.Point(265, 63);
            this.DeleteSupplier.Name = "DeleteSupplier";
            this.DeleteSupplier.Size = new System.Drawing.Size(236, 204);
            this.DeleteSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.DeleteSupplier.TabIndex = 13;
            this.DeleteSupplier.Text = "Delete a Customer";
            this.DeleteSupplier.TileImage = global::Test.Properties.Resources.Delete;
            this.DeleteSupplier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteSupplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.DeleteSupplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.DeleteSupplier.UseSelectable = true;
            this.DeleteSupplier.UseTileImage = true;
            this.DeleteSupplier.Click += new System.EventHandler(this.DeleteSupplier_Click);
            // 
            // AddSupplier
            // 
            this.AddSupplier.ActiveControl = null;
            this.AddSupplier.Location = new System.Drawing.Point(23, 63);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(236, 204);
            this.AddSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.AddSupplier.TabIndex = 12;
            this.AddSupplier.Text = "Add a New Customer";
            this.AddSupplier.TileImage = global::Test.Properties.Resources.Add;
            this.AddSupplier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddSupplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AddSupplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddSupplier.UseSelectable = true;
            this.AddSupplier.UseTileImage = true;
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // WineTasting_Help_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 491);
            this.Controls.Add(this.FindSupplier);
            this.Controls.Add(this.UpdateSupplier);
            this.Controls.Add(this.DeleteSupplier);
            this.Controls.Add(this.AddSupplier);
            this.Name = "WineTasting_Help_Page";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Maybe these will help";
            this.Load += new System.EventHandler(this.WineTasting_Help_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile FindSupplier;
        private MetroFramework.Controls.MetroTile UpdateSupplier;
        private MetroFramework.Controls.MetroTile DeleteSupplier;
        private MetroFramework.Controls.MetroTile AddSupplier;
    }
}