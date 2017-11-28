namespace Test
{
    partial class Send_Supplier_Order
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbxSuppliers = new System.Windows.Forms.ListBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbxSupplierOrderProducts = new System.Windows.Forms.ListBox();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CalenderPick = new System.Windows.Forms.MonthCalendar();
            this.btnPlaceOrder = new MetroFramework.Controls.MetroButton();
            this.lblHelpPress = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Choose your Supplier:";
            // 
            // lbxSuppliers
            // 
            this.lbxSuppliers.FormattingEnabled = true;
            this.lbxSuppliers.Location = new System.Drawing.Point(24, 98);
            this.lbxSuppliers.Name = "lbxSuppliers";
            this.lbxSuppliers.Size = new System.Drawing.Size(196, 251);
            this.lbxSuppliers.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(226, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(186, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "What do you want to Order?";
            // 
            // lbxSupplierOrderProducts
            // 
            this.lbxSupplierOrderProducts.FormattingEnabled = true;
            this.lbxSupplierOrderProducts.Location = new System.Drawing.Point(226, 98);
            this.lbxSupplierOrderProducts.Name = "lbxSupplierOrderProducts";
            this.lbxSupplierOrderProducts.Size = new System.Drawing.Size(196, 251);
            this.lbxSupplierOrderProducts.TabIndex = 3;
            this.lbxSupplierOrderProducts.SelectedIndexChanged += new System.EventHandler(this.lbxSupplierOrderProducts_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(429, 98);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(216, 23);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(429, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(187, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "What Quantity do you want?";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(429, 168);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(201, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "When do you want your Stock?";
            // 
            // CalenderPick
            // 
            this.CalenderPick.Location = new System.Drawing.Point(429, 187);
            this.CalenderPick.Name = "CalenderPick";
            this.CalenderPick.TabIndex = 7;
            this.CalenderPick.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalenderPick_DateSelected);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(24, 361);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(399, 70);
            this.btnPlaceOrder.TabIndex = 8;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseSelectable = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblHelpPress
            // 
            this.lblHelpPress.AutoSize = true;
            this.lblHelpPress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblHelpPress.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHelpPress.Location = new System.Drawing.Point(435, 412);
            this.lblHelpPress.Name = "lblHelpPress";
            this.lblHelpPress.Size = new System.Drawing.Size(220, 19);
            this.lblHelpPress.TabIndex = 9;
            this.lblHelpPress.Text = "Can\'t find what you\'re looking for?";
            this.lblHelpPress.UseCustomForeColor = true;
            this.lblHelpPress.Click += new System.EventHandler(this.lblHelpPress_Click);
            // 
            // Send_Supplier_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(670, 443);
            this.Controls.Add(this.lblHelpPress);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.CalenderPick);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbxSupplierOrderProducts);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbxSuppliers);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 443);
            this.Name = "Send_Supplier_Order";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Send a Supplier Order";
            this.Load += new System.EventHandler(this.Send_Supplier_Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox lbxSuppliers;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListBox lbxSupplierOrderProducts;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.MonthCalendar CalenderPick;
        private MetroFramework.Controls.MetroButton btnPlaceOrder;
        private MetroFramework.Controls.MetroLabel lblHelpPress;
    }
}