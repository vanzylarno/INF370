namespace Test
{
    partial class Suppliers_Form
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
            this.ReceiveOrder = new MetroFramework.Controls.MetroTile();
            this.SendOrder = new MetroFramework.Controls.MetroTile();
            this.FindSupplier = new MetroFramework.Controls.MetroTile();
            this.UpdateSupplier = new MetroFramework.Controls.MetroTile();
            this.DeleteSupplier = new MetroFramework.Controls.MetroTile();
            this.AddSupplier = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ReceiveOrder
            // 
            this.ReceiveOrder.ActiveControl = null;
            this.ReceiveOrder.Location = new System.Drawing.Point(507, 285);
            this.ReceiveOrder.Name = "ReceiveOrder";
            this.ReceiveOrder.Size = new System.Drawing.Size(236, 204);
            this.ReceiveOrder.Style = MetroFramework.MetroColorStyle.Orange;
            this.ReceiveOrder.TabIndex = 9;
            this.ReceiveOrder.Text = "Receive a Supplier Order";
            this.ReceiveOrder.TileImage = global::Test.Properties.Resources.Receive_Order;
            this.ReceiveOrder.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReceiveOrder.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ReceiveOrder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ReceiveOrder.UseSelectable = true;
            this.ReceiveOrder.UseTileImage = true;
            this.ReceiveOrder.Click += new System.EventHandler(this.ReceiveOrder_Click);
            // 
            // SendOrder
            // 
            this.SendOrder.ActiveControl = null;
            this.SendOrder.Location = new System.Drawing.Point(507, 75);
            this.SendOrder.Name = "SendOrder";
            this.SendOrder.Size = new System.Drawing.Size(236, 204);
            this.SendOrder.Style = MetroFramework.MetroColorStyle.Orange;
            this.SendOrder.TabIndex = 8;
            this.SendOrder.Text = "Send New Supplier Order";
            this.SendOrder.TileImage = global::Test.Properties.Resources.Email;
            this.SendOrder.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendOrder.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SendOrder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.SendOrder.UseSelectable = true;
            this.SendOrder.UseTileImage = true;
            this.SendOrder.Click += new System.EventHandler(this.SendOrder_Click);
            // 
            // FindSupplier
            // 
            this.FindSupplier.ActiveControl = null;
            this.FindSupplier.Location = new System.Drawing.Point(265, 285);
            this.FindSupplier.Name = "FindSupplier";
            this.FindSupplier.Size = new System.Drawing.Size(236, 204);
            this.FindSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.FindSupplier.TabIndex = 7;
            this.FindSupplier.Text = "Find a Supplier";
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
            this.UpdateSupplier.Location = new System.Drawing.Point(23, 285);
            this.UpdateSupplier.Name = "UpdateSupplier";
            this.UpdateSupplier.Size = new System.Drawing.Size(236, 204);
            this.UpdateSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.UpdateSupplier.TabIndex = 6;
            this.UpdateSupplier.Text = "Update a Supplier";
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
            this.DeleteSupplier.Location = new System.Drawing.Point(265, 75);
            this.DeleteSupplier.Name = "DeleteSupplier";
            this.DeleteSupplier.Size = new System.Drawing.Size(236, 204);
            this.DeleteSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.DeleteSupplier.TabIndex = 5;
            this.DeleteSupplier.Text = "Delete a Supplier";
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
            this.AddSupplier.Location = new System.Drawing.Point(23, 75);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(236, 204);
            this.AddSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.AddSupplier.TabIndex = 4;
            this.AddSupplier.Text = "Add Supplier";
            this.AddSupplier.TileImage = global::Test.Properties.Resources.Add;
            this.AddSupplier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddSupplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AddSupplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddSupplier.UseSelectable = true;
            this.AddSupplier.UseTileImage = true;
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // Suppliers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 511);
            this.Controls.Add(this.ReceiveOrder);
            this.Controls.Add(this.SendOrder);
            this.Controls.Add(this.FindSupplier);
            this.Controls.Add(this.UpdateSupplier);
            this.Controls.Add(this.DeleteSupplier);
            this.Controls.Add(this.AddSupplier);
            this.MaximizeBox = false;
            this.Name = "Suppliers_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile FindSupplier;
        private MetroFramework.Controls.MetroTile UpdateSupplier;
        private MetroFramework.Controls.MetroTile DeleteSupplier;
        private MetroFramework.Controls.MetroTile AddSupplier;
        private MetroFramework.Controls.MetroTile SendOrder;
        private MetroFramework.Controls.MetroTile ReceiveOrder;
    }
}