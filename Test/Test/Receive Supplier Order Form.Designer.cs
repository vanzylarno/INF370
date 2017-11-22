namespace Test
{
    partial class Receive_Supplier_Order_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receive_Supplier_Order_Form));
            this.lbxSupplierOrders = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.asas = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblProductOrdered = new MetroFramework.Controls.MetroLabel();
            this.lblQuantityOrdered = new MetroFramework.Controls.MetroLabel();
            this.lblOrderedFrom = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtCost = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxSupplierOrders
            // 
            this.lbxSupplierOrders.FormattingEnabled = true;
            this.lbxSupplierOrders.Location = new System.Drawing.Point(12, 105);
            this.lbxSupplierOrders.Name = "lbxSupplierOrders";
            this.lbxSupplierOrders.Size = new System.Drawing.Size(252, 342);
            this.lbxSupplierOrders.TabIndex = 0;
            this.lbxSupplierOrders.Click += new System.EventHandler(this.lbxSupplierOrders_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(12, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(252, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "What Order Would You Like to Receive?";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.lblOrderedFrom);
            this.panel1.Controls.Add(this.lblQuantityOrdered);
            this.panel1.Controls.Add(this.lblProductOrdered);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.asas);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Location = new System.Drawing.Point(295, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 150);
            this.panel1.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(299, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Order Information:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Product Ordered:";
            // 
            // asas
            // 
            this.asas.AutoSize = true;
            this.asas.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.asas.Location = new System.Drawing.Point(3, 49);
            this.asas.Name = "asas";
            this.asas.Size = new System.Drawing.Size(121, 19);
            this.asas.TabIndex = 5;
            this.asas.Text = "Quantity Ordered:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(19, 88);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(99, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Ordered From:";
            // 
            // lblProductOrdered
            // 
            this.lblProductOrdered.AutoSize = true;
            this.lblProductOrdered.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblProductOrdered.Location = new System.Drawing.Point(142, 15);
            this.lblProductOrdered.Name = "lblProductOrdered";
            this.lblProductOrdered.Size = new System.Drawing.Size(115, 19);
            this.lblProductOrdered.TabIndex = 5;
            this.lblProductOrdered.Text = "Product Ordered:";
            // 
            // lblQuantityOrdered
            // 
            this.lblQuantityOrdered.AutoSize = true;
            this.lblQuantityOrdered.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblQuantityOrdered.Location = new System.Drawing.Point(142, 49);
            this.lblQuantityOrdered.Name = "lblQuantityOrdered";
            this.lblQuantityOrdered.Size = new System.Drawing.Size(115, 19);
            this.lblQuantityOrdered.TabIndex = 6;
            this.lblQuantityOrdered.Text = "Product Ordered:";
            // 
            // lblOrderedFrom
            // 
            this.lblOrderedFrom.AutoSize = true;
            this.lblOrderedFrom.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblOrderedFrom.Location = new System.Drawing.Point(142, 88);
            this.lblOrderedFrom.Name = "lblOrderedFrom";
            this.lblOrderedFrom.Size = new System.Drawing.Size(115, 19);
            this.lblOrderedFrom.TabIndex = 5;
            this.lblOrderedFrom.Text = "Product Ordered:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(295, 258);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(201, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "When was this Order Received?";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(295, 281);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(569, 258);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(213, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "What was the Cost of this Order?";
            // 
            // txtCost
            // 
            // 
            // 
            // 
            this.txtCost.CustomButton.Image = null;
            this.txtCost.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtCost.CustomButton.Name = "";
            this.txtCost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCost.CustomButton.TabIndex = 1;
            this.txtCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCost.CustomButton.UseSelectable = true;
            this.txtCost.CustomButton.Visible = false;
            this.txtCost.Lines = new string[0];
            this.txtCost.Location = new System.Drawing.Point(569, 281);
            this.txtCost.MaxLength = 32767;
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCost.SelectedText = "";
            this.txtCost.SelectionLength = 0;
            this.txtCost.SelectionStart = 0;
            this.txtCost.ShortcutsEnabled = true;
            this.txtCost.Size = new System.Drawing.Size(240, 23);
            this.txtCost.TabIndex = 7;
            this.txtCost.UseSelectable = true;
            this.txtCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(569, 311);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(240, 136);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Capture this Order as Received";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(348, 15);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(107, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Received Status:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(371, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "if_checkmark_15191.ico");
            this.imageList1.Images.SetKeyName(1, "if_no_2482.ico");
            // 
            // Receive_Supplier_Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 465);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbxSupplierOrders);
            this.Name = "Receive_Supplier_Order_Form";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Receive Supplier Order";
            this.Load += new System.EventHandler(this.Receive_Supplier_Order_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSupplierOrders;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lblOrderedFrom;
        private MetroFramework.Controls.MetroLabel lblQuantityOrdered;
        private MetroFramework.Controls.MetroLabel lblProductOrdered;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel asas;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtCost;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ImageList imageList1;
    }
}