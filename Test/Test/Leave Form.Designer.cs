namespace Test
{
    partial class Leave_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave_Form));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtStart = new MetroFramework.Controls.MetroTextBox();
            this.txtEnd = new MetroFramework.Controls.MetroTextBox();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 329);
            this.listBox1.TabIndex = 3;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(23, 68);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Please Enter the Employee\'s Name";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(216, 23);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Please Enter the Employee\'s Name";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(277, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Is this Employee on Leave?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Location = new System.Drawing.Point(246, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 217);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(277, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Schedule Leave";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(17, 62);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 40);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Leave Start";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 95);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Leave End";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(17, 117);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 8;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(17, 144);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(200, 53);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Schedule Leave";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "if_checkmark_15191.ico");
            this.imageList1.Images.SetKeyName(1, "if_no_2482.ico");
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(447, 98);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "From:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(463, 138);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(28, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Till:";
            // 
            // txtStart
            // 
            // 
            // 
            // 
            this.txtStart.CustomButton.Image = null;
            this.txtStart.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtStart.CustomButton.Name = "";
            this.txtStart.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStart.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStart.CustomButton.TabIndex = 1;
            this.txtStart.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStart.CustomButton.UseSelectable = true;
            this.txtStart.CustomButton.Visible = false;
            this.txtStart.Lines = new string[0];
            this.txtStart.Location = new System.Drawing.Point(497, 98);
            this.txtStart.MaxLength = 32767;
            this.txtStart.Name = "txtStart";
            this.txtStart.PasswordChar = '\0';
            this.txtStart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStart.SelectedText = "";
            this.txtStart.SelectionLength = 0;
            this.txtStart.SelectionStart = 0;
            this.txtStart.ShortcutsEnabled = true;
            this.txtStart.Size = new System.Drawing.Size(186, 23);
            this.txtStart.TabIndex = 11;
            this.txtStart.UseSelectable = true;
            this.txtStart.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStart.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEnd
            // 
            // 
            // 
            // 
            this.txtEnd.CustomButton.Image = null;
            this.txtEnd.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtEnd.CustomButton.Name = "";
            this.txtEnd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnd.CustomButton.TabIndex = 1;
            this.txtEnd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnd.CustomButton.UseSelectable = true;
            this.txtEnd.CustomButton.Visible = false;
            this.txtEnd.Lines = new string[0];
            this.txtEnd.Location = new System.Drawing.Point(497, 138);
            this.txtEnd.MaxLength = 32767;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.PasswordChar = '\0';
            this.txtEnd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnd.SelectedText = "";
            this.txtEnd.SelectionLength = 0;
            this.txtEnd.SelectionStart = 0;
            this.txtEnd.ShortcutsEnabled = true;
            this.txtEnd.Size = new System.Drawing.Size(186, 23);
            this.txtEnd.TabIndex = 12;
            this.txtEnd.UseSelectable = true;
            this.txtEnd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(497, 168);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(186, 54);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return From Leave";
            this.btnReturn.UseSelectable = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Leave_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 433);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtFilter);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(709, 433);
            this.Name = "Leave_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Employee Leave";
            this.Load += new System.EventHandler(this.Leave_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtStart;
        private MetroFramework.Controls.MetroTextBox txtEnd;
        private MetroFramework.Controls.MetroButton btnReturn;
    }
}