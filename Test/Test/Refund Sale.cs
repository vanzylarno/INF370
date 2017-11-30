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
    public partial class Refund_Sale : MetroFramework.Forms.MetroForm
    {


        public Refund_Sale()
        {
            InitializeComponent();
        }
        int isMember;
        string SelectedCustomer;
        decimal CurrentPoints;

        private void Refund_Sale_Load(object sender, EventArgs e)
        {
            txtItemName.Enabled = false;
            txtQuantityPurchased.Enabled = false;
            txtCostOfSale.Enabled = false;

            
            listBox1.Items.Clear();
            SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon1.Open();
            string Select = "SELECT SaleID FROM Sales";
            SqlCommand sqlcom1 = new SqlCommand(Select, sqlcon1);
            SqlDataReader Dr;
            Dr = sqlcom1.ExecuteReader();
            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    listBox1.Items.Add(Dr["SaleID"].ToString());
                }
            }
            Dr.Close();
            sqlcon1.Close();

            //Add Customers
            SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon2.Open();
            string Select2 = "SELECT CustomerFullName FROM Customers";
            SqlCommand sqlcom2 = new SqlCommand(Select2, sqlcon2);
            SqlDataReader dr2;
            dr2 = sqlcom2.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    cbxCustomerName.Items.Add((dr2["CustomerFullName"].ToString()));
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Query = "SELECT SaleID FROM Sales WHERE SaleID LIKE '" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["SaleID"].ToString());
                }
            }
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Query = "SELECT ItemName, ItemQuantity, LinePrice FROM Sales WHERE SaleID ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                SqlDataReader dr;
                dr = sqlcom.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtItemName.Text = (dr["ItemName"].ToString());
                        txtQuantityPurchased.Text = (dr["ItemQuantity"].ToString());
                        txtCostOfSale.Text = (dr["LinePrice"].ToString());
                    }
                }
                dr.Close();
                sqlcon.Close();

            }
            catch
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Query = "SELECT ItemName, ItemQuantity, LinePrice FROM Sales WHERE SaleID ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                SqlDataReader dr;
                dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtItemName.Text = (dr["ItemName"].ToString());
                        txtQuantityPurchased.Text = (dr["ItemQuantity"].ToString());
                        txtCostOfSale.Text = (dr["LinePrice"].ToString());
                    }
                }
                dr.Close();
                sqlcon.Close();

            }
        }

        private void btnRefundOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Refund this Order?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
               {
                    //Remove Sale
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "DELETE FROM Sales WHERE SaleID ='" + listBox1.Text.ToString() + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    //Refresh Listbox
                    listBox1.Items.Clear();
                    SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon1.Open();
                    string Select = "SELECT SaleID FROM Sales";
                    SqlCommand sqlcom1 = new SqlCommand(Select, sqlcon1);
                    SqlDataReader Dr;
                    Dr = sqlcom1.ExecuteReader();
                    if (Dr.HasRows)
                    {
                        while (Dr.Read())
                        {
                            listBox1.Items.Add(Dr["SaleID"].ToString());
                        }
                    }
                    Dr.Close();
                    sqlcon1.Close();

                    //Get Values Required

                    int QuantityRefunded = Convert.ToInt32(txtQuantityPurchased.Text);
                    int QuantityInStock;
                    int FinalQuantity;
                    string ProductRefunded = txtItemName.Text;

                    SqlConnection sqlcon3 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon3.Open();
                    string Cmd3 = "SELECT ProductQuantityInStock From Products WHERE ProductName ='" + ProductRefunded.ToString() + "'";
                    SqlCommand sqlcom3 = new SqlCommand(Cmd3, sqlcon3);
                    SqlDataReader Reader;
                    Reader = sqlcom3.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            QuantityInStock = Convert.ToInt32((Reader["ProductQuantityInStock"]));
                            FinalQuantity = QuantityInStock + QuantityRefunded;

                            // Update Quantity in Stock
                            SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                            sqlcon2.Open();
                            string Command = "UPDATE Products SET ProductQuantityInStock ='" + FinalQuantity.ToString() + "' WHERE ProductName ='" + ProductRefunded.ToString() + "'";
                            SqlCommand sqlcom2 = new SqlCommand(Command, sqlcon2);
                            sqlcom2.ExecuteNonQuery();
                            sqlcon2.Close();
                        }
                    }
                    Reader.Close();
                    sqlcon3.Close();

                    MetroFramework.MetroMessageBox.Show(this, "The Sale has been Successfully Refunded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    //Deduct Points
                    //Get Membership Status
                    SelectedCustomer = cbxCustomerName.Text;
                    try
                    {

                        SqlConnection sqlcon5 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon5.Open();
                        string GetMembership = "SELECT isMember From Customers Where CustomerFullName ='" + SelectedCustomer.ToString() + "'";
                        SqlCommand sqlcom5 = new SqlCommand(GetMembership, sqlcon5);
                        SqlDataReader dr5;
                        dr5 = sqlcom5.ExecuteReader();
                        if (dr5.HasRows)
                        {
                            while (dr5.Read())
                            {
                                isMember = Convert.ToInt32((dr5["isMember"]));
                                if (isMember == 1)
                                {
                                    try
                                    {
                                        SqlConnection sqlcon6 = new SqlConnection(Globals_Class.ConnectionString);
                                        sqlcon6.Open();
                                        string GetPoints = "SELECT LoyaltyPointsAvailable FROM Customers WHERE CustomerFullName ='" + SelectedCustomer.ToString() + "'";
                                        SqlCommand sqlcom6 = new SqlCommand(GetPoints, sqlcon6);
                                        SqlDataReader dr;
                                        dr = sqlcom6.ExecuteReader();
                                        if (dr.HasRows)
                                        {
                                            while (dr.Read())
                                            {
                                                CurrentPoints = Convert.ToDecimal((dr["LoyaltyPointsAvailable"]));
                                                decimal Cost = Convert.ToDecimal(txtCostOfSale.Text);
                                                decimal PointsReceived;
                                                decimal FinalPoints;
                                                PointsReceived = Cost * Convert.ToDecimal(Globals_Class.loyaltyPointsPercentage);
                                                FinalPoints = CurrentPoints - PointsReceived;

                                                //Add Points
                                                SqlConnection sqlcon9 = new SqlConnection(Globals_Class.ConnectionString);
                                                sqlcon9.Open();
                                                string UpdatePoints = "UPDATE Customers SET LoyaltyPointsAvailable ='" + FinalPoints.ToString() + "' WHERE CustomerFullName ='" + SelectedCustomer.ToString() + "'";
                                                SqlCommand sqlcom9 = new SqlCommand(UpdatePoints, sqlcon9);
                                                sqlcom9.ExecuteNonQuery();
                                                sqlcon9.Close();
                                            }
                                        }
                                        dr.Close();
                                        sqlcon6.Close();

                                    }
                                    catch
                                    {

                                    }

                                }
                                else
                                {

                                }
                            }
                        }
                        dr5.Close();
                        sqlcon5.Close();

                    }
                    catch
                    {
                        isMember = 0;
                    }
                    //Get Current Points
                    



               
                    cbxCustomerName.Text = "";
                    cbxCustomerName.Items.Clear();

                    //Add Customers
                    SqlConnection sqlcon7 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon7.Open();
                    string Select7 = "SELECT CustomerFullName FROM Customers";
                    SqlCommand sqlcom7 = new SqlCommand(Select7, sqlcon7);
                    SqlDataReader dr2;
                    dr2 = sqlcom7.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            cbxCustomerName.Items.Add((dr2["CustomerFullName"].ToString()));
                        }
                    }



                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whislt Connecting to the Database!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

             
            }
        }
    }
}
