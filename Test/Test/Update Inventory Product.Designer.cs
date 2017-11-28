namespace Test
{
    partial class Update_Inventory_Product
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
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnChoose = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtProductQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtProductType = new MetroFramework.Controls.MetroTextBox();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(23, 63);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Enter the Product Name";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(250, 23);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Enter the Product Name";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 303);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(22, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(251, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Select The Product You Want to Update";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtProductQuantity);
            this.panel1.Controls.Add(this.txtProductType);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Location = new System.Drawing.Point(313, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 345);
            this.panel1.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(4, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(453, 55);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(279, 215);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(177, 55);
            this.btnChoose.TabIndex = 9;
            this.btnChoose.Text = "Choose Product Image";
            this.btnChoose.UseSelectable = true;
            this.btnChoose.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(280, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 184);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(123, 123);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(3, 115);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PromptText = "Please Procide a Product Description";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(270, 125);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMark = "Please Procide a Product Description";
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductQuantity
            // 
            // 
            // 
            // 
            this.txtProductQuantity.CustomButton.Image = null;
            this.txtProductQuantity.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.txtProductQuantity.CustomButton.Name = "";
            this.txtProductQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductQuantity.CustomButton.TabIndex = 1;
            this.txtProductQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductQuantity.CustomButton.UseSelectable = true;
            this.txtProductQuantity.CustomButton.Visible = false;
            this.txtProductQuantity.Lines = new string[0];
            this.txtProductQuantity.Location = new System.Drawing.Point(4, 84);
            this.txtProductQuantity.MaxLength = 32767;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PasswordChar = '\0';
            this.txtProductQuantity.PromptText = "Please Enter the Product Quantity";
            this.txtProductQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductQuantity.SelectedText = "";
            this.txtProductQuantity.SelectionLength = 0;
            this.txtProductQuantity.SelectionStart = 0;
            this.txtProductQuantity.ShortcutsEnabled = true;
            this.txtProductQuantity.Size = new System.Drawing.Size(269, 23);
            this.txtProductQuantity.TabIndex = 6;
            this.txtProductQuantity.UseSelectable = true;
            this.txtProductQuantity.WaterMark = "Please Enter the Product Quantity";
            this.txtProductQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductType
            // 
            // 
            // 
            // 
            this.txtProductType.CustomButton.Image = null;
            this.txtProductType.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.txtProductType.CustomButton.Name = "";
            this.txtProductType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductType.CustomButton.TabIndex = 1;
            this.txtProductType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductType.CustomButton.UseSelectable = true;
            this.txtProductType.CustomButton.Visible = false;
            this.txtProductType.Lines = new string[0];
            this.txtProductType.Location = new System.Drawing.Point(4, 55);
            this.txtProductType.MaxLength = 32767;
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.PasswordChar = '\0';
            this.txtProductType.PromptText = "Please Enter the Product Type";
            this.txtProductType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductType.SelectedText = "";
            this.txtProductType.SelectionLength = 0;
            this.txtProductType.SelectionStart = 0;
            this.txtProductType.ShortcutsEnabled = true;
            this.txtProductType.Size = new System.Drawing.Size(269, 23);
            this.txtProductType.TabIndex = 5;
            this.txtProductType.UseSelectable = true;
            this.txtProductType.WaterMark = "Please Enter the Product Type";
            this.txtProductType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(3, 25);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PromptText = "Please Enter the Product Name";
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(270, 23);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMark = "Please Enter the Product Name";
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(280, 57);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Please Provide the New Product Information\r\n\r\n";
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(3, 247);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PromptText = "Enter the New Product Price";
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(270, 23);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMark = "Enter the New Product Price";
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Update_Inventory_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtFilter);
            this.Name = "Update_Inventory_Product";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.Update_Inventory_Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtFilter;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnChoose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtProductQuantity;
        private MetroFramework.Controls.MetroTextBox txtProductType;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPrice;
    }
}