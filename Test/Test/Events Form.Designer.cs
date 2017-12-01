namespace Test
{
    partial class Events_Form
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
            this.metroTile1.Size = new System.Drawing.Size(236, 308);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "Vineyard Tours";
            this.metroTile1.TileImage = global::Test.Properties.Resources.Tour;
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
            this.AddSupplier.Size = new System.Drawing.Size(236, 308);
            this.AddSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.AddSupplier.TabIndex = 12;
            this.AddSupplier.Text = "Wine Tasting";
            this.AddSupplier.TileImage = global::Test.Properties.Resources.Wine;
            this.AddSupplier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddSupplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AddSupplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddSupplier.UseSelectable = true;
            this.AddSupplier.UseTileImage = true;
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // Events_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 387);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.AddSupplier);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(534, 387);
            this.Name = "Events_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile AddSupplier;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}