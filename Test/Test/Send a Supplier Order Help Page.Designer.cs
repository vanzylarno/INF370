namespace Test
{
    partial class Send_a_Supplier_Order_Help_Page
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
            this.AddSupplier = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(265, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(236, 204);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Add a New Order Product";
            this.metroTile1.TileImage = global::Test.Properties.Resources.Add_Product;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // AddSupplier
            // 
            this.AddSupplier.ActiveControl = null;
            this.AddSupplier.Location = new System.Drawing.Point(23, 63);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(236, 204);
            this.AddSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.AddSupplier.TabIndex = 5;
            this.AddSupplier.Text = "Add Supplier";
            this.AddSupplier.TileImage = global::Test.Properties.Resources.Add;
            this.AddSupplier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddSupplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AddSupplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddSupplier.UseSelectable = true;
            this.AddSupplier.UseTileImage = true;
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // Send_a_Supplier_Order_Help_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 281);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.AddSupplier);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(524, 281);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(524, 281);
            this.Name = "Send_a_Supplier_Order_Help_Page";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Maybe these Options will Help";
            this.Load += new System.EventHandler(this.Send_a_Supplier_Order_Help_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile AddSupplier;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}