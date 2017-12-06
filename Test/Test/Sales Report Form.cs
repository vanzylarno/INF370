using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using word = Microsoft.Office.Interop.Word;
using System.Data.SqlClient;

namespace Test
{
    public partial class Sales_Report_Form : MetroFramework.Forms.MetroForm
    {
        public Sales_Report_Form()
        {
            InitializeComponent();
        }
        string ItemName;
        string ItemName2;
        string ItemName3;
        int AverageAmountSold;
        decimal AverageRevenueGenerated;
        int NumberSold;
        int TotalRevenue;

        private void Sales_Report_Form_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT ItemName, SUM(ItemQuantity) as NumberSold FROM Sales Group by ItemName";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ItemName = (dr["ItemName"].ToString());
                    NumberSold = Convert.ToInt32((dr["NumberSold"]));

                    chart1.Series["Amount Sold"].Points.AddXY(ItemName, NumberSold);
                }
            }
            dr.Close();
            sqlcon.Close();

            SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "Select SUM(LinePrice) as TotalRevenue FROM Sales";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader r;
            r = sqlcom2.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    TotalRevenue = Convert.ToInt32((r["TotalRevenue"]));
                }
            }
            r.Close();
            sqlcon2.Close();

            lblRevenue.Text = "R" + " " + TotalRevenue.ToString();

            SqlConnection sqlcon3 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon3.Open();
            string cmd3 = "Select ItemName, AVG(ItemQuantity) as AverageNumberSold FROM Sales Group by ItemName";
            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
            SqlDataReader dr3;
            dr3 = sqlcom3.ExecuteReader();
            if (dr3.HasRows)
            {
                while (dr3.Read())
                {
                    ItemName2 = (dr3["ItemName"].ToString());
                    AverageAmountSold = Convert.ToInt32((dr3["AverageNumberSold"]));

                    chart2.Series["Average Amount Sold"].Points.AddXY(ItemName2, AverageAmountSold);
                }
            }
            dr3.Close();
            sqlcon3.Close();

            SqlConnection sqlcon4 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon4.Open();
            string cmd4 = "Select ItemName, AVG(LinePrice) as AverageRevenueMade FROM Sales Group by ItemName";
            SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
            SqlDataReader dr4;
            dr4 = sqlcom4.ExecuteReader();
            if (dr4.HasRows)
            {
                while (dr4.Read())
                {
                    ItemName3 = (dr4["ItemName"].ToString());
                    AverageRevenueGenerated = Convert.ToDecimal((dr4["AverageRevenueMade"]));

                    chart3.Series["Average Revenue Generated"].Points.AddXY(ItemName3, AverageRevenueGenerated);
                }
            }
            dr4.Close();
            sqlcon4.Close();


            int AVGSOLD;
            SqlConnection sqlcon34 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon34.Open();
            string cmd34 = "Select AVG(ItemQuantity) as AverageNumberSold FROM Sales";
            SqlCommand sqlcom34 = new SqlCommand(cmd34, sqlcon34);
            SqlDataReader dr34;
            dr34 = sqlcom34.ExecuteReader();
            if (dr34.HasRows)
            {
                while (dr34.Read())
                {
                    AVGSOLD = Convert.ToInt32((dr34["AverageNumberSold"]));
                    lblAvGSold.Text = AVGSOLD.ToString();
                }
            }
            dr34.Close();
            sqlcon34.Close();

            decimal AvgRev;
            SqlConnection sqlcon342 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon342.Open();
            string cmd342 = "Select AVG(LinePrice) as AverageRevenueGenerated FROM Sales";
            SqlCommand sqlcom342 = new SqlCommand(cmd342, sqlcon342);
            SqlDataReader dr342;
            dr342 = sqlcom342.ExecuteReader();
            if (dr342.HasRows)
            {
                while (dr342.Read())
                {
                    AvgRev = Convert.ToDecimal((dr342["AverageRevenueGenerated"]));
                    lblAVGRev.Text = "R" + " " + AvgRev.ToString().TrimStart();
                }
            }
            dr342.Close();
            sqlcon342.Close();

        }

        string Details;

        private void documentWriter()
        {
            //Create Word Application
            word.Application wordApp = new word.Application();
            wordApp.Visible = true;

            //Create the Document
            word.Document wordDoc = wordApp.Documents.Add();

            //Create the Heading Parahraph
            word.Paragraph wordPara = wordDoc.Paragraphs.Add();
            wordPara.Range.Text = "Sales Report";
            object styleName = "Intense Quote";
            wordPara.Range.set_Style(ref styleName);
            wordPara.Range.InsertParagraphAfter();

            //Create a New Paragraph
            word.Paragraph wordPara2 = wordDoc.Paragraphs.Add();
            wordPara2.Range.Text = "This Document Contains all the required and crucial information regarding Sales made. This information includes the Item Sold Name, Quantity sold and Price per Sale. This will allow users to generate accurate and timely calculations regarding sales figures." +
                "\n" + "The Total Amount of Revenue Generated is: R" + TotalRevenue.ToString() + "\n" + "The Average Amount of Items Sold is:" + " " + lblAvGSold.Text.ToString() + "\n" + "The Average Amount of Revenue Generated is: R" + lblAVGRev.Text.ToString();
            object styleName2 = "Subtle Emphasis";
            wordPara2.Range.set_Style(ref styleName2);
            wordPara2.Range.InsertParagraphAfter();

            word.Paragraph wordPara3 = wordDoc.Paragraphs.Add();
            object styleName3 = "List Paragraph";
            wordPara3.Range.set_Style(ref styleName3);
            wordPara3.Range.InsertParagraphAfter();
            wordPara3.Range.Text = Details;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

            //variables;
            string ItemName;
            int ItemQuantity;
            decimal LinePrice;


            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "Select ItemName, ItemQuantity, LinePrice FROM Sales";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ItemName = (reader["ItemName"].ToString());
                    ItemQuantity = Convert.ToInt32((reader["ItemQuantity"]));
                    LinePrice = Convert.ToDecimal((reader["LinePrice"]));
                    Details += "\n" + "Item Name:" + " " + ItemName + "\n" + "Quantity Sold:" + " " + ItemQuantity.ToString() + "\n" + "Sale Price:" + " " + LinePrice.ToString() + "\n";

                }
            }

            reader.Close();
            sqlcon.Close();
            documentWriter();
        }
    }
}
   

