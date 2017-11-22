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
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;


namespace Test
{
    public partial class Send_Supplier_Order : MetroFramework.Forms.MetroForm
    {
        public Send_Supplier_Order()
        {
            InitializeComponent();
        }

        int SelectedSupplierID;
        string SelectedSupplierEmailAddress;
        string SelectedSupplierName;
        int SelectedSupplierOrderProductID;
        string SelectedSupplierOrderProductName;
        int SupplierOrderQuantity;
        int BasketQuantity;
        string BasketItemName;
        DateTime dateTime = new DateTime();
        
        
        

        private void Send_Supplier_Order_Load(object sender, EventArgs e)
        {
            //Load Suppliers

            lbxSuppliers.Items.Clear();
            SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon1.Open();
            string Select = "SELECT SupplierName FROM SupplierInforamtion";
            SqlCommand sqlcom1 = new SqlCommand(Select, sqlcon1);
            SqlDataReader Dr;
            Dr = sqlcom1.ExecuteReader();
            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    lbxSuppliers.Items.Add(Dr["SupplierName"].ToString());
                }
            }
            Dr.Close();
            sqlcon1.Close();

            //Load Products
            lbxSupplierOrderProducts.Items.Clear();
            SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon2.Open();
            string Select2 = "SELECT SupplierOrderProductName FROM SupplierOrderProduct";
            SqlCommand sqlcom2 = new SqlCommand(Select2, sqlcon2);
            SqlDataReader Dr2;
            Dr2 = sqlcom2.ExecuteReader();
            if (Dr2.HasRows)
            {
                while (Dr2.Read())
                {
                    lbxSupplierOrderProducts.Items.Add(Dr2["SupplierOrderProductName"].ToString());
                }
            }
            Dr2.Close();
            sqlcon2.Close();
        }

        private void CalenderPick_DateSelected(object sender, DateRangeEventArgs e)
        {
           
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            if (txtQuantity.Text == "" || lbxSuppliers.Text == "" || lbxSupplierOrderProducts.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all Information Required has been Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    try
                    {//Get Selected Supplier
                        SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon.Open();
                        string Command = "SELECT SupplierID, SupplierEmailAddress, SupplierName FROM SupplierInforamtion WHERE SupplierName ='" + lbxSuppliers.Text.ToString() + "'";
                        SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                        SqlDataReader Dr;
                        Dr = sqlcom.ExecuteReader();

                        if (Dr.HasRows)
                        {
                            while (Dr.Read())
                            {
                                SelectedSupplierID = Convert.ToInt32((Dr["SupplierID"]));
                                SelectedSupplierEmailAddress = (Dr["SupplierEmailAddress"].ToString());
                                SelectedSupplierName = (Dr["SupplierName"].ToString());
                            }
                        }
                        Dr.Close();
                        sqlcon.Close();

                        //Get Selected Product
                        SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon2.Open();
                        string Command2 = "SELECT SupplierOrderProductID, SupplierOrderProductName FROM SupplierOrderProduct WHERE SupplierOrderProductName ='" + lbxSupplierOrderProducts.Text.ToString() + "'";
                        SqlCommand sqlcom2 = new SqlCommand(Command2, sqlcon2);
                        SqlDataReader dr2;
                        dr2 = sqlcom2.ExecuteReader();

                        if (dr2.HasRows)
                        {
                            while (dr2.Read())
                            {
                                SelectedSupplierOrderProductID = Convert.ToInt32((dr2["SupplierOrderProductID"]));
                                SelectedSupplierOrderProductName = (dr2["SupplierOrderProductName"].ToString());
                            }
                        }
                        dr2.Close();
                        sqlcon2.Close();

                        //Get Quantity and Date
                        SupplierOrderQuantity = Convert.ToInt32(txtQuantity.Text);
                        
                        dateTime = CalenderPick.SelectionStart.Date;

                        //Insert Values into SupplierOrder Table
                        SqlConnection sqlcon3 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon3.Open();
                        string Command3 = "INSERT INTO SupplierOrder(SupplierID, SupplierOrderQuantity, SupplierOrderDate, SupplierOrderProductID) VALUES(@SupplierID, @SupplierOrderQuantity, @SupplierOrderDate, @SupplierOrderProductID)";
                        SqlCommand sqlcom3 = new SqlCommand(Command3, sqlcon3);
                        sqlcom3.Parameters.Add(new SqlParameter("@SupplierID", SelectedSupplierID));
                        sqlcom3.Parameters.Add(new SqlParameter("@SupplierOrderQuantity", SupplierOrderQuantity));
                        sqlcom3.Parameters.Add(new SqlParameter("SupplierOrderDate", dateTime));
                        sqlcom3.Parameters.Add(new SqlParameter("@SupplierOrderProductID", SelectedSupplierOrderProductID));
                        sqlcom3.ExecuteNonQuery();
                        sqlcon3.Close();
                        sqlcon3.Close();

                        //Notify Supplier
                        var fromAddress = new MailAddress("inf370arnovanzyl@gmail.com", "inf370ArnovanZyl");
                        var toAddress = new MailAddress(SelectedSupplierEmailAddress, SelectedSupplierName);
                        const string fromPassword = "Arno1717";
                        const string subject = "New Order";
                        string body = "Dear" + " "  + SelectedSupplierName + "\n"  + "\n" + "We would like to place an order for the following item:" + "\n" + "\n" + SupplierOrderQuantity + " " + "x" + " " + SelectedSupplierOrderProductName + "\n" +  "\n" + "And we would like to receive this order by :" + " " + dateTime + "";

                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                        };

                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                        {
                            smtp.Send(message);
                        }
                            MetroFramework.MetroMessageBox.Show(this, "The New Supplier Order was Captured Successfully and the Supplier has been notified of the Order!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "The New Supplier Order was not captured due to the Supplier not being Notified!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "The New Order Could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lblHelpPress_Click(object sender, EventArgs e)
        {
            Send_a_Supplier_Order_Help_Page myform = new Send_a_Supplier_Order_Help_Page();
            myform.ShowDialog();
            lbxSuppliers.Items.Clear();
            lbxSupplierOrderProducts.Items.Clear();

            //Load Suppliers

            lbxSuppliers.Items.Clear();
            SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon1.Open();
            string Select = "SELECT SupplierName FROM SupplierInforamtion";
            SqlCommand sqlcom1 = new SqlCommand(Select, sqlcon1);
            SqlDataReader Dr;
            Dr = sqlcom1.ExecuteReader();
            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    lbxSuppliers.Items.Add(Dr["SupplierName"].ToString());
                }
            }
            Dr.Close();
            sqlcon1.Close();

            //Load Products
            lbxSupplierOrderProducts.Items.Clear();
            SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon2.Open();
            string Select2 = "SELECT SupplierOrderProductName FROM SupplierOrderProduct";
            SqlCommand sqlcom2 = new SqlCommand(Select2, sqlcon2);
            SqlDataReader Dr2;
            Dr2 = sqlcom2.ExecuteReader();
            if (Dr2.HasRows)
            {
                while (Dr2.Read())
                {
                    lbxSupplierOrderProducts.Items.Add(Dr2["SupplierOrderProductName"].ToString());
                }
            }
            Dr2.Close();
            sqlcon2.Close();
        }

    }
}
