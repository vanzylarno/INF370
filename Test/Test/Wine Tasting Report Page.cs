using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using System.Data.SqlClient;

namespace Test
{
    public partial class Wine_Tasting_Report_Page : MetroFramework.Forms.MetroForm
    {
        public Wine_Tasting_Report_Page()
        {
            InitializeComponent();
        }

        int BookingsMade;
        string Month;

        private void Wine_Tasting_Report_Page_Load(object sender, EventArgs e)
        {
            chart1.Enabled = false;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series["Number of Bookings Made"].Points.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT WineTastingDate, COUNT(WineTastingID) as BookingsMade FROM WineTasting WHERE WineTastingDate LIKE '%" + metroComboBox1.SelectedItem.ToString() + "%' Group by WineTastingDate";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r;
            r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    BookingsMade = Convert.ToInt32((r["BookingsMade"]));
                    Month = (r["WineTastingDate"].ToString());
                    chart1.Series["Number of Bookings Made"].Points.AddXY(Month, BookingsMade);
                    chart1.Enabled = true;                      
                }
            }
            r.Close();
            sqlcon.Close();
            
        }
        string Details;
        int TotalAmountOfBookingsMade;

        private void documentWriter()
        {
            //Create Word Application
            word.Application wordApp = new word.Application();
            wordApp.Visible = true;

            //Create the Document
            word.Document wordDoc = wordApp.Documents.Add();

            //Create the Heading Parahraph
            word.Paragraph wordPara = wordDoc.Paragraphs.Add();
            wordPara.Range.Text = "Wine Tasting Report";
            object styleName = "Intense Quote";
            wordPara.Range.set_Style(ref styleName);
            wordPara.Range.InsertParagraphAfter();

            //Create a New Paragraph
            word.Paragraph wordPara2 = wordDoc.Paragraphs.Add();
            wordPara2.Range.Text = "This Document contains all crucial information concerning made Wine Tasting Bookings. The Information presented includes, The Wine Tasting Date, Time, the Customer's Name who booked the Wine Tasting, the Customer's Phone Number and Email Address as well as the Group Size" +
                "\n" + "The Total Amount of bookings Made is:" + " " + BookingsMade.ToString();
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
            string WineTastingDate;
            string Time;
            string CustomerName;
            string PhoneNumber;
            string EmailAddress;
            int GroupSize;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "Select CustomerFullName, CustomerPhoneNumber, CustomerEmailAddress, PartySize, WineTastingDate, WineTastingTime FROM WineTasting";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CustomerName = (reader["CustomerFullName"].ToString());
                    PhoneNumber = (reader["CustomerPhoneNumber"].ToString());
                    EmailAddress = (reader["CustomerEmailAddress"].ToString());
                    WineTastingDate = (reader["WineTastingDate"].ToString());
                    Time = (reader["WineTastingTime"].ToString());
                    GroupSize = Convert.ToInt32((reader["PartySize"]));
                  

                    Details += "\n" + "Customer Name:" + " " + CustomerName + "\n" + "Phone Number:" + " " + PhoneNumber + "\n" + "Email Address:" + " " + EmailAddress + "\n" + "Wine Tasting Date:" + " " + WineTastingDate + "\n" + "Wine Tasting Time:" + " " + Time + "\n" + "Group Size:" + " " + GroupSize.ToString() + "\n";

                }
            }

            reader.Close();
            sqlcon.Close();

            SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "SELECT COUNT(WineTastingID) as BookingsMade FROM WineTasting";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader dr;
            dr = sqlcom2.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BookingsMade = Convert.ToInt32((dr["BookingsMade"]));
                }
            }
            dr.Close();
            sqlcon2.Close();
            documentWriter();
        }
    }
}
