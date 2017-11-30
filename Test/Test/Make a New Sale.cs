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

namespace Test
{
    public partial class Make_a_New_Sale : MetroFramework.Forms.MetroForm
    {
        public Make_a_New_Sale()
        {
            InitializeComponent();
        }
        string SelectedCustomer;
        int isMember;
        int FinalCost;
        int CurrentCost = 0;
        decimal CurrentPoints;

        private void Make_a_New_Sale_Load(object sender, EventArgs e)
        {
            try
            {


                btnAddToBasket.Enabled = false;
                btnCaptureSale.Enabled = false;
                txtName.Enabled = false;
                txtPrice.Enabled = false;
                txtDescription.Enabled = false;
                txtType.Enabled = false;
                txtQuantity.Enabled = false;
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Query = "SELECT ProductName FROM Products";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                SqlDataReader dr;
                dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBox1.Items.Add((dr["ProductName"].ToString()));
                    }
                }
                dr.Close();
                sqlcon.Close();

                //Add Customers
                SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon2.Open();
                string Select = "SELECT CustomerFullName FROM Customers";
                SqlCommand sqlcom2 = new SqlCommand(Select, sqlcon2);
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
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Query = "SELECT ProductName FROM Products WHERE ProductName LIKE '" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["ProductName"].ToString());
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
                string Command = "SELECT ProductName, ProductType, ProductDescription, ProductQuantityInStock, ProductImage, ProductPrice FROM Products WHERE ProductName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                SqlDataReader dr;
                SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                SqlCommandBuilder sqlcmb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                byte[] image = ((byte[])(ds.Tables[0].Rows[0]["ProductImage"]));
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ms.Close();

                dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtName.Text = (dr["ProductName"].ToString());
                        txtType.Text = (dr["ProductType"].ToString());
                        txtDescription.Text = (dr["ProductDescription"].ToString());
                        txtQuantity.Text = Convert.ToString((dr["ProductQuantityInStock"]));
                        txtPrice.Text = (dr["ProductPrice"].ToString());
                    }
                }
                dr.Close();
                sqlcon.Close();
                btnAddToBasket.Enabled = true;
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Retrieving your Product Information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            if (txtQuantityPurchased.Text == "" || txtName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information Required has been Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Variables
                    string ItemName = txtName.Text;
                    int Quantity = Convert.ToInt32(txtQuantityPurchased.Text);
                    decimal productPrice = Convert.ToDecimal(txtPrice.Text);
                    decimal LinePrice = Quantity * productPrice;
                    
                    int UniqueNumber = GetRandomNumber(1, 999999999); 

                    //Insert Into Basket
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT INTO Basket(ItemName, ItemQuantity, LinePrice, uniqueNumber) VALUES(@ItemName, @ItemQuantity, @LinePrice, @UniqueNumber)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@ItemName", ItemName));
                    sqlcom.Parameters.Add(new SqlParameter("@ItemQuantity", Quantity));
                    sqlcom.Parameters.Add(new SqlParameter("@LinePrice", LinePrice));
                    sqlcom.Parameters.Add(new SqlParameter("@UniqueNumber", UniqueNumber));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    

                    
                    this.dataGridView1.Rows.Add(ItemName, Quantity.ToString(), LinePrice.ToString());
                    btnCaptureSale.Enabled = true;

                    SelectedCustomer = cbxCustomerName.Text;
                    txtQuantityPurchased.Text = "";
                    cbxCustomerName.Enabled = false;
                    

                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Capturing your Sale Information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }

        private void btnCaptureSale_Click(object sender, EventArgs e)
        {
            try
            {
                //Place Order
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {


                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string Command = "INSERT INTO Sales(ItemName, ItemQuantity, LinePrice) VALUES(@ItemName, @ItemQuantity, @LinePrice)";
                    SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                    sqlcom.Parameters.AddWithValue("@ItemName", row.Cells["colItemName"].Value);
                    sqlcom.Parameters.AddWithValue("@ItemQuantity", row.Cells["colItemQuantity"].Value);
                    sqlcom.Parameters.AddWithValue("@LinePrice", row.Cells["colLinePrice"].Value);
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();


                    //Update Stock Quantity
                    int QinStock;
                    int QPurchased;
                    int QLeft;
                    int ProductID;

                    SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon1.Open();
                    string SelectQinStock = "SELECT ProductQuantityInStock, ProductID FROM Products WHERE ProductName ='" + row.Cells["colItemName"].Value.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(SelectQinStock, sqlcon1);
                    SqlDataReader dr;
                    dr = sqlcom2.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while(dr.Read())
                        {
                            QinStock = Convert.ToInt32((dr["ProductQuantityInStock"]));
                            QPurchased = Convert.ToInt32(row.Cells["colItemQuantity"].Value);
                            QLeft = QinStock - QPurchased;
                            ProductID = Convert.ToInt32((dr["ProductID"]));
                        
                                SqlConnection sqlcon3 = new SqlConnection(Globals_Class.ConnectionString);
                                sqlcon3.Open();
                                string cmd = "UPDATE Products SET ProductQuantityInStock ='" + QLeft.ToString() + "' WHERE ProductID ='" + ProductID.ToString() + "'";
                                SqlCommand sqlcom3 = new SqlCommand(cmd, sqlcon3);
                                sqlcom3.ExecuteNonQuery();
                                sqlcon3.Close();
                        }
                    }

                    //Add Loyalty Points
                    //Get Loyalty Membership
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
                    try
                    {
                        SqlConnection sqlcon9 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon9.Open();
                        string GetPoints = "SELECT LoyaltyPointsAvailable FROM Customers WHERE CustomerFullName ='" + SelectedCustomer.ToString() + "'";
                        SqlCommand sqlcom9 = new SqlCommand(GetPoints, sqlcon9);
                        SqlDataReader dr9;
                        dr9 = sqlcom9.ExecuteReader();
                        if (dr9.HasRows)
                        {
                            while (dr9.Read())
                            {
                                CurrentPoints = Convert.ToDecimal((dr9["LoyaltyPointsAvailable"]));
                            }
                        }
                        dr9.Close();
                        sqlcon9.Close();

                    }
                    catch
                    {

                    }


                    if (isMember == 1)
                    {

                        decimal PointsReceived;
                        decimal FinalPoints;
                        PointsReceived = Convert.ToDecimal(row.Cells["colLinePrice"].Value) * Convert.ToDecimal(Globals_Class.loyaltyPointsPercentage);
                        FinalPoints = CurrentPoints + PointsReceived;

                        //Add Points
                        SqlConnection sqlcon66 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon66.Open();
                        string UpdatePoints = "UPDATE Customers SET LoyaltyPointsAvailable ='" + FinalPoints.ToString() + "' WHERE CustomerFullName ='" + SelectedCustomer.ToString() + "'";
                        SqlCommand sqlcom66 = new SqlCommand(UpdatePoints, sqlcon66);
                        sqlcom66.ExecuteNonQuery();
                        sqlcon66.Close();
                    }
                    else
                    {

                    }


                }

                //Calculate Sale Total
                decimal sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                }
              


                MetroFramework.MetroMessageBox.Show(this, "The New Sale was Captured Successfully! The Total Cost of this Sale is:" + "\n" + "R" + " " + sum.ToString() + " " , "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.dataGridView1.Rows.Clear();


                cbxCustomerName.Text = "";
                cbxCustomerName.Enabled = true;


             

            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Capturing your Sale Information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dataGridView1.Rows.Clear();
                cbxCustomerName.Enabled = true;
            }
        }

        private void txtFilter_Click(object sender, EventArgs e)
        {

        }

        private void Basket_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
