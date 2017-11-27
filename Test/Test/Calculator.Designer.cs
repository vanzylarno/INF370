namespace Test
{
    partial class Calculator
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
            this.btn1 = new MetroFramework.Controls.MetroButton();
            this.txtResult = new MetroFramework.Controls.MetroTextBox();
            this.btn2 = new MetroFramework.Controls.MetroButton();
            this.btn3 = new MetroFramework.Controls.MetroButton();
            this.btn0 = new MetroFramework.Controls.MetroButton();
            this.btnPunt = new MetroFramework.Controls.MetroButton();
            this.btn6 = new MetroFramework.Controls.MetroButton();
            this.btn5 = new MetroFramework.Controls.MetroButton();
            this.btn4 = new MetroFramework.Controls.MetroButton();
            this.btnDeel = new MetroFramework.Controls.MetroButton();
            this.btn9 = new MetroFramework.Controls.MetroButton();
            this.btn8 = new MetroFramework.Controls.MetroButton();
            this.btn7 = new MetroFramework.Controls.MetroButton();
            this.btnCE = new MetroFramework.Controls.MetroButton();
            this.btnPlus = new MetroFramework.Controls.MetroButton();
            this.btnMinus = new MetroFramework.Controls.MetroButton();
            this.btnMaal = new MetroFramework.Controls.MetroButton();
            this.btnC = new MetroFramework.Controls.MetroButton();
            this.btnEquals = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn1.Location = new System.Drawing.Point(24, 118);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 73);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseSelectable = true;
            this.btn1.Click += new System.EventHandler(this.PNumber);
            // 
            // txtResult
            // 
            // 
            // 
            // 
            this.txtResult.CustomButton.Image = null;
            this.txtResult.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtResult.CustomButton.Name = "";
            this.txtResult.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtResult.CustomButton.TabIndex = 1;
            this.txtResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtResult.CustomButton.UseSelectable = true;
            this.txtResult.CustomButton.Visible = false;
            this.txtResult.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtResult.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtResult.Lines = new string[] {
        "0"};
            this.txtResult.Location = new System.Drawing.Point(24, 73);
            this.txtResult.MaxLength = 32767;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.PasswordChar = '\0';
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResult.SelectedText = "";
            this.txtResult.SelectionLength = 0;
            this.txtResult.SelectionStart = 0;
            this.txtResult.ShortcutsEnabled = true;
            this.txtResult.Size = new System.Drawing.Size(399, 39);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.UseSelectable = true;
            this.txtResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn2
            // 
            this.btn2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn2.Location = new System.Drawing.Point(24, 197);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 73);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseSelectable = true;
            this.btn2.Click += new System.EventHandler(this.PNumber);
            // 
            // btn3
            // 
            this.btn3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn3.Location = new System.Drawing.Point(23, 276);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 73);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseSelectable = true;
            this.btn3.Click += new System.EventHandler(this.PNumber);
            // 
            // btn0
            // 
            this.btn0.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn0.Location = new System.Drawing.Point(24, 355);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(156, 73);
            this.btn0.TabIndex = 4;
            this.btn0.Text = "0";
            this.btn0.UseSelectable = true;
            this.btn0.Click += new System.EventHandler(this.PNumber);
            // 
            // btnPunt
            // 
            this.btnPunt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPunt.Location = new System.Drawing.Point(186, 355);
            this.btnPunt.Name = "btnPunt";
            this.btnPunt.Size = new System.Drawing.Size(75, 73);
            this.btnPunt.TabIndex = 8;
            this.btnPunt.Text = ".";
            this.btnPunt.UseSelectable = true;
            this.btnPunt.Click += new System.EventHandler(this.PNumber);
            // 
            // btn6
            // 
            this.btn6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn6.Location = new System.Drawing.Point(105, 276);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 73);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseSelectable = true;
            this.btn6.Click += new System.EventHandler(this.PNumber);
            // 
            // btn5
            // 
            this.btn5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn5.Location = new System.Drawing.Point(105, 197);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 73);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseSelectable = true;
            this.btn5.Click += new System.EventHandler(this.PNumber);
            // 
            // btn4
            // 
            this.btn4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn4.Location = new System.Drawing.Point(105, 118);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 73);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseSelectable = true;
            this.btn4.Click += new System.EventHandler(this.PNumber);
            // 
            // btnDeel
            // 
            this.btnDeel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDeel.Location = new System.Drawing.Point(267, 118);
            this.btnDeel.Name = "btnDeel";
            this.btnDeel.Size = new System.Drawing.Size(75, 73);
            this.btnDeel.TabIndex = 12;
            this.btnDeel.Text = "/";
            this.btnDeel.UseSelectable = true;
            this.btnDeel.Click += new System.EventHandler(this.POperator);
            // 
            // btn9
            // 
            this.btn9.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn9.Location = new System.Drawing.Point(186, 276);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 73);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseSelectable = true;
            this.btn9.Click += new System.EventHandler(this.PNumber);
            // 
            // btn8
            // 
            this.btn8.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn8.Location = new System.Drawing.Point(186, 197);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 73);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseSelectable = true;
            this.btn8.Click += new System.EventHandler(this.PNumber);
            // 
            // btn7
            // 
            this.btn7.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn7.Location = new System.Drawing.Point(186, 118);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 73);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseSelectable = true;
            this.btn7.Click += new System.EventHandler(this.PNumber);
            // 
            // btnCE
            // 
            this.btnCE.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCE.Location = new System.Drawing.Point(348, 118);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 73);
            this.btnCE.TabIndex = 16;
            this.btnCE.Text = "CE";
            this.btnCE.UseSelectable = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPlus.Location = new System.Drawing.Point(267, 355);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 73);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseSelectable = true;
            this.btnPlus.Click += new System.EventHandler(this.POperator);
            // 
            // btnMinus
            // 
            this.btnMinus.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMinus.Location = new System.Drawing.Point(267, 276);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 73);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseSelectable = true;
            this.btnMinus.Click += new System.EventHandler(this.POperator);
            // 
            // btnMaal
            // 
            this.btnMaal.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMaal.Location = new System.Drawing.Point(267, 197);
            this.btnMaal.Name = "btnMaal";
            this.btnMaal.Size = new System.Drawing.Size(75, 73);
            this.btnMaal.TabIndex = 13;
            this.btnMaal.Text = "*";
            this.btnMaal.UseSelectable = true;
            this.btnMaal.Click += new System.EventHandler(this.POperator);
            // 
            // btnC
            // 
            this.btnC.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnC.Location = new System.Drawing.Point(348, 197);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 73);
            this.btnC.TabIndex = 17;
            this.btnC.Text = "C";
            this.btnC.UseSelectable = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEquals.Location = new System.Drawing.Point(348, 276);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 152);
            this.btnEquals.TabIndex = 18;
            this.btnEquals.Text = "=";
            this.btnEquals.UseSelectable = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(436, 438);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMaal);
            this.Controls.Add(this.btnDeel);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnPunt);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 438);
            this.Name = "Calculator";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Calculator";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn1;
        private MetroFramework.Controls.MetroTextBox txtResult;
        private MetroFramework.Controls.MetroButton btn2;
        private MetroFramework.Controls.MetroButton btn3;
        private MetroFramework.Controls.MetroButton btn0;
        private MetroFramework.Controls.MetroButton btnPunt;
        private MetroFramework.Controls.MetroButton btn6;
        private MetroFramework.Controls.MetroButton btn5;
        private MetroFramework.Controls.MetroButton btn4;
        private MetroFramework.Controls.MetroButton btnDeel;
        private MetroFramework.Controls.MetroButton btn9;
        private MetroFramework.Controls.MetroButton btn8;
        private MetroFramework.Controls.MetroButton btn7;
        private MetroFramework.Controls.MetroButton btnCE;
        private MetroFramework.Controls.MetroButton btnPlus;
        private MetroFramework.Controls.MetroButton btnMinus;
        private MetroFramework.Controls.MetroButton btnMaal;
        private MetroFramework.Controls.MetroButton btnC;
        private MetroFramework.Controls.MetroButton btnEquals;
    }
}