namespace Test
{
    partial class Find_a_Forgotten_Username_Form
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
            this.txtUserEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(486, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "To Find Your Password Help us byProviding the Following Information :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtUserEmail
            // 
            // 
            // 
            // 
            this.txtUserEmail.CustomButton.Image = null;
            this.txtUserEmail.CustomButton.Location = new System.Drawing.Point(436, 1);
            this.txtUserEmail.CustomButton.Name = "";
            this.txtUserEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserEmail.CustomButton.TabIndex = 1;
            this.txtUserEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserEmail.CustomButton.UseSelectable = true;
            this.txtUserEmail.CustomButton.Visible = false;
            this.txtUserEmail.Lines = new string[0];
            this.txtUserEmail.Location = new System.Drawing.Point(23, 87);
            this.txtUserEmail.MaxLength = 32767;
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.PasswordChar = '\0';
            this.txtUserEmail.PromptText = "Please Provide your Email Address";
            this.txtUserEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserEmail.SelectedText = "";
            this.txtUserEmail.SelectionLength = 0;
            this.txtUserEmail.SelectionStart = 0;
            this.txtUserEmail.ShortcutsEnabled = true;
            this.txtUserEmail.Size = new System.Drawing.Size(458, 23);
            this.txtUserEmail.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserEmail.TabIndex = 1;
            this.txtUserEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUserEmail.UseSelectable = true;
            this.txtUserEmail.WaterMark = "Please Provide your Email Address";
            this.txtUserEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(6, 116);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(486, 51);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Find Username";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Find_a_Forgotten_Username_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 185);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(504, 185);
            this.MinimumSize = new System.Drawing.Size(504, 185);
            this.Name = "Find_a_Forgotten_Username_Form";
            this.Resizable = false;
            this.Text = "Find a Forgotten Username";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Find_a_Forgotten_Username_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUserEmail;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}