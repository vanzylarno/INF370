namespace Test
{
    partial class Help_Form
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
            this.mtCreateANewPassword = new MetroFramework.Controls.MetroTile();
            this.mtFindAForgottenUsername = new MetroFramework.Controls.MetroTile();
            this.mtForgottenPassword = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtCreateANewPassword
            // 
            this.mtCreateANewPassword.ActiveControl = null;
            this.mtCreateANewPassword.Location = new System.Drawing.Point(13, 255);
            this.mtCreateANewPassword.Name = "mtCreateANewPassword";
            this.mtCreateANewPassword.Size = new System.Drawing.Size(530, 186);
            this.mtCreateANewPassword.TabIndex = 2;
            this.mtCreateANewPassword.Text = "Create a New Password";
            this.mtCreateANewPassword.TileImage = global::Test.Properties.Resources.if_SEO_key_9692611;
            this.mtCreateANewPassword.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCreateANewPassword.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCreateANewPassword.UseSelectable = true;
            this.mtCreateANewPassword.UseTileImage = true;
            this.mtCreateANewPassword.Click += new System.EventHandler(this.mtCreateANewPassword_Click);
            // 
            // mtFindAForgottenUsername
            // 
            this.mtFindAForgottenUsername.ActiveControl = null;
            this.mtFindAForgottenUsername.Location = new System.Drawing.Point(281, 63);
            this.mtFindAForgottenUsername.Name = "mtFindAForgottenUsername";
            this.mtFindAForgottenUsername.Size = new System.Drawing.Size(262, 186);
            this.mtFindAForgottenUsername.TabIndex = 1;
            this.mtFindAForgottenUsername.Text = "Find a Forgotten Username";
            this.mtFindAForgottenUsername.TileImage = global::Test.Properties.Resources.Username4;
            this.mtFindAForgottenUsername.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtFindAForgottenUsername.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtFindAForgottenUsername.UseSelectable = true;
            this.mtFindAForgottenUsername.UseTileImage = true;
            this.mtFindAForgottenUsername.Click += new System.EventHandler(this.mtFindAForgottenUsername_Click);
            // 
            // mtForgottenPassword
            // 
            this.mtForgottenPassword.ActiveControl = null;
            this.mtForgottenPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mtForgottenPassword.Location = new System.Drawing.Point(13, 63);
            this.mtForgottenPassword.Name = "mtForgottenPassword";
            this.mtForgottenPassword.Size = new System.Drawing.Size(262, 186);
            this.mtForgottenPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtForgottenPassword.TabIndex = 0;
            this.mtForgottenPassword.Text = "Find a Forgotten Password";
            this.mtForgottenPassword.TileImage = global::Test.Properties.Resources.if_cloud_key_lock_532256_1_4;
            this.mtForgottenPassword.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtForgottenPassword.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtForgottenPassword.UseSelectable = true;
            this.mtForgottenPassword.UseTileImage = true;
            this.mtForgottenPassword.Click += new System.EventHandler(this.mtForgottenPassword_Click);
            // 
            // Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 460);
            this.Controls.Add(this.mtCreateANewPassword);
            this.Controls.Add(this.mtFindAForgottenUsername);
            this.Controls.Add(this.mtForgottenPassword);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(558, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(558, 460);
            this.Name = "Help_Form";
            this.Resizable = false;
            this.Text = "Help";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Help_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtForgottenPassword;
        private MetroFramework.Controls.MetroTile mtFindAForgottenUsername;
        private MetroFramework.Controls.MetroTile mtCreateANewPassword;
    }
}