namespace Test
{
    partial class Mailing_Form
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSubject = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtBody = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(204, 85);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(536, 29);
            this.metroComboBox1.TabIndex = 22;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            this.metroComboBox1.Click += new System.EventHandler(this.metroComboBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(204, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Send Email To:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtSubject
            // 
            // 
            // 
            // 
            this.txtSubject.CustomButton.Image = null;
            this.txtSubject.CustomButton.Location = new System.Drawing.Point(514, 1);
            this.txtSubject.CustomButton.Name = "";
            this.txtSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubject.CustomButton.TabIndex = 1;
            this.txtSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubject.CustomButton.UseSelectable = true;
            this.txtSubject.CustomButton.Visible = false;
            this.txtSubject.Lines = new string[0];
            this.txtSubject.Location = new System.Drawing.Point(204, 139);
            this.txtSubject.MaxLength = 32767;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubject.SelectedText = "";
            this.txtSubject.SelectionLength = 0;
            this.txtSubject.SelectionStart = 0;
            this.txtSubject.ShortcutsEnabled = true;
            this.txtSubject.Size = new System.Drawing.Size(536, 23);
            this.txtSubject.TabIndex = 24;
            this.txtSubject.UseSelectable = true;
            this.txtSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSubject.Click += new System.EventHandler(this.txtSubject_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(204, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Email Subject:";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(204, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Email Body:";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // txtBody
            // 
            // 
            // 
            // 
            this.txtBody.CustomButton.Image = null;
            this.txtBody.CustomButton.Location = new System.Drawing.Point(78, 2);
            this.txtBody.CustomButton.Name = "";
            this.txtBody.CustomButton.Size = new System.Drawing.Size(455, 455);
            this.txtBody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBody.CustomButton.TabIndex = 1;
            this.txtBody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBody.CustomButton.UseSelectable = true;
            this.txtBody.CustomButton.Visible = false;
            this.txtBody.Lines = new string[0];
            this.txtBody.Location = new System.Drawing.Point(204, 187);
            this.txtBody.MaxLength = 32767;
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.PasswordChar = '\0';
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBody.SelectedText = "";
            this.txtBody.SelectionLength = 0;
            this.txtBody.SelectionStart = 0;
            this.txtBody.ShortcutsEnabled = true;
            this.txtBody.Size = new System.Drawing.Size(536, 460);
            this.txtBody.TabIndex = 27;
            this.txtBody.UseSelectable = true;
            this.txtBody.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBody.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBody.Click += new System.EventHandler(this.txtBody_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(204, 654);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(154, 88);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Text = "Add Attachment";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(364, 654);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(376, 88);
            this.btnSend.TabIndex = 29;
            this.btnSend.Text = "Send Email";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(10, 558);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(163, 185);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile4.TabIndex = 21;
            this.metroTile4.Text = "Delete a Contact";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile4.TileImage = global::Test.Properties.Resources.Delete;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(10, 393);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(163, 159);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 20;
            this.metroTile2.Text = "Update a Contact";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = global::Test.Properties.Resources.Update;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(10, 228);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(163, 159);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 19;
            this.metroTile1.Text = "Add a Contact";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::Test.Properties.Resources.Add;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(10, 63);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(163, 159);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 18;
            this.metroTile3.Text = "Find Contacts";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = global::Test.Properties.Resources.Booked1;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // Mailing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 749);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(757, 749);
            this.Name = "Mailing_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Mailing";
            this.Load += new System.EventHandler(this.Mailing_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSubject;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtBody;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnSend;
    }
}