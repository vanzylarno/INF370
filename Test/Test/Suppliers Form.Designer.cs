namespace Test
{
    partial class Suppliers_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewSupplier = new MetroFramework.Controls.MetroButton();
            this.txtSupplierEmailAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtSupplierAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.dgvSuppliers = new MetroFramework.Controls.MetroGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSupplier = new MetroFramework.Controls.MetroButton();
            this.txtSupplierEmailUpdate = new MetroFramework.Controls.MetroTextBox();
            this.txtSupplierAddressUpdate = new MetroFramework.Controls.MetroTextBox();
            this.txtSNameUpdate = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSupplier = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCaptureNewOrder = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewSupplier);
            this.groupBox1.Controls.Add(this.txtSupplierEmailAddress);
            this.groupBox1.Controls.Add(this.txtSupplierAddress);
            this.groupBox1.Controls.Add(this.txtSupplierName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Supplier";
            // 
            // btnAddNewSupplier
            // 
            this.btnAddNewSupplier.Location = new System.Drawing.Point(7, 179);
            this.btnAddNewSupplier.Name = "btnAddNewSupplier";
            this.btnAddNewSupplier.Size = new System.Drawing.Size(265, 61);
            this.btnAddNewSupplier.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddNewSupplier.TabIndex = 3;
            this.btnAddNewSupplier.Text = "Add New Supplier";
            this.btnAddNewSupplier.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddNewSupplier.UseSelectable = true;
            this.btnAddNewSupplier.Click += new System.EventHandler(this.btnAddNewSupplier_Click);
            // 
            // txtSupplierEmailAddress
            // 
            // 
            // 
            // 
            this.txtSupplierEmailAddress.CustomButton.Image = null;
            this.txtSupplierEmailAddress.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtSupplierEmailAddress.CustomButton.Name = "";
            this.txtSupplierEmailAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierEmailAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierEmailAddress.CustomButton.TabIndex = 1;
            this.txtSupplierEmailAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierEmailAddress.CustomButton.UseSelectable = true;
            this.txtSupplierEmailAddress.CustomButton.Visible = false;
            this.txtSupplierEmailAddress.Lines = new string[0];
            this.txtSupplierEmailAddress.Location = new System.Drawing.Point(7, 149);
            this.txtSupplierEmailAddress.MaxLength = 32767;
            this.txtSupplierEmailAddress.Name = "txtSupplierEmailAddress";
            this.txtSupplierEmailAddress.PasswordChar = '\0';
            this.txtSupplierEmailAddress.PromptText = "Please Enter the Supplier\'s Email Address";
            this.txtSupplierEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierEmailAddress.SelectedText = "";
            this.txtSupplierEmailAddress.SelectionLength = 0;
            this.txtSupplierEmailAddress.SelectionStart = 0;
            this.txtSupplierEmailAddress.ShortcutsEnabled = true;
            this.txtSupplierEmailAddress.Size = new System.Drawing.Size(265, 23);
            this.txtSupplierEmailAddress.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierEmailAddress.TabIndex = 2;
            this.txtSupplierEmailAddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSupplierEmailAddress.UseSelectable = true;
            this.txtSupplierEmailAddress.WaterMark = "Please Enter the Supplier\'s Email Address";
            this.txtSupplierEmailAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierEmailAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSupplierAddress
            // 
            // 
            // 
            // 
            this.txtSupplierAddress.CustomButton.Image = null;
            this.txtSupplierAddress.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.txtSupplierAddress.CustomButton.Name = "";
            this.txtSupplierAddress.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txtSupplierAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierAddress.CustomButton.TabIndex = 1;
            this.txtSupplierAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierAddress.CustomButton.UseSelectable = true;
            this.txtSupplierAddress.CustomButton.Visible = false;
            this.txtSupplierAddress.Lines = new string[0];
            this.txtSupplierAddress.Location = new System.Drawing.Point(7, 49);
            this.txtSupplierAddress.MaxLength = 32767;
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.PasswordChar = '\0';
            this.txtSupplierAddress.PromptText = "Please Enter the Supplier\'s Address";
            this.txtSupplierAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierAddress.SelectedText = "";
            this.txtSupplierAddress.SelectionLength = 0;
            this.txtSupplierAddress.SelectionStart = 0;
            this.txtSupplierAddress.ShortcutsEnabled = true;
            this.txtSupplierAddress.Size = new System.Drawing.Size(265, 94);
            this.txtSupplierAddress.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierAddress.TabIndex = 1;
            this.txtSupplierAddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSupplierAddress.UseSelectable = true;
            this.txtSupplierAddress.WaterMark = "Please Enter the Supplier\'s Address";
            this.txtSupplierAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSupplierName
            // 
            // 
            // 
            // 
            this.txtSupplierName.CustomButton.Image = null;
            this.txtSupplierName.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtSupplierName.CustomButton.Name = "";
            this.txtSupplierName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierName.CustomButton.TabIndex = 1;
            this.txtSupplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierName.CustomButton.UseSelectable = true;
            this.txtSupplierName.CustomButton.Visible = false;
            this.txtSupplierName.Lines = new string[0];
            this.txtSupplierName.Location = new System.Drawing.Point(7, 20);
            this.txtSupplierName.MaxLength = 32767;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.PromptText = "Please Enter the Supplier\'s Name";
            this.txtSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.SelectionLength = 0;
            this.txtSupplierName.SelectionStart = 0;
            this.txtSupplierName.ShortcutsEnabled = true;
            this.txtSupplierName.Size = new System.Drawing.Size(265, 23);
            this.txtSupplierName.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierName.TabIndex = 0;
            this.txtSupplierName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSupplierName.UseSelectable = true;
            this.txtSupplierName.WaterMark = "Please Enter the Supplier\'s Name";
            this.txtSupplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.EnableHeadersVisualStyles = false;
            this.dgvSuppliers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSuppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvSuppliers.Location = new System.Drawing.Point(309, 72);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(581, 584);
            this.dgvSuppliers.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvSuppliers.TabIndex = 1;
            this.dgvSuppliers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateSupplier);
            this.groupBox2.Controls.Add(this.txtSupplierEmailUpdate);
            this.groupBox2.Controls.Add(this.txtSupplierAddressUpdate);
            this.groupBox2.Controls.Add(this.txtSNameUpdate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(25, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 246);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Supplier Information";
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(7, 179);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(265, 61);
            this.btnUpdateSupplier.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUpdateSupplier.TabIndex = 3;
            this.btnUpdateSupplier.Text = "Update Supplier";
            this.btnUpdateSupplier.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdateSupplier.UseSelectable = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // txtSupplierEmailUpdate
            // 
            // 
            // 
            // 
            this.txtSupplierEmailUpdate.CustomButton.Image = null;
            this.txtSupplierEmailUpdate.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtSupplierEmailUpdate.CustomButton.Name = "";
            this.txtSupplierEmailUpdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierEmailUpdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierEmailUpdate.CustomButton.TabIndex = 1;
            this.txtSupplierEmailUpdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierEmailUpdate.CustomButton.UseSelectable = true;
            this.txtSupplierEmailUpdate.CustomButton.Visible = false;
            this.txtSupplierEmailUpdate.Lines = new string[0];
            this.txtSupplierEmailUpdate.Location = new System.Drawing.Point(7, 149);
            this.txtSupplierEmailUpdate.MaxLength = 32767;
            this.txtSupplierEmailUpdate.Name = "txtSupplierEmailUpdate";
            this.txtSupplierEmailUpdate.PasswordChar = '\0';
            this.txtSupplierEmailUpdate.PromptText = "Please Enter the Supplier\'s Email Address";
            this.txtSupplierEmailUpdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierEmailUpdate.SelectedText = "";
            this.txtSupplierEmailUpdate.SelectionLength = 0;
            this.txtSupplierEmailUpdate.SelectionStart = 0;
            this.txtSupplierEmailUpdate.ShortcutsEnabled = true;
            this.txtSupplierEmailUpdate.Size = new System.Drawing.Size(265, 23);
            this.txtSupplierEmailUpdate.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierEmailUpdate.TabIndex = 2;
            this.txtSupplierEmailUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSupplierEmailUpdate.UseSelectable = true;
            this.txtSupplierEmailUpdate.WaterMark = "Please Enter the Supplier\'s Email Address";
            this.txtSupplierEmailUpdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierEmailUpdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSupplierAddressUpdate
            // 
            // 
            // 
            // 
            this.txtSupplierAddressUpdate.CustomButton.Image = null;
            this.txtSupplierAddressUpdate.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.txtSupplierAddressUpdate.CustomButton.Name = "";
            this.txtSupplierAddressUpdate.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txtSupplierAddressUpdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierAddressUpdate.CustomButton.TabIndex = 1;
            this.txtSupplierAddressUpdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierAddressUpdate.CustomButton.UseSelectable = true;
            this.txtSupplierAddressUpdate.CustomButton.Visible = false;
            this.txtSupplierAddressUpdate.Lines = new string[0];
            this.txtSupplierAddressUpdate.Location = new System.Drawing.Point(7, 49);
            this.txtSupplierAddressUpdate.MaxLength = 32767;
            this.txtSupplierAddressUpdate.Multiline = true;
            this.txtSupplierAddressUpdate.Name = "txtSupplierAddressUpdate";
            this.txtSupplierAddressUpdate.PasswordChar = '\0';
            this.txtSupplierAddressUpdate.PromptText = "Please Enter the Supplier\'s Address";
            this.txtSupplierAddressUpdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierAddressUpdate.SelectedText = "";
            this.txtSupplierAddressUpdate.SelectionLength = 0;
            this.txtSupplierAddressUpdate.SelectionStart = 0;
            this.txtSupplierAddressUpdate.ShortcutsEnabled = true;
            this.txtSupplierAddressUpdate.Size = new System.Drawing.Size(265, 94);
            this.txtSupplierAddressUpdate.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierAddressUpdate.TabIndex = 1;
            this.txtSupplierAddressUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSupplierAddressUpdate.UseSelectable = true;
            this.txtSupplierAddressUpdate.WaterMark = "Please Enter the Supplier\'s Address";
            this.txtSupplierAddressUpdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierAddressUpdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSNameUpdate
            // 
            // 
            // 
            // 
            this.txtSNameUpdate.CustomButton.Image = null;
            this.txtSNameUpdate.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtSNameUpdate.CustomButton.Name = "";
            this.txtSNameUpdate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSNameUpdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSNameUpdate.CustomButton.TabIndex = 1;
            this.txtSNameUpdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSNameUpdate.CustomButton.UseSelectable = true;
            this.txtSNameUpdate.CustomButton.Visible = false;
            this.txtSNameUpdate.Lines = new string[0];
            this.txtSNameUpdate.Location = new System.Drawing.Point(7, 20);
            this.txtSNameUpdate.MaxLength = 32767;
            this.txtSNameUpdate.Name = "txtSNameUpdate";
            this.txtSNameUpdate.PasswordChar = '\0';
            this.txtSNameUpdate.PromptText = "Please Enter the Supplier\'s Name";
            this.txtSNameUpdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSNameUpdate.SelectedText = "";
            this.txtSNameUpdate.SelectionLength = 0;
            this.txtSNameUpdate.SelectionStart = 0;
            this.txtSNameUpdate.ShortcutsEnabled = true;
            this.txtSNameUpdate.Size = new System.Drawing.Size(265, 23);
            this.txtSNameUpdate.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSNameUpdate.TabIndex = 0;
            this.txtSNameUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSNameUpdate.UseSelectable = true;
            this.txtSNameUpdate.WaterMark = "Please Enter the Supplier\'s Name";
            this.txtSNameUpdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSNameUpdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteSupplier);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(25, 568);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 93);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Supplier";
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(6, 21);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(265, 61);
            this.btnDeleteSupplier.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDeleteSupplier.TabIndex = 3;
            this.btnDeleteSupplier.Text = "Delete Supplier";
            this.btnDeleteSupplier.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteSupplier.UseSelectable = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCaptureNewOrder);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(911, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 597);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Supplier Features";
            // 
            // btnCaptureNewOrder
            // 
            this.btnCaptureNewOrder.Location = new System.Drawing.Point(6, 20);
            this.btnCaptureNewOrder.Name = "btnCaptureNewOrder";
            this.btnCaptureNewOrder.Size = new System.Drawing.Size(265, 61);
            this.btnCaptureNewOrder.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCaptureNewOrder.TabIndex = 4;
            this.btnCaptureNewOrder.Text = "Capture New Order";
            this.btnCaptureNewOrder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCaptureNewOrder.UseSelectable = true;
            this.btnCaptureNewOrder.Click += new System.EventHandler(this.btnCaptureNewOrder_Click);
            // 
            // Suppliers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 691);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.groupBox1);
            this.Name = "Suppliers_Form";
            this.Text = "Suppliers";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Suppliers_Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dgvSuppliers;
        private MetroFramework.Controls.MetroTextBox txtSupplierEmailAddress;
        private MetroFramework.Controls.MetroTextBox txtSupplierAddress;
        private MetroFramework.Controls.MetroTextBox txtSupplierName;
        private MetroFramework.Controls.MetroButton btnAddNewSupplier;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnUpdateSupplier;
        private MetroFramework.Controls.MetroTextBox txtSupplierEmailUpdate;
        private MetroFramework.Controls.MetroTextBox txtSupplierAddressUpdate;
        private MetroFramework.Controls.MetroTextBox txtSNameUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnDeleteSupplier;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnCaptureNewOrder;
    }
}