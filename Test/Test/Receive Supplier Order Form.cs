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

namespace Test
{
    public partial class Receive_Supplier_Order_Form : MetroFramework.Forms.MetroForm
    {
        public Receive_Supplier_Order_Form()
        {
            InitializeComponent();
        }
        int SupplierOrderID;
        int SupplierID;
        int ProductID;
        int Quantities;
        string ProductName;
        int ProductQuantity;
        int ReceivedStatus;
        
        DateTime datetime = new DateTime();

        private void Receive_Supplier_Order_Form_Load(object sender, EventArgs e)
        {
            //Populate Listbox
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Command = "SELECT SupplierOrderID FROM SupplierOrder";
            SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    lbxSupplierOrders.Items.Add(Reader["SupplierOrderID"]);
                }
            }
        }

        private void lbxSupplierOrders_Click(object sender, EventArgs e)
        {

            try
            {
                pictureBox1.Image = null;
                
                //Load Received Status
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Query = "SELECT ReceivedStatus FROM ReceiveSupplierOrder WHERE SupplierOrderID ='" + lbxSupplierOrders.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                SqlDataReader dr;
                dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        ReceivedStatus = Convert.ToInt32((dr["ReceivedStatus"]));

                        if (ReceivedStatus == 1)
                        {
                            pictureBox1.Image = imageList1.Images[0];
                           
                        }
                        else
                        {
                            pictureBox1.Image = imageList1.Images[1];
                           
                        }
                    }
                }
                else
                {
                    pictureBox1.Image = imageList1.Images[1];
                    
                }

        

                //Get ProductID
                SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon2.Open();
                string Select = "SELECT SupplierOrderProductID FROM SupplierOrder WHERE SupplierOrderID ='" + lbxSupplierOrders.Text.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(Select, sqlcon2);
                SqlDataReader myReader;
                myReader = sqlcom2.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                      
                        //Load Product Name
                        ProductID = Convert.ToInt32((myReader["SupplierOrderProductID"]));

                        SqlConnection sqlcon5 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon5.Open();
                        string Select5 = "SELECT SupplierOrderProductName FROM SupplierOrderProduct WHERE SupplierOrderProductID ='" + ProductID + "'";
                        SqlCommand sqlcom5 = new SqlCommand(Select5, sqlcon5);
                        SqlDataReader myReader5;
                        myReader5 = sqlcom5.ExecuteReader();

                        if (myReader5.HasRows)
                        {
                            while (myReader5.Read())
                            {
                                lblProductOrdered.Text = (myReader5["SupplierOrderProductName"].ToString());
                                ProductName = (myReader5["SupplierOrderProductName"].ToString());

                            }
                        }
                        myReader5.Close();
                        sqlcon5.Close();

                    }
                }
                myReader.Close();
                sqlcon2.Close();



               
                //Load Quantity Ordered, Date Ordered, and SupplierID
                SqlConnection sqlcon3 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon3.Open();
                string Select3 = "SELECT SupplierOrderQuantity, SupplierID, SupplierOrderQuantity FROM SupplierOrder WHERE SupplierOrderID ='" + lbxSupplierOrders.Text.ToString() + "'";
                SqlCommand sqlcom3 = new SqlCommand(Select3, sqlcon3);
                SqlDataReader myReader3;
                myReader3 = sqlcom3.ExecuteReader();

                if (myReader3.HasRows)
                {
                    while (myReader3.Read())
                    {
                        lblQuantityOrdered.Text = (myReader3["SupplierOrderQuantity"].ToString());
                        SupplierID = Convert.ToInt32((myReader3["SupplierID"]));
                        // lblDateOrdered.Text = (myReader3["SupplierOrderDate"].ToString());
                        ProductQuantity = Convert.ToInt32((myReader3["SupplierOrderQuantity"]));
                    }
                }
                myReader3.Close();
                sqlcon3.Close();

                //Load Supplier 
                SqlConnection sqlcon4 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon4.Open();
                string Select4 = "SELECT SupplierName FROM SupplierInforamtion WHERE SupplierID ='" + SupplierID + "'";
                SqlCommand sqlcom4 = new SqlCommand(Select4, sqlcon4);
                SqlDataReader myReader4;
                myReader4 = sqlcom4.ExecuteReader();

                if (myReader4.HasRows)
                {
                    while (myReader4.Read())
                    {
                        lblOrderedFrom.Text = (myReader4["SupplierName"].ToString());
                    }
                }
                myReader4.Close();
                sqlcon4.Close();

            }
            catch
            {
                //Load Received Status
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Query = "SELECT ReceivedStatus FROM ReceiveSupplierOrder WHERE SupplierOrderID ='" + lbxSupplierOrders.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                SqlDataReader dr;
                dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ReceivedStatus = Convert.ToInt32((dr["ReceivedStatus"]));

                        if (ReceivedStatus == 1)
                        {
                            pictureBox1.Image = imageList1.Images[0];
                        }
                        else
                        {
                            pictureBox1.Image = imageList1.Images[1];
                        }
                    }
                }

                //Get ProductID
                SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon2.Open();
                string Select = "SELECT SupplierOrderProductID FROM SupplierOrder WHERE SupplierOrderID ='" + lbxSupplierOrders.Text.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(Select, sqlcon2);
                SqlDataReader myReader;
                myReader = sqlcom2.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        ProductID = Convert.ToInt32((myReader["SupplierOrderProductID"]));
                    }
                }
                myReader.Close();
                sqlcon2.Close();

                //Load Product Name
                SqlConnection sqlcon5 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon5.Open();
                string Select5 = "SELECT SupplierOrderProductName FROM SupplierOrderProduct WHERE SupplierOrderProductID ='" + ProductID + "'";
                SqlCommand sqlcom5 = new SqlCommand(Select5, sqlcon5);
                SqlDataReader myReader5;
                myReader5 = sqlcom5.ExecuteReader();

                if (myReader5.HasRows)
                {
                    while (myReader5.Read())
                    {
                        lblProductOrdered.Text = (myReader5["SupplierOrderProductName"].ToString());
                        ProductName = (myReader5["SupplierOrderProductName"].ToString());
                    }
                }
                myReader5.Close();
                sqlcon5.Close();

                //Load Quantity Ordered, Date Ordered, and SupplierID
                SqlConnection sqlcon3 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon3.Open();
                string Select3 = "SELECT SupplierOrderQuantity, SupplierID, SupplierOrderQuantity FROM SupplierOrder WHERE SupplierOrderID ='" + lbxSupplierOrders.Text.ToString() + "'";
                SqlCommand sqlcom3 = new SqlCommand(Select3, sqlcon3);
                SqlDataReader myReader3;
                myReader3 = sqlcom3.ExecuteReader();

                if (myReader3.HasRows)
                {
                    while (myReader3.Read())
                    {
                        lblQuantityOrdered.Text = (myReader3["SupplierOrderQuantity"].ToString());
                        ProductQuantity = Convert.ToInt32((myReader3["SupplierOrderQuantity"]));
                        SupplierID = Convert.ToInt32((myReader3["SupplierID"]));
                       // lblDateOrdered.Text = (myReader3["SupplierOrderDate"].ToString());
                    }
                }
                myReader3.Close();
                sqlcon3.Close();

                //Load Supplier 
                SqlConnection sqlcon4 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon4.Open();
                string Select4 = "SELECT SupplierName FROM SupplierInforamtion WHERE SupplierID ='" + SupplierID + "'";
                SqlCommand sqlcom4 = new SqlCommand(Select4, sqlcon4);
                SqlDataReader myReader4;
                myReader4 = sqlcom4.ExecuteReader();

                if (myReader4.HasRows)
                {
                    while (myReader4.Read())
                    {
                        lblOrderedFrom.Text = (myReader4["SupplierName"].ToString());
                    }
                }
                myReader4.Close();
                sqlcon4.Close();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


                try
                {
                    decimal Cost = Convert.ToDecimal(txtCost.Text);
                    datetime = monthCalendar1.SelectionStart.Date;
                    SupplierOrderID = Convert.ToInt32(lbxSupplierOrders.Text);
                    int newReceivedStatus = 1;

                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT INTO ReceiveSupplierOrder(SupplierOrderID, SupplierID, ProductName, ProductQuantity, ReceivedDate, OrderCost, ReceivedStatus) VALUES(@SupplierOrderID, @SupplierID, @ProductName, @ProductQuantity, @ReceivedDate, @OrderCost, @ReceivedStatus)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@SupplierOrderID", SupplierOrderID));
                    sqlcom.Parameters.Add(new SqlParameter("@SupplierID", SupplierID));
                    sqlcom.Parameters.Add(new SqlParameter("@ProductName", ProductName));
                    sqlcom.Parameters.Add(new SqlParameter("@ProductQuantity", ProductQuantity));
                    sqlcom.Parameters.Add(new SqlParameter("@ReceivedDate", datetime));
                    sqlcom.Parameters.Add(new SqlParameter("@OrderCost", Cost));
                    sqlcom.Parameters.Add(new SqlParameter("@ReceivedStatus", newReceivedStatus));
                    sqlcom.ExecuteNonQuery();

                    MetroFramework.MetroMessageBox.Show(this, "The Order has been Received Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch
                {

                    MetroFramework.MetroMessageBox.Show(this, "An Error Occured whilst Receiving the Order!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            

        }
    }
}
