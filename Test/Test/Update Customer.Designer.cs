namespace Test
{
    partial class Update_Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtEAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtPNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtFName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.txtEAddress);
            this.panel1.Controls.Add(this.txtPNumber);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(284, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 277);
            this.panel1.TabIndex = 7;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(32, 176);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(252, 61);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Add New Customer";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(155, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Customer\'s Date of Birth:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(32, 149);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(252, 20);
            this.dtpDOB.TabIndex = 11;
            // 
            // txtEAddress
            // 
            // 
            // 
            // 
            this.txtEAddress.CustomButton.Image = null;
            this.txtEAddress.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtEAddress.CustomButton.Name = "";
            this.txtEAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEAddress.CustomButton.TabIndex = 1;
            this.txtEAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEAddress.CustomButton.UseSelectable = true;
            this.txtEAddress.CustomButton.Visible = false;
            this.txtEAddress.Lines = new string[0];
            this.txtEAddress.Location = new System.Drawing.Point(32, 101);
            this.txtEAddress.MaxLength = 32767;
            this.txtEAddress.Name = "txtEAddress";
            this.txtEAddress.PasswordChar = '\0';
            this.txtEAddress.PromptText = "Please Enter the Customer\'s Email Address";
            this.txtEAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEAddress.SelectedText = "";
            this.txtEAddress.SelectionLength = 0;
            this.txtEAddress.SelectionStart = 0;
            this.txtEAddress.ShortcutsEnabled = true;
            this.txtEAddress.Size = new System.Drawing.Size(252, 23);
            this.txtEAddress.TabIndex = 10;
            this.txtEAddress.UseSelectable = true;
            this.txtEAddress.WaterMark = "Please Enter the Customer\'s Email Address";
            this.txtEAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPNumber
            // 
            // 
            // 
            // 
            this.txtPNumber.CustomButton.Image = null;
            this.txtPNumber.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtPNumber.CustomButton.Name = "";
            this.txtPNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPNumber.CustomButton.TabIndex = 1;
            this.txtPNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPNumber.CustomButton.UseSelectable = true;
            this.txtPNumber.CustomButton.Visible = false;
            this.txtPNumber.Lines = new string[0];
            this.txtPNumber.Location = new System.Drawing.Point(32, 72);
            this.txtPNumber.MaxLength = 32767;
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.PasswordChar = '\0';
            this.txtPNumber.PromptText = "Please Enter the Customer\'s Phone Number";
            this.txtPNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPNumber.SelectedText = "";
            this.txtPNumber.SelectionLength = 0;
            this.txtPNumber.SelectionStart = 0;
            this.txtPNumber.ShortcutsEnabled = true;
            this.txtPNumber.Size = new System.Drawing.Size(252, 23);
            this.txtPNumber.TabIndex = 9;
            this.txtPNumber.UseSelectable = true;
            this.txtPNumber.WaterMark = "Please Enter the Customer\'s Phone Number";
            this.txtPNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFName
            // 
            // 
            // 
            // 
            this.txtFName.CustomButton.Image = null;
            this.txtFName.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtFName.CustomButton.Name = "";
            this.txtFName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFName.CustomButton.TabIndex = 1;
            this.txtFName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFName.CustomButton.UseSelectable = true;
            this.txtFName.CustomButton.Visible = false;
            this.txtFName.Lines = new string[0];
            this.txtFName.Location = new System.Drawing.Point(32, 43);
            this.txtFName.MaxLength = 32767;
            this.txtFName.Name = "txtFName";
            this.txtFName.PasswordChar = '\0';
            this.txtFName.PromptText = "Please Enter the Customer\'s Fullname";
            this.txtFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFName.SelectedText = "";
            this.txtFName.SelectionLength = 0;
            this.txtFName.SelectionStart = 0;
            this.txtFName.ShortcutsEnabled = true;
            this.txtFName.Size = new System.Drawing.Size(252, 23);
            this.txtFName.TabIndex = 8;
            this.txtFName.UseSelectable = true;
            this.txtFName.WaterMark = "Please Enter the Customer\'s Fullname";
            this.txtFName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(252, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Please Provide the Following Inforamtion:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.txtFilter);
            this.panel2.Location = new System.Drawing.Point(5, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 334);
            this.panel2.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 277);
            this.listBox1.TabIndex = 10;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(3, 20);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Enter the Customer\'s Name";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(264, 23);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Enter the Customer\'s Name";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged_1);
            // 
            // Update_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 408);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 408);
            this.Name = "Update_Customer";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Update a Customer";
            this.Load += new System.EventHandler(this.Update_Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private MetroFramework.Controls.MetroTextBox txtEAddress;
        private MetroFramework.Controls.MetroTextBox txtPNumber;
        private MetroFramework.Controls.MetroTextBox txtFName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox txtFilter;
    }
}