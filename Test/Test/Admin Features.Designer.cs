namespace Test
{
    partial class Admin_Features
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestoreDatabase = new MetroFramework.Controls.MetroButton();
            this.btnCreateDatabaseBackup = new MetroFramework.Controls.MetroButton();
            this.btnViewUsers = new MetroFramework.Controls.MetroButton();
            this.dgvSelected = new MetroFramework.Controls.MetroGrid();
            this.ManageSystemUsers = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnUpdateUser = new MetroFramework.Controls.MetroButton();
            this.btnDeleteUser = new MetroFramework.Controls.MetroButton();
            this.btnCreateNewUSer = new MetroFramework.Controls.MetroButton();
            this.txtUserEmailAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtUserSecurityQuestionAnswer = new MetroFramework.Controls.MetroTextBox();
            this.txtUserSecurityQuestion = new MetroFramework.Controls.MetroTextBox();
            this.txtUserPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.ManageSystemUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestoreDatabase);
            this.groupBox1.Controls.Add(this.btnCreateDatabaseBackup);
            this.groupBox1.Controls.Add(this.btnViewUsers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Functions";
            // 
            // btnRestoreDatabase
            // 
            this.btnRestoreDatabase.Location = new System.Drawing.Point(6, 150);
            this.btnRestoreDatabase.Name = "btnRestoreDatabase";
            this.btnRestoreDatabase.Size = new System.Drawing.Size(242, 59);
            this.btnRestoreDatabase.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRestoreDatabase.TabIndex = 2;
            this.btnRestoreDatabase.Text = "Restore Database";
            this.btnRestoreDatabase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRestoreDatabase.UseSelectable = true;
            this.btnRestoreDatabase.Click += new System.EventHandler(this.btnRestoreDatabase_Click);
            // 
            // btnCreateDatabaseBackup
            // 
            this.btnCreateDatabaseBackup.Location = new System.Drawing.Point(6, 85);
            this.btnCreateDatabaseBackup.Name = "btnCreateDatabaseBackup";
            this.btnCreateDatabaseBackup.Size = new System.Drawing.Size(242, 59);
            this.btnCreateDatabaseBackup.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCreateDatabaseBackup.TabIndex = 1;
            this.btnCreateDatabaseBackup.Text = "Create Database Backup";
            this.btnCreateDatabaseBackup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCreateDatabaseBackup.UseSelectable = true;
            this.btnCreateDatabaseBackup.Click += new System.EventHandler(this.btnCreateDatabaseBackup_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Location = new System.Drawing.Point(6, 20);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(242, 59);
            this.btnViewUsers.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnViewUsers.TabIndex = 0;
            this.btnViewUsers.Text = "Manage System Users";
            this.btnViewUsers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnViewUsers.UseSelectable = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // dgvSelected
            // 
            this.dgvSelected.AllowUserToResizeRows = false;
            this.dgvSelected.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSelected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelected.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSelected.EnableHeadersVisualStyles = false;
            this.dgvSelected.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSelected.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvSelected.Location = new System.Drawing.Point(296, 64);
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelected.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSelected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelected.Size = new System.Drawing.Size(728, 521);
            this.dgvSelected.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvSelected.TabIndex = 1;
            this.dgvSelected.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvSelected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelected_CellClick);
            this.dgvSelected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelected_CellContentClick);
            // 
            // ManageSystemUsers
            // 
            this.ManageSystemUsers.Controls.Add(this.metroLabel1);
            this.ManageSystemUsers.Controls.Add(this.btnUpdateUser);
            this.ManageSystemUsers.Controls.Add(this.btnDeleteUser);
            this.ManageSystemUsers.Controls.Add(this.btnCreateNewUSer);
            this.ManageSystemUsers.Controls.Add(this.txtUserEmailAddress);
            this.ManageSystemUsers.Controls.Add(this.txtUserSecurityQuestionAnswer);
            this.ManageSystemUsers.Controls.Add(this.txtUserSecurityQuestion);
            this.ManageSystemUsers.Controls.Add(this.txtUserPassword);
            this.ManageSystemUsers.Controls.Add(this.txtUsername);
            this.ManageSystemUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageSystemUsers.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageSystemUsers.Location = new System.Drawing.Point(1030, 64);
            this.ManageSystemUsers.Name = "ManageSystemUsers";
            this.ManageSystemUsers.Size = new System.Drawing.Size(290, 390);
            this.ManageSystemUsers.TabIndex = 2;
            this.ManageSystemUsers.TabStop = false;
            this.ManageSystemUsers.Text = "Manage System Users";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(7, 214);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Provide New User Info:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.WrapToLine = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(6, 147);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(277, 58);
            this.btnUpdateUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUpdateUser.TabIndex = 7;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdateUser.UseSelectable = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(7, 83);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(277, 58);
            this.btnDeleteUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteUser.UseSelectable = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnCreateNewUSer
            // 
            this.btnCreateNewUSer.Location = new System.Drawing.Point(7, 19);
            this.btnCreateNewUSer.Name = "btnCreateNewUSer";
            this.btnCreateNewUSer.Size = new System.Drawing.Size(277, 58);
            this.btnCreateNewUSer.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCreateNewUSer.TabIndex = 5;
            this.btnCreateNewUSer.Text = "Create New User";
            this.btnCreateNewUSer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCreateNewUSer.UseSelectable = true;
            this.btnCreateNewUSer.Click += new System.EventHandler(this.btnCreateNewUSer_Click);
            this.btnCreateNewUSer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCreateNewUSer_MouseMove);
            // 
            // txtUserEmailAddress
            // 
            // 
            // 
            // 
            this.txtUserEmailAddress.CustomButton.Image = null;
            this.txtUserEmailAddress.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtUserEmailAddress.CustomButton.Name = "";
            this.txtUserEmailAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserEmailAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserEmailAddress.CustomButton.TabIndex = 1;
            this.txtUserEmailAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserEmailAddress.CustomButton.UseSelectable = true;
            this.txtUserEmailAddress.CustomButton.Visible = false;
            this.txtUserEmailAddress.Lines = new string[0];
            this.txtUserEmailAddress.Location = new System.Drawing.Point(6, 352);
            this.txtUserEmailAddress.MaxLength = 32767;
            this.txtUserEmailAddress.Name = "txtUserEmailAddress";
            this.txtUserEmailAddress.PasswordChar = '\0';
            this.txtUserEmailAddress.PromptText = "Enter User Email Address";
            this.txtUserEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserEmailAddress.SelectedText = "";
            this.txtUserEmailAddress.SelectionLength = 0;
            this.txtUserEmailAddress.SelectionStart = 0;
            this.txtUserEmailAddress.ShortcutsEnabled = true;
            this.txtUserEmailAddress.Size = new System.Drawing.Size(278, 23);
            this.txtUserEmailAddress.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserEmailAddress.TabIndex = 4;
            this.txtUserEmailAddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUserEmailAddress.UseSelectable = true;
            this.txtUserEmailAddress.WaterMark = "Enter User Email Address";
            this.txtUserEmailAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserEmailAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserSecurityQuestionAnswer
            // 
            // 
            // 
            // 
            this.txtUserSecurityQuestionAnswer.CustomButton.Image = null;
            this.txtUserSecurityQuestionAnswer.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtUserSecurityQuestionAnswer.CustomButton.Name = "";
            this.txtUserSecurityQuestionAnswer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserSecurityQuestionAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserSecurityQuestionAnswer.CustomButton.TabIndex = 1;
            this.txtUserSecurityQuestionAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserSecurityQuestionAnswer.CustomButton.UseSelectable = true;
            this.txtUserSecurityQuestionAnswer.CustomButton.Visible = false;
            this.txtUserSecurityQuestionAnswer.Lines = new string[0];
            this.txtUserSecurityQuestionAnswer.Location = new System.Drawing.Point(6, 323);
            this.txtUserSecurityQuestionAnswer.MaxLength = 32767;
            this.txtUserSecurityQuestionAnswer.Name = "txtUserSecurityQuestionAnswer";
            this.txtUserSecurityQuestionAnswer.PasswordChar = '\0';
            this.txtUserSecurityQuestionAnswer.PromptText = "Enter User Security Question Answer";
            this.txtUserSecurityQuestionAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserSecurityQuestionAnswer.SelectedText = "";
            this.txtUserSecurityQuestionAnswer.SelectionLength = 0;
            this.txtUserSecurityQuestionAnswer.SelectionStart = 0;
            this.txtUserSecurityQuestionAnswer.ShortcutsEnabled = true;
            this.txtUserSecurityQuestionAnswer.Size = new System.Drawing.Size(278, 23);
            this.txtUserSecurityQuestionAnswer.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserSecurityQuestionAnswer.TabIndex = 3;
            this.txtUserSecurityQuestionAnswer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUserSecurityQuestionAnswer.UseSelectable = true;
            this.txtUserSecurityQuestionAnswer.WaterMark = "Enter User Security Question Answer";
            this.txtUserSecurityQuestionAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserSecurityQuestionAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserSecurityQuestion
            // 
            // 
            // 
            // 
            this.txtUserSecurityQuestion.CustomButton.Image = null;
            this.txtUserSecurityQuestion.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtUserSecurityQuestion.CustomButton.Name = "";
            this.txtUserSecurityQuestion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserSecurityQuestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserSecurityQuestion.CustomButton.TabIndex = 1;
            this.txtUserSecurityQuestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserSecurityQuestion.CustomButton.UseSelectable = true;
            this.txtUserSecurityQuestion.CustomButton.Visible = false;
            this.txtUserSecurityQuestion.Lines = new string[0];
            this.txtUserSecurityQuestion.Location = new System.Drawing.Point(6, 294);
            this.txtUserSecurityQuestion.MaxLength = 32767;
            this.txtUserSecurityQuestion.Name = "txtUserSecurityQuestion";
            this.txtUserSecurityQuestion.PasswordChar = '\0';
            this.txtUserSecurityQuestion.PromptText = "Enter User Security Question";
            this.txtUserSecurityQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserSecurityQuestion.SelectedText = "";
            this.txtUserSecurityQuestion.SelectionLength = 0;
            this.txtUserSecurityQuestion.SelectionStart = 0;
            this.txtUserSecurityQuestion.ShortcutsEnabled = true;
            this.txtUserSecurityQuestion.Size = new System.Drawing.Size(278, 23);
            this.txtUserSecurityQuestion.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserSecurityQuestion.TabIndex = 2;
            this.txtUserSecurityQuestion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUserSecurityQuestion.UseSelectable = true;
            this.txtUserSecurityQuestion.WaterMark = "Enter User Security Question";
            this.txtUserSecurityQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserSecurityQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserPassword
            // 
            // 
            // 
            // 
            this.txtUserPassword.CustomButton.Image = null;
            this.txtUserPassword.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtUserPassword.CustomButton.Name = "";
            this.txtUserPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserPassword.CustomButton.TabIndex = 1;
            this.txtUserPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserPassword.CustomButton.UseSelectable = true;
            this.txtUserPassword.CustomButton.Visible = false;
            this.txtUserPassword.Lines = new string[0];
            this.txtUserPassword.Location = new System.Drawing.Point(6, 265);
            this.txtUserPassword.MaxLength = 32767;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '\0';
            this.txtUserPassword.PromptText = "Enter User Password";
            this.txtUserPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserPassword.SelectedText = "";
            this.txtUserPassword.SelectionLength = 0;
            this.txtUserPassword.SelectionStart = 0;
            this.txtUserPassword.ShortcutsEnabled = true;
            this.txtUserPassword.Size = new System.Drawing.Size(278, 23);
            this.txtUserPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserPassword.TabIndex = 1;
            this.txtUserPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUserPassword.UseSelectable = true;
            this.txtUserPassword.WaterMark = "Enter User Password";
            this.txtUserPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(7, 236);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Enter UserName";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(278, 23);
            this.txtUsername.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Enter UserName";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Admin_Features
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 608);
            this.Controls.Add(this.ManageSystemUsers);
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_Features";
            this.Text = "Admin Features";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Admin_Features_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.ManageSystemUsers.ResumeLayout(false);
            this.ManageSystemUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnViewUsers;
        private MetroFramework.Controls.MetroGrid dgvSelected;
        private System.Windows.Forms.GroupBox ManageSystemUsers;
        private MetroFramework.Controls.MetroTextBox txtUserEmailAddress;
        private MetroFramework.Controls.MetroTextBox txtUserSecurityQuestionAnswer;
        private MetroFramework.Controls.MetroTextBox txtUserSecurityQuestion;
        private MetroFramework.Controls.MetroTextBox txtUserPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnUpdateUser;
        private MetroFramework.Controls.MetroButton btnDeleteUser;
        private MetroFramework.Controls.MetroButton btnCreateNewUSer;
        private MetroFramework.Controls.MetroButton btnCreateDatabaseBackup;
        private MetroFramework.Controls.MetroButton btnRestoreDatabase;
    }
}