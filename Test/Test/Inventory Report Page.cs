using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using word = Microsoft.Office.Interop.Word;

namespace Test
{
    public partial class Inventory_Report_Page : MetroFramework.Forms.MetroForm
    {
        public Inventory_Report_Page()
        {
            InitializeComponent();
        }
        string xMember;
        int yMember;
        string xMember2;

        private void Inventory_Report_Page_Load(object sender, EventArgs e)
        {       

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT ProductName, ProductQuantityInStock, ProductType FROM Products";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    xMember = (dr["ProductName"].ToString());
                    yMember = Convert.ToInt32((dr["ProductQuantityInStock"]));
                    xMember2 = (dr["ProductType"].ToString());

                    chart1.Series["Quantity In Stock"].Points.AddXY(xMember, yMember);
                    chart2.Series["Quantity In Stock"].Points.AddXY(xMember, yMember);
                    
                }
            }
            dr.Close();
            sqlcon.Close();


        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        string Details;
        int TotalQinStock;

        private void documentWriter()
        {
            //Create Word Application
            word.Application wordApp = new word.Application();
            wordApp.Visible = true;

            //Create the Document
            word.Document wordDoc = wordApp.Documents.Add();

            //Create the Heading Parahraph
            word.Paragraph wordPara = wordDoc.Paragraphs.Add();
            wordPara.Range.Text = "Inventory Report";
            object styleName = "Intense Quote";
            wordPara.Range.set_Style(ref styleName);
            wordPara.Range.InsertParagraphAfter();

            //Create a New Paragraph
            word.Paragraph wordPara2 = wordDoc.Paragraphs.Add();
            wordPara2.Range.Text = "This document contains a full detailed Report on all the products and their related information stored in the database. The Information reported on with this Report is the Product Name, Product Type, and the Quantity of the Product in Stock as well as the Product's Price." + "\n" + "The Total Quantity of Products in Stock is:"+ " " + TotalQinStock.ToString();
            object styleName2 = "Subtle Emphasis";
            wordPara2.Range.set_Style(ref styleName2);
            wordPara2.Range.InsertParagraphAfter();

            word.Paragraph wordPara3 = wordDoc.Paragraphs.Add();
            object styleName3 = "List Paragraph";
            wordPara3.Range.set_Style(ref styleName3);
            wordPara3.Range.InsertParagraphAfter();
            wordPara3.Range.Text = Details;
            
         
           

           
            
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //variables;
            string ProductName;
            string ProductType;
            int ProductQuantityInStock;
            decimal ProductPrice;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "Select ProductName, ProductType, ProductQuantityInStock, ProductPrice FROM Products";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    ProductName = (reader["ProductName"].ToString());
                    ProductType = (reader["ProductType"].ToString());
                    ProductQuantityInStock = Convert.ToInt32((reader["ProductQuantityInStock"]));
                    ProductPrice = Convert.ToDecimal((reader["ProductPrice"]));


                    Details += "\n" + "Product Name:"  + " " + ProductName + "\n" + "Product Type:" + " " + ProductType + "\n" + "Quantity in Stock:" + " " + ProductQuantityInStock.ToString() + "\n" + "Price:" + " " + ProductPrice.ToString() + "\n";
                    
                }
            }
            
            reader.Close();
            sqlcon.Close();

            SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "SELECT SUM(ProductQuantityInStock) as Total FROM Products;";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader dr;
            dr = sqlcom2.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    TotalQinStock = Convert.ToInt32((dr["Total"]));
                }
            }
            dr.Close();
            sqlcon2.Close();
            documentWriter();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
