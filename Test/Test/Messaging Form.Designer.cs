namespace Test
{
    partial class Messaging_Form
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
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.txtBody = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbxName = new MetroFramework.Controls.MetroComboBox();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(217, 663);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(536, 88);
            this.btnSend.TabIndex = 41;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBody
            // 
            // 
            // 
            // 
            this.txtBody.CustomButton.Image = null;
            this.txtBody.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.txtBody.CustomButton.Name = "";
            this.txtBody.CustomButton.Size = new System.Drawing.Size(507, 507);
            this.txtBody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBody.CustomButton.TabIndex = 1;
            this.txtBody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBody.CustomButton.UseSelectable = true;
            this.txtBody.CustomButton.Visible = false;
            this.txtBody.Lines = new string[0];
            this.txtBody.Location = new System.Drawing.Point(217, 148);
            this.txtBody.MaxLength = 32767;
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.PasswordChar = '\0';
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBody.SelectedText = "";
            this.txtBody.SelectionLength = 0;
            this.txtBody.SelectionStart = 0;
            this.txtBody.ShortcutsEnabled = true;
            this.txtBody.Size = new System.Drawing.Size(536, 509);
            this.txtBody.TabIndex = 39;
            this.txtBody.UseSelectable = true;
            this.txtBody.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBody.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(217, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Message Body:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(217, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 37;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(217, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Send Message To:";
            // 
            // cbxName
            // 
            this.cbxName.FormattingEnabled = true;
            this.cbxName.ItemHeight = 23;
            this.cbxName.Location = new System.Drawing.Point(217, 94);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(536, 29);
            this.cbxName.TabIndex = 34;
            this.cbxName.UseSelectable = true;
            this.cbxName.SelectedIndexChanged += new System.EventHandler(this.cbxName_SelectedIndexChanged);
            this.cbxName.Click += new System.EventHandler(this.cbxName_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(23, 567);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(163, 185);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile4.TabIndex = 33;
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
            this.metroTile2.Location = new System.Drawing.Point(23, 402);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(163, 159);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 32;
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
            this.metroTile1.Location = new System.Drawing.Point(23, 237);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(163, 159);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 31;
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
            this.metroTile3.Location = new System.Drawing.Point(23, 72);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(163, 159);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 30;
            this.metroTile3.Text = "Find Contacts";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = global::Test.Properties.Resources.Booked1;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // Messaging_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 761);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbxName);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(779, 761);
            this.Name = "Messaging_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.Messaging_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroTextBox txtBody;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbxName;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}