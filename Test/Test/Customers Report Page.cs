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
    public partial class Customers_Report_Page : MetroFramework.Forms.MetroForm
    {
        public Customers_Report_Page()
        {
            InitializeComponent();
        }

        string CustomerName;
        decimal LoyaltyPA;

        private void Customers_Report_Page_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT CustomerFullName, LoyaltyPointsAvailable FROM Customers";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    CustomerName = (reader["CustomerFullName"].ToString());
                    LoyaltyPA = Convert.ToDecimal((reader["LoyaltyPointsAvailable"]));

                    chart1.Series["Loyalty Points Available"].Points.AddXY(CustomerName, LoyaltyPA);
                    chart2.Series["Loyalty Points Available"].Points.AddXY(CustomerName, LoyaltyPA);
                }
            }
            reader.Close();
            sqlcon.Close();

        }

        string Details;
        int TotalLoyaltyPoints;

        private void documentWriter()
        {
            //Create Word Application
            word.Application wordApp = new word.Application();
            wordApp.Visible = true;

            //Create the Document
            word.Document wordDoc = wordApp.Documents.Add();

            //Create the Heading Parahraph
            word.Paragraph wordPara = wordDoc.Paragraphs.Add();
            wordPara.Range.Text = "Customer Report";
            object styleName = "Intense Quote";
            wordPara.Range.set_Style(ref styleName);
            wordPara.Range.InsertParagraphAfter();

            //Create a New Paragraph
            word.Paragraph wordPara2 = wordDoc.Paragraphs.Add();
            wordPara2.Range.Text = "This Document contains all needed information of Customers registered on the System. The information captured includes, The Customer's Name, Phone Number, Email Address, Date of Birth, if the Customer is a Member and the Loyalty Points the Customer has Available." + "\n" + " The Total amount of Loyalty Points Available on the System is:" + " " + TotalLoyaltyPoints.ToString();
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
            string CustomerName;
            string CustomerPhoneNumber;
            string CustomerEmailAddress;
            string CustomerDOB;
            int isMember;
            decimal LoyaltyPointsAvailable;
            string Member;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "Select CustomerFullName, CustomerPhoneNumber, CustomerEmailAddress, CustomerDOB, LoyaltyPointsAvailable, isMember FROM Customers";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CustomerName = (reader["CustomerFullName"].ToString());
                    CustomerPhoneNumber = (reader["CustomerPhoneNumber"].ToString());
                    CustomerEmailAddress = (reader["CustomerEmailAddress"].ToString());
                    CustomerDOB = (reader["CustomerDOB"].ToString());
                    isMember = Convert.ToInt32((reader["isMember"]));
                    LoyaltyPointsAvailable = Convert.ToDecimal((reader["LoyaltyPointsAvailable"]));
                    if(isMember == 1)
                    {
                        Member = "Yes";
                    }
                    else
                    {
                        Member = "No";
                    }

                    Details += "\n" + "Customer Name:" + " " + CustomerName + "\n" + "Phone Number:" + " " + CustomerPhoneNumber + "\n" + "Email Address:" + " " + CustomerEmailAddress + "\n" + "Date of Birth:" + " " + CustomerDOB + "\n" + "Is a Member:" + " " + Member + "\n" + "Loyalty Points Available:" + " " +LoyaltyPointsAvailable.ToString() + "\n";

                }
            }

            reader.Close();
            sqlcon.Close();

            SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "SELECT SUM(LoyaltyPointsAvailable) as TotalPoints FROM Customers";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader dr;
            dr = sqlcom2.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    TotalLoyaltyPoints = Convert.ToInt32((dr["TotalPoints"]));
                }
            }
            dr.Close();
            sqlcon2.Close();
            documentWriter();
        }
    }
}
