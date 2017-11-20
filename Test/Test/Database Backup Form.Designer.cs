namespace Test
{
    partial class Database_Backup_Form
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
            this.cbxServerName = new MetroFramework.Controls.MetroComboBox();
            this.cbxDatabaseName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnCreatebackup = new MetroFramework.Controls.MetroButton();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Select Server Name:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbxServerName
            // 
            this.cbxServerName.FormattingEnabled = true;
            this.cbxServerName.ItemHeight = 23;
            this.cbxServerName.Location = new System.Drawing.Point(23, 82);
            this.cbxServerName.Name = "cbxServerName";
            this.cbxServerName.Size = new System.Drawing.Size(275, 29);
            this.cbxServerName.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbxServerName.TabIndex = 1;
            this.cbxServerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxServerName.UseSelectable = true;
            this.cbxServerName.SelectedIndexChanged += new System.EventHandler(this.cbxServerName_SelectedIndexChanged);
            // 
            // cbxDatabaseName
            // 
            this.cbxDatabaseName.FormattingEnabled = true;
            this.cbxDatabaseName.ItemHeight = 23;
            this.cbxDatabaseName.Location = new System.Drawing.Point(23, 136);
            this.cbxDatabaseName.Name = "cbxDatabaseName";
            this.cbxDatabaseName.Size = new System.Drawing.Size(275, 29);
            this.cbxDatabaseName.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbxDatabaseName.TabIndex = 3;
            this.cbxDatabaseName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxDatabaseName.UseSelectable = true;
            this.cbxDatabaseName.SelectedIndexChanged += new System.EventHandler(this.cbxDatabaseName_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Select Database Name:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnCreatebackup
            // 
            this.btnCreatebackup.Location = new System.Drawing.Point(22, 171);
            this.btnCreatebackup.Name = "btnCreatebackup";
            this.btnCreatebackup.Size = new System.Drawing.Size(276, 58);
            this.btnCreatebackup.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCreatebackup.TabIndex = 4;
            this.btnCreatebackup.Text = "Create Database Backup";
            this.btnCreatebackup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCreatebackup.UseSelectable = true;
            this.btnCreatebackup.Click += new System.EventHandler(this.btnCreatebackup_Click);
            // 
            // Database_Backup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 250);
            this.Controls.Add(this.btnCreatebackup);
            this.Controls.Add(this.cbxDatabaseName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbxServerName);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(322, 250);
            this.MinimumSize = new System.Drawing.Size(322, 250);
            this.Name = "Database_Backup_Form";
            this.Resizable = false;
            this.Text = "Create Database Backup";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Database_Backup_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbxServerName;
        private MetroFramework.Controls.MetroComboBox cbxDatabaseName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnCreatebackup;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}