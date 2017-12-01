namespace Test
{
    partial class Find_Wine_Tasting
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtOldTime = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerPNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtOldDate = new MetroFramework.Controls.MetroTextBox();
            this.txtOldPArtySize = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.listBox1);
            this.metroPanel1.Controls.Add(this.txtFilter);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(274, 436);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 368);
            this.listBox1.TabIndex = 3;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(7, 13);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Enter Customer Name";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(260, 23);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Enter Customer Name";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.txtOldTime);
            this.panel1.Controls.Add(this.txtCustomerPNumber);
            this.panel1.Controls.Add(this.txtOldDate);
            this.panel1.Controls.Add(this.txtOldPArtySize);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(303, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 156);
            this.panel1.TabIndex = 6;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(221, 91);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(164, 19);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "Customer Phone Number:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(221, 43);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(73, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Group Size";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(9, 91);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(115, 19);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Wine Tasting Time";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Wine Tasting Date";
            // 
            // txtOldTime
            // 
            // 
            // 
            // 
            this.txtOldTime.CustomButton.Image = null;
            this.txtOldTime.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtOldTime.CustomButton.Name = "";
            this.txtOldTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOldTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldTime.CustomButton.TabIndex = 1;
            this.txtOldTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldTime.CustomButton.UseSelectable = true;
            this.txtOldTime.CustomButton.Visible = false;
            this.txtOldTime.Lines = new string[0];
            this.txtOldTime.Location = new System.Drawing.Point(9, 113);
            this.txtOldTime.MaxLength = 32767;
            this.txtOldTime.Name = "txtOldTime";
            this.txtOldTime.PasswordChar = '\0';
            this.txtOldTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldTime.SelectedText = "";
            this.txtOldTime.SelectionLength = 0;
            this.txtOldTime.SelectionStart = 0;
            this.txtOldTime.ShortcutsEnabled = true;
            this.txtOldTime.Size = new System.Drawing.Size(189, 23);
            this.txtOldTime.TabIndex = 6;
            this.txtOldTime.UseSelectable = true;
            this.txtOldTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCustomerPNumber
            // 
            // 
            // 
            // 
            this.txtCustomerPNumber.CustomButton.Image = null;
            this.txtCustomerPNumber.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtCustomerPNumber.CustomButton.Name = "";
            this.txtCustomerPNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerPNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerPNumber.CustomButton.TabIndex = 1;
            this.txtCustomerPNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerPNumber.CustomButton.UseSelectable = true;
            this.txtCustomerPNumber.CustomButton.Visible = false;
            this.txtCustomerPNumber.Lines = new string[0];
            this.txtCustomerPNumber.Location = new System.Drawing.Point(221, 113);
            this.txtCustomerPNumber.MaxLength = 32767;
            this.txtCustomerPNumber.Name = "txtCustomerPNumber";
            this.txtCustomerPNumber.PasswordChar = '\0';
            this.txtCustomerPNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerPNumber.SelectedText = "";
            this.txtCustomerPNumber.SelectionLength = 0;
            this.txtCustomerPNumber.SelectionStart = 0;
            this.txtCustomerPNumber.ShortcutsEnabled = true;
            this.txtCustomerPNumber.Size = new System.Drawing.Size(184, 23);
            this.txtCustomerPNumber.TabIndex = 5;
            this.txtCustomerPNumber.UseSelectable = true;
            this.txtCustomerPNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerPNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOldDate
            // 
            // 
            // 
            // 
            this.txtOldDate.CustomButton.Image = null;
            this.txtOldDate.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtOldDate.CustomButton.Name = "";
            this.txtOldDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOldDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldDate.CustomButton.TabIndex = 1;
            this.txtOldDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldDate.CustomButton.UseSelectable = true;
            this.txtOldDate.CustomButton.Visible = false;
            this.txtOldDate.Lines = new string[0];
            this.txtOldDate.Location = new System.Drawing.Point(9, 65);
            this.txtOldDate.MaxLength = 32767;
            this.txtOldDate.Name = "txtOldDate";
            this.txtOldDate.PasswordChar = '\0';
            this.txtOldDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldDate.SelectedText = "";
            this.txtOldDate.SelectionLength = 0;
            this.txtOldDate.SelectionStart = 0;
            this.txtOldDate.ShortcutsEnabled = true;
            this.txtOldDate.Size = new System.Drawing.Size(189, 23);
            this.txtOldDate.TabIndex = 4;
            this.txtOldDate.UseSelectable = true;
            this.txtOldDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOldPArtySize
            // 
            // 
            // 
            // 
            this.txtOldPArtySize.CustomButton.Image = null;
            this.txtOldPArtySize.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtOldPArtySize.CustomButton.Name = "";
            this.txtOldPArtySize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOldPArtySize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldPArtySize.CustomButton.TabIndex = 1;
            this.txtOldPArtySize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldPArtySize.CustomButton.UseSelectable = true;
            this.txtOldPArtySize.CustomButton.Visible = false;
            this.txtOldPArtySize.Lines = new string[0];
            this.txtOldPArtySize.Location = new System.Drawing.Point(221, 65);
            this.txtOldPArtySize.MaxLength = 32767;
            this.txtOldPArtySize.Name = "txtOldPArtySize";
            this.txtOldPArtySize.PasswordChar = '\0';
            this.txtOldPArtySize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldPArtySize.SelectedText = "";
            this.txtOldPArtySize.SelectionLength = 0;
            this.txtOldPArtySize.SelectionStart = 0;
            this.txtOldPArtySize.ShortcutsEnabled = true;
            this.txtOldPArtySize.Size = new System.Drawing.Size(184, 23);
            this.txtOldPArtySize.TabIndex = 3;
            this.txtOldPArtySize.UseSelectable = true;
            this.txtOldPArtySize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldPArtySize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Wine Tasting Details:";
            // 
            // Find_Wine_Tasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 513);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Find_Wine_Tasting";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Find a Wine Tasting";
            this.Load += new System.EventHandler(this.Find_Wine_Tasting_Load);
            this.metroPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtOldTime;
        private MetroFramework.Controls.MetroTextBox txtCustomerPNumber;
        private MetroFramework.Controls.MetroTextBox txtOldDate;
        private MetroFramework.Controls.MetroTextBox txtOldPArtySize;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}