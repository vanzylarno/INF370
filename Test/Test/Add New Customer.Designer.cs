namespace Test
{
    partial class Add_New_Customer
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
            this.txtFName = new MetroFramework.Controls.MetroTextBox();
            this.txtPNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtEAddress = new MetroFramework.Controls.MetroTextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(252, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Please Provide the Following Inforamtion:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
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
            this.txtFName.Location = new System.Drawing.Point(24, 87);
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
            this.txtFName.TabIndex = 1;
            this.txtFName.UseSelectable = true;
            this.txtFName.WaterMark = "Please Enter the Customer\'s Fullname";
            this.txtFName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFName.Click += new System.EventHandler(this.txtFName_Click);
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
            this.txtPNumber.Location = new System.Drawing.Point(24, 116);
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
            this.txtPNumber.TabIndex = 2;
            this.txtPNumber.UseSelectable = true;
            this.txtPNumber.WaterMark = "Please Enter the Customer\'s Phone Number";
            this.txtPNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPNumber.Click += new System.EventHandler(this.txtPNumber_Click);
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
            this.txtEAddress.Location = new System.Drawing.Point(24, 145);
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
            this.txtEAddress.TabIndex = 3;
            this.txtEAddress.UseSelectable = true;
            this.txtEAddress.WaterMark = "Please Enter the Customer\'s Email Address";
            this.txtEAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEAddress.Click += new System.EventHandler(this.txtEAddress_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(24, 193);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(252, 20);
            this.dtpDOB.TabIndex = 4;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 171);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(155, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Customer\'s Date of Birth:";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 220);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(252, 61);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Add New Customer";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 298);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtEAddress);
            this.Controls.Add(this.txtPNumber);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 298);
            this.Name = "Add_New_Customer";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Add a New Customer";
            this.Load += new System.EventHandler(this.Add_New_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFName;
        private MetroFramework.Controls.MetroTextBox txtPNumber;
        private MetroFramework.Controls.MetroTextBox txtEAddress;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}