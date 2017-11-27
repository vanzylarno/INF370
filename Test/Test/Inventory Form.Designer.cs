namespace Test
{
    partial class Inventory_Form
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
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(249, 268);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(219, 198);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Update a Product";
            this.metroTile2.TileImage = global::Test.Properties.Resources.Update;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(24, 268);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(219, 198);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Find a Product";
            this.metroTile1.TileImage = global::Test.Properties.Resources.Search;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mtDelete
            // 
            this.mtDelete.ActiveControl = null;
            this.mtDelete.Location = new System.Drawing.Point(249, 64);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(219, 198);
            this.mtDelete.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtDelete.TabIndex = 1;
            this.mtDelete.Text = "Delete a Product";
            this.mtDelete.TileImage = global::Test.Properties.Resources.Delete;
            this.mtDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtDelete.UseSelectable = true;
            this.mtDelete.UseTileImage = true;
            this.mtDelete.Click += new System.EventHandler(this.mtDelete_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.ActiveControl = null;
            this.mtAdd.Location = new System.Drawing.Point(24, 64);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(219, 198);
            this.mtAdd.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtAdd.TabIndex = 0;
            this.mtAdd.Text = "Add a Product";
            this.mtAdd.TileImage = global::Test.Properties.Resources.Add_Product;
            this.mtAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtAdd.UseSelectable = true;
            this.mtAdd.UseTileImage = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // Inventory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 484);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtAdd);
            this.MaximizeBox = false;
            this.Name = "Inventory_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}