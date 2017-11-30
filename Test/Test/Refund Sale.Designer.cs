namespace Test
{
    partial class Refund_Sale
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefundOrder = new MetroFramework.Controls.MetroButton();
            this.txtCostOfSale = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantityPurchased = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtItemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbxCustomerName = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(24, 65);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Enter The Sale\'s ID";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(174, 23);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Enter The Sale\'s ID";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxCustomerName);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.btnRefundOrder);
            this.panel1.Controls.Add(this.txtCostOfSale);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.txtQuantityPurchased);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Location = new System.Drawing.Point(205, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 293);
            this.panel1.TabIndex = 2;
            // 
            // btnRefundOrder
            // 
            this.btnRefundOrder.Location = new System.Drawing.Point(5, 205);
            this.btnRefundOrder.Name = "btnRefundOrder";
            this.btnRefundOrder.Size = new System.Drawing.Size(174, 76);
            this.btnRefundOrder.TabIndex = 7;
            this.btnRefundOrder.Text = "Refund Order";
            this.btnRefundOrder.UseSelectable = true;
            this.btnRefundOrder.Click += new System.EventHandler(this.btnRefundOrder_Click);
            // 
            // txtCostOfSale
            // 
            // 
            // 
            // 
            this.txtCostOfSale.CustomButton.Image = null;
            this.txtCostOfSale.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtCostOfSale.CustomButton.Name = "";
            this.txtCostOfSale.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCostOfSale.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCostOfSale.CustomButton.TabIndex = 1;
            this.txtCostOfSale.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCostOfSale.CustomButton.UseSelectable = true;
            this.txtCostOfSale.CustomButton.Visible = false;
            this.txtCostOfSale.Lines = new string[0];
            this.txtCostOfSale.Location = new System.Drawing.Point(4, 122);
            this.txtCostOfSale.MaxLength = 32767;
            this.txtCostOfSale.Name = "txtCostOfSale";
            this.txtCostOfSale.PasswordChar = '\0';
            this.txtCostOfSale.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCostOfSale.SelectedText = "";
            this.txtCostOfSale.SelectionLength = 0;
            this.txtCostOfSale.SelectionStart = 0;
            this.txtCostOfSale.ShortcutsEnabled = true;
            this.txtCostOfSale.Size = new System.Drawing.Size(174, 23);
            this.txtCostOfSale.TabIndex = 6;
            this.txtCostOfSale.UseSelectable = true;
            this.txtCostOfSale.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCostOfSale.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 100);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Cost of Sale:";
            // 
            // txtQuantityPurchased
            // 
            // 
            // 
            // 
            this.txtQuantityPurchased.CustomButton.Image = null;
            this.txtQuantityPurchased.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtQuantityPurchased.CustomButton.Name = "";
            this.txtQuantityPurchased.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantityPurchased.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantityPurchased.CustomButton.TabIndex = 1;
            this.txtQuantityPurchased.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantityPurchased.CustomButton.UseSelectable = true;
            this.txtQuantityPurchased.CustomButton.Visible = false;
            this.txtQuantityPurchased.Lines = new string[0];
            this.txtQuantityPurchased.Location = new System.Drawing.Point(4, 74);
            this.txtQuantityPurchased.MaxLength = 32767;
            this.txtQuantityPurchased.Name = "txtQuantityPurchased";
            this.txtQuantityPurchased.PasswordChar = '\0';
            this.txtQuantityPurchased.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantityPurchased.SelectedText = "";
            this.txtQuantityPurchased.SelectionLength = 0;
            this.txtQuantityPurchased.SelectionStart = 0;
            this.txtQuantityPurchased.ShortcutsEnabled = true;
            this.txtQuantityPurchased.Size = new System.Drawing.Size(174, 23);
            this.txtQuantityPurchased.TabIndex = 4;
            this.txtQuantityPurchased.UseSelectable = true;
            this.txtQuantityPurchased.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantityPurchased.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 52);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(125, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Quantity Purchased:";
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.CustomButton.Image = null;
            this.txtItemName.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtItemName.CustomButton.Name = "";
            this.txtItemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemName.CustomButton.TabIndex = 1;
            this.txtItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemName.CustomButton.UseSelectable = true;
            this.txtItemName.CustomButton.Visible = false;
            this.txtItemName.Lines = new string[0];
            this.txtItemName.Location = new System.Drawing.Point(4, 26);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.ShortcutsEnabled = true;
            this.txtItemName.Size = new System.Drawing.Size(174, 23);
            this.txtItemName.TabIndex = 2;
            this.txtItemName.UseSelectable = true;
            this.txtItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Item Name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(205, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Sale Information :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(4, 148);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(109, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Customer Name:";
            // 
            // cbxCustomerName
            // 
            this.cbxCustomerName.FormattingEnabled = true;
            this.cbxCustomerName.ItemHeight = 23;
            this.cbxCustomerName.Location = new System.Drawing.Point(4, 170);
            this.cbxCustomerName.Name = "cbxCustomerName";
            this.cbxCustomerName.Size = new System.Drawing.Size(174, 29);
            this.cbxCustomerName.TabIndex = 9;
            this.cbxCustomerName.UseSelectable = true;
            // 
            // Refund_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 510);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.listBox1);
            this.Name = "Refund_Sale";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Refund a Sale";
            this.Load += new System.EventHandler(this.Refund_Sale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnRefundOrder;
        private MetroFramework.Controls.MetroTextBox txtCostOfSale;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtQuantityPurchased;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtItemName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbxCustomerName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}