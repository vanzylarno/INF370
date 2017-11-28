namespace Test
{
    partial class Make_a_New_Sale
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtType = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAddToBasket = new MetroFramework.Controls.MetroButton();
            this.Basket = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCaptureSale = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtQuantityPurchased = new MetroFramework.Controls.MetroTextBox();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Basket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 537);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(8, 64);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Enter the Product Name";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(197, 23);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Enter the Product Name";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(221, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 360);
            this.panel1.TabIndex = 4;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 310);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Product Price:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 155);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(127, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Product Description:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 107);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Quantity in Stock:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 55);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Product Type:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Product Name:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(3, 332);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(269, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(3, 129);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(269, 23);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(125, 125);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(3, 177);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(269, 130);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtType
            // 
            // 
            // 
            // 
            this.txtType.CustomButton.Image = null;
            this.txtType.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.txtType.CustomButton.Name = "";
            this.txtType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtType.CustomButton.TabIndex = 1;
            this.txtType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtType.CustomButton.UseSelectable = true;
            this.txtType.CustomButton.Visible = false;
            this.txtType.Lines = new string[0];
            this.txtType.Location = new System.Drawing.Point(3, 77);
            this.txtType.MaxLength = 32767;
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtType.SelectedText = "";
            this.txtType.SelectionLength = 0;
            this.txtType.SelectionStart = 0;
            this.txtType.ShortcutsEnabled = true;
            this.txtType.Size = new System.Drawing.Size(269, 23);
            this.txtType.TabIndex = 2;
            this.txtType.UseSelectable = true;
            this.txtType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(3, 29);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(269, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(278, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(221, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(136, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Product Information:";
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Location = new System.Drawing.Point(221, 541);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(459, 79);
            this.btnAddToBasket.TabIndex = 8;
            this.btnAddToBasket.Text = "Add Product to Basket";
            this.btnAddToBasket.UseSelectable = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // Basket
            // 
            this.Basket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Basket.Controls.Add(this.metroLabel7);
            this.Basket.Controls.Add(this.dataGridView1);
            this.Basket.Controls.Add(this.btnCaptureSale);
            this.Basket.Controls.Add(this.pictureBox2);
            this.Basket.Location = new System.Drawing.Point(687, 93);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(516, 537);
            this.Basket.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colItemQuantity,
            this.colLinePrice});
            this.dataGridView1.Location = new System.Drawing.Point(16, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 352);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnCaptureSale
            // 
            this.btnCaptureSale.Location = new System.Drawing.Point(18, 447);
            this.btnCaptureSale.Name = "btnCaptureSale";
            this.btnCaptureSale.Size = new System.Drawing.Size(486, 79);
            this.btnCaptureSale.TabIndex = 10;
            this.btnCaptureSale.Text = "Capture Sale";
            this.btnCaptureSale.UseSelectable = true;
            this.btnCaptureSale.Click += new System.EventHandler(this.btnCaptureSale_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test.Properties.Resources.Basket;
            this.pictureBox2.Location = new System.Drawing.Point(402, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // txtQuantityPurchased
            // 
            // 
            // 
            // 
            this.txtQuantityPurchased.CustomButton.Image = null;
            this.txtQuantityPurchased.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.txtQuantityPurchased.CustomButton.Name = "";
            this.txtQuantityPurchased.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantityPurchased.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantityPurchased.CustomButton.TabIndex = 1;
            this.txtQuantityPurchased.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantityPurchased.CustomButton.UseSelectable = true;
            this.txtQuantityPurchased.CustomButton.Visible = false;
            this.txtQuantityPurchased.Lines = new string[0];
            this.txtQuantityPurchased.Location = new System.Drawing.Point(221, 512);
            this.txtQuantityPurchased.MaxLength = 32767;
            this.txtQuantityPurchased.Name = "txtQuantityPurchased";
            this.txtQuantityPurchased.PasswordChar = '\0';
            this.txtQuantityPurchased.PromptText = "Please Enter the Quantity Purchased";
            this.txtQuantityPurchased.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantityPurchased.SelectedText = "";
            this.txtQuantityPurchased.SelectionLength = 0;
            this.txtQuantityPurchased.SelectionStart = 0;
            this.txtQuantityPurchased.ShortcutsEnabled = true;
            this.txtQuantityPurchased.Size = new System.Drawing.Size(459, 23);
            this.txtQuantityPurchased.TabIndex = 10;
            this.txtQuantityPurchased.UseSelectable = true;
            this.txtQuantityPurchased.WaterMark = "Please Enter the Quantity Purchased";
            this.txtQuantityPurchased.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantityPurchased.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.Name = "colItemName";
            // 
            // colItemQuantity
            // 
            this.colItemQuantity.HeaderText = "Quantity";
            this.colItemQuantity.Name = "colItemQuantity";
            // 
            // colLinePrice
            // 
            this.colLinePrice.HeaderText = "Price";
            this.colLinePrice.Name = "colLinePrice";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(18, 42);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(80, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Your Order:";
            // 
            // Make_a_New_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 653);
            this.Controls.Add(this.txtQuantityPurchased);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.btnAddToBasket);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.listBox1);
            this.Name = "Make_a_New_Sale";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Make a New Sale";
            this.Load += new System.EventHandler(this.Make_a_New_Sale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Basket.ResumeLayout(false);
            this.Basket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtType;
        private MetroFramework.Controls.MetroTextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAddToBasket;
        private System.Windows.Forms.Panel Basket;
        private MetroFramework.Controls.MetroButton btnCaptureSale;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtQuantityPurchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinePrice;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}