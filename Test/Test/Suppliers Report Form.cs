using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using word = Microsoft.Office.Interop.Word;

namespace Test
{
    public partial class Suppliers_Report_Form : MetroFramework.Forms.MetroForm
    {
        public Suppliers_Report_Form()
        {
            InitializeComponent();
        }
        int TotalOrdersPerSupplier;
        string SupplierName;
        string OrderedFromName;
        int TotalOrdered;
        private void Suppliers_Report_Form_Load(object sender, EventArgs e)
        {


            //Get Orders Per Supplier
            SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "Select Count(SupplierName) as OrdersPerSupplier, SupplierName From SupplierOrder Group by SupplierName;";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader dr2;
            dr2 = sqlcom2.ExecuteReader();
            if (dr2.HasRows)
            {
                while(dr2.Read())
                {

                    TotalOrdersPerSupplier = Convert.ToInt32((dr2["OrdersPerSupplier"]));
                    SupplierName = (dr2["SupplierName"].ToString());
                    chart1.Series["Total Orders Sent"].Points.AddXY(SupplierName, TotalOrdersPerSupplier);
                    //Get SupplierName

                    
                }
            }
            dr2.Close();
            sqlcon2.Close();

            //get Total Orders Received Per Supplier
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "Select Count(SupplierName) as OrdersReceivedPerSupplier, SupplierName From ReceiveSupplierOrder Group by SupplierName";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    OrderedFromName = (dr["SupplierName"].ToString());
                    TotalOrdered = Convert.ToInt32((dr["OrdersReceivedPerSupplier"]));

                    chart2.Series["Total Orders Received"].Points.AddXY(OrderedFromName, TotalOrdered);
                }
            }
           
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

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
            wordPara.Range.Text = "Suppliers Report";
            object styleName = "Intense Quote";
            wordPara.Range.set_Style(ref styleName);
            wordPara.Range.InsertParagraphAfter();

            //Create a New Paragraph
            word.Paragraph wordPara2 = wordDoc.Paragraphs.Add();
            wordPara2.Range.Text = "This Document contains a detailed Report on all Supplier Orders Sent and Received. It contains the following Crucial Information: Supplier Name, Product Ordered Name, Quantity Ordered, Received Date, Received Status and the Order Cost.";
            object styleName2 = "Subtle Emphasis";
            wordPara2.Range.set_Style(ref styleName2);
            wordPara2.Range.InsertParagraphAfter();

            word.Paragraph wordPara3 = wordDoc.Paragraphs.Add();
            object styleName3 = "List Paragraph";
            wordPara3.Range.set_Style(ref styleName3);
            wordPara3.Range.InsertParagraphAfter();
            wordPara3.Range.Text = Details;






        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            //variables;
            string ProductName;
            int ProductQuantity;
            string SupplierName;
            int ReceivedStatus;
            decimal OrderCost;
            string ReceivedDate;
            string Received;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "Select ProductName, ProductQuantity, SupplierName, ReceivedStatus, OrderCost, ReceivedDate FROM ReceiveSupplierOrder";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProductName = (reader["ProductName"].ToString());
                    ProductQuantity = Convert.ToInt32((reader["ProductQuantity"]));
                    SupplierName = (reader["SupplierName"].ToString());
                    ReceivedStatus = Convert.ToInt32((reader["ReceivedStatus"]));
                    OrderCost = Convert.ToDecimal((reader["OrderCost"]));
                    ReceivedDate = (reader["ReceivedDate"].ToString());
                    if (ReceivedStatus == 1)
                    {
                        Received = "Yes";
                    }
                    else
                    {
                        Received = "No";
                    }

                    Details += "\n" + "Product Name:" + " " + ProductName + "\n" + "Quantity Ordered:" + " " + ProductQuantity.ToString() + "\n" + "Supplier Name:" + " " + SupplierName + "\n" + "Received Status:" + " " + Received + "\n" + "Order Cost:" + " " + OrderCost.ToString() + "\n" + "Received Date:" + " " + ReceivedDate.ToString() + "\n";

                }
            }

            reader.Close();
            sqlcon.Close();
            documentWriter();
        }
    }
}
