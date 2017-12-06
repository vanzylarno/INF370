namespace Test
{
    partial class Sales_Report_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblRevenue = new MetroFramework.Controls.MetroLabel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lblAVGRev = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblAvGSold = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(315, 115);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Amount Sold";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1137, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Amount of Sales per Product";
            this.chart1.Titles.Add(title4);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(354, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Total Revenue Made:";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(499, 80);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(58, 19);
            this.lblRevenue.TabIndex = 2;
            this.lblRevenue.Text = "Revenue";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(315, 421);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Average Amount Sold";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(1137, 300);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            title5.Name = "Title1";
            title5.Text = "Average Amount of Sales per Product";
            this.chart2.Titles.Add(title5);
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(315, 727);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Average Revenue Generated";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(1137, 300);
            this.chart3.TabIndex = 4;
            this.chart3.Text = "chart3";
            title6.Name = "Title1";
            title6.Text = "Average Revenue Generated per Product";
            this.chart3.Titles.Add(title6);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 480);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(147, 187);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Create Detailed Report";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // lblAVGRev
            // 
            this.lblAVGRev.AutoSize = true;
            this.lblAVGRev.Location = new System.Drawing.Point(848, 80);
            this.lblAVGRev.Name = "lblAVGRev";
            this.lblAVGRev.Size = new System.Drawing.Size(58, 19);
            this.lblAVGRev.TabIndex = 7;
            this.lblAVGRev.Text = "Revenue";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(624, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(204, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Average Revenue Made per Sale:";
            // 
            // lblAvGSold
            // 
            this.lblAvGSold.AutoSize = true;
            this.lblAvGSold.Location = new System.Drawing.Point(1278, 80);
            this.lblAvGSold.Name = "lblAvGSold";
            this.lblAvGSold.Size = new System.Drawing.Size(58, 19);
            this.lblAvGSold.TabIndex = 9;
            this.lblAvGSold.Text = "Revenue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(1007, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(265, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Average Amount of Products Sold per Sale:";
            // 
            // Sales_Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 1100);
            this.Controls.Add(this.lblAvGSold);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblAVGRev);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1475, 1100);
            this.Name = "Sales_Report_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.Sales_Report_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel lblAVGRev;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblAvGSold;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}