namespace Test
{
    partial class Find_Messaging_Contact
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
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 116);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Contact Number:";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(23, 141);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(221, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(199, 1);
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
            this.txtFilter.PromptText = "Enter Contact Name";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(221, 23);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Enter Contact Name";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // Find_Messaging_Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 195);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFilter);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(273, 195);
            this.Name = "Find_Messaging_Contact";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Find Contact";
            this.Load += new System.EventHandler(this.Find_Messaging_Contact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtFilter;
    }
}