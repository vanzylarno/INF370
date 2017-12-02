namespace Test
{
    partial class Vineyard_Tours_Form
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.FindSupplier = new MetroFramework.Controls.MetroTile();
            this.UpdateSupplier = new MetroFramework.Controls.MetroTile();
            this.DeleteSupplier = new MetroFramework.Controls.MetroTile();
            this.AddSupplier = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(496, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(236, 414);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 21;
            this.metroTile1.Text = "Show Booked Events";
            this.metroTile1.TileImage = global::Test.Properties.Resources.Booked;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // FindSupplier
            // 
            this.FindSupplier.ActiveControl = null;
            this.FindSupplier.Location = new System.Drawing.Point(254, 273);
            this.FindSupplier.Name = "FindSupplier";
            this.FindSupplier.Size = new System.Drawing.Size(236, 204);
            this.FindSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.FindSupplier.TabIndex = 20;
            this.FindSupplier.Text = "Find a Vineyard Tour";
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
            this.UpdateSupplier.Location = new System.Drawing.Point(12, 273);
            this.UpdateSupplier.Name = "UpdateSupplier";
            this.UpdateSupplier.Size = new System.Drawing.Size(236, 204);
            this.UpdateSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.UpdateSupplier.TabIndex = 19;
            this.UpdateSupplier.Text = "Update a Vineyard Tour";
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
            this.DeleteSupplier.Location = new System.Drawing.Point(254, 63);
            this.DeleteSupplier.Name = "DeleteSupplier";
            this.DeleteSupplier.Size = new System.Drawing.Size(236, 204);
            this.DeleteSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.DeleteSupplier.TabIndex = 18;
            this.DeleteSupplier.Text = "Delete a Vineyard Tour";
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
            this.AddSupplier.Location = new System.Drawing.Point(12, 63);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(236, 204);
            this.AddSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.AddSupplier.TabIndex = 17;
            this.AddSupplier.Text = "Add a Vineyard Tour";
            this.AddSupplier.TileImage = global::Test.Properties.Resources.Add;
            this.AddSupplier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddSupplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AddSupplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddSupplier.UseSelectable = true;
            this.AddSupplier.UseTileImage = true;
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // Vineyard_Tours_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 494);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.FindSupplier);
            this.Controls.Add(this.UpdateSupplier);
            this.Controls.Add(this.DeleteSupplier);
            this.Controls.Add(this.AddSupplier);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(745, 494);
            this.Name = "Vineyard_Tours_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Vineyard Tours";
            this.Load += new System.EventHandler(this.Vineyard_Tours_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile FindSupplier;
        private MetroFramework.Controls.MetroTile UpdateSupplier;
        private MetroFramework.Controls.MetroTile DeleteSupplier;
        private MetroFramework.Controls.MetroTile AddSupplier;
    }
}