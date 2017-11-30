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
    public partial class Use_Loyalty_Points : MetroFramework.Forms.MetroForm
    {
        public Use_Loyalty_Points()
        {
            InitializeComponent();
        }

        private void Use_Loyalty_Points_Load(object sender, EventArgs e)
        {
            lblPAvilable.Text = "0";
            panel1.Enabled = true;
            txtFName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtEmailAddress.Enabled = false;
            txtDob.Enabled = false;
            btnUsePoints.Enabled = false;
            panel3.Enabled = false;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT CustomerFullName FROM Customers";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader["CustomerFullName"].ToString());
                }
            }
            Reader.Close();
            sqlcon.Close();
        }


        string SelectedCustomer;
        int isMember;
        int CustomerID;
        string CustomerName;
        string CustomerPnumber;
        string CustomerEmailAddress;
        string CustomerDOB;
        decimal PointsAvailable;
        decimal CurrentPoints;
        decimal LoyaltyPointsAvailable;
        decimal FinalCostAfterPoints;
        decimal pointspoints;
        decimal costIsZero;
        decimal CostAmountz;
        decimal canUsePoints;
        int QinStock;
        int QPurchased;
        int QLeft;
        int ProductID;


        private void Membership()
        {
            //Get Customer Details
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT CustomerID, CustomerFullName, CustomerPhoneNumber, CustomerEmailAddress, CustomerDOB, isMember, LoyaltyPointsAvailable FROM Customers WHERE CustomerFullName ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CustomerID = Convert.ToInt32((reader["CustomerID"]));
                    CustomerName = (reader["CustomerFullName"].ToString());
                    CustomerPnumber = (reader["CustomerPhoneNumber"].ToString());
                    CustomerEmailAddress = (reader["CustomerEmailAddress"].ToString());
                    CustomerDOB = (reader["CustomerDOB"].ToString());
                    isMember = Convert.ToInt32((reader["isMember"]));
                    canUsePoints = Convert.ToDecimal((reader["LoyaltyPointsAvailable"]));

                    txtFName.Text = CustomerName.ToString();
                    txtPhoneNumber.Text = CustomerPnumber;
                    txtEmailAddress.Text = CustomerEmailAddress;
                    txtDob.Text = CustomerDOB;

                    if (isMember == 1)
                    {
                        pictureBox1.Image = imageList1.Images[0];

                    }
                    else
                    {
                        pictureBox1.Image = imageList1.Images[1];
                    }
                    if (canUsePoints > 1)
                    {
                        btnUsePoints.Enabled = true;
                    }
                    else
                    {
                        btnUsePoints.Enabled = false;
                    }
                }
            }
            reader.Close();
            sqlcon.Close();
        }



        private void listBox1_Click_1(object sender, EventArgs e)
        {
            Membership();



            //Get Customer Details
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT CustomerID, CustomerFullName, CustomerPhoneNumber, CustomerEmailAddress, CustomerDOB, isMember, LoyaltyPointsAvailable FROM Customers WHERE CustomerFullName ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CustomerID = Convert.ToInt32((reader["CustomerID"]));
                    CustomerName = (reader["CustomerFullName"].ToString());
                    CustomerPnumber = (reader["CustomerPhoneNumber"].ToString());
                    CustomerEmailAddress = (reader["CustomerEmailAddress"].ToString());
                    CustomerDOB = (reader["CustomerDOB"].ToString());
                    isMember = Convert.ToInt32((reader["isMember"]));
                    PointsAvailable = Convert.ToDecimal((reader["LoyaltyPointsAvailable"]));

                    txtFName.Text = CustomerName.ToString();
                    txtPhoneNumber.Text = CustomerPnumber;
                    txtEmailAddress.Text = CustomerEmailAddress;
                    txtDob.Text = CustomerDOB;
                    lblPAvilable.Text = PointsAvailable.ToString();


                }
            }
            reader.Close();
            sqlcon.Close();
        }

        private void txtFilter_TextChanged_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT CustomerFullName FROM Customers WHERE CustomerFullName LIKE '" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader["CustomerFullName"].ToString());
                }
            }
            Reader.Close();
            sqlcon.Close();
        }



        private void btnUsePoints_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to use your Points?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                panel1.Enabled = false;
                panel3.Enabled = true;

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
                            listBox2.Items.Add((dr["ProductName"].ToString()));
                        }
                    }
                    dr.Close();
                    sqlcon.Close();
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                panel3.Enabled = false;
                panel1.Enabled = true;

            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Query = "SELECT ProductName FROM Products WHERE ProductName LIKE '" + metroTextBox1.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox2.Items.Add(dr["ProductName"].ToString());
                }
            }
            sqlcon.Close();
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Command = "SELECT ProductName, ProductType, ProductDescription, ProductQuantityInStock, ProductImage, ProductPrice FROM Products WHERE ProductName ='" + listBox2.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                SqlDataReader dr;
                SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                SqlCommandBuilder sqlcmb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                byte[] image = ((byte[])(ds.Tables[0].Rows[0]["ProductImage"]));
                MemoryStream ms = new MemoryStream(image);
                pictureBox3.Image = Image.FromStream(ms);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
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
            if (txtQuantityPurchased.Text == "")
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

                    SelectedCustomer = listBox1.Text.ToString();
                    txtQuantityPurchased.Text = "";


                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Capturing your Sale Information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCaptureSale_Click(object sender, EventArgs e)
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
                    while (dr.Read())
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

                //Calculate Sale Total
                decimal sum1 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum1 += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                }

                SqlConnection sqlcon77 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon77.Open();
                string GetPoints = "SELECT LoyaltyPointsAvailable FROM Customers WHERE CustomerFullName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom77 = new SqlCommand(GetPoints, sqlcon77);
                SqlDataReader dr77;
                dr77 = sqlcom77.ExecuteReader();
                if (dr77.HasRows)
                {
                    while (dr77.Read())
                    {
                        LoyaltyPointsAvailable = Convert.ToDecimal((dr77["LoyaltyPointsAvailable"]));
                        FinalCostAfterPoints = sum1 - LoyaltyPointsAvailable;

                        if (FinalCostAfterPoints == 0)
                        {
                            //Update LoyaltyPoints
                            if (LoyaltyPointsAvailable <= sum1)
                            {
                                //set points to zero
                                decimal zero = 0;
                                //set points to zero
                                SqlConnection sqlcon222 = new SqlConnection(Globals_Class.ConnectionString);
                                sqlcon222.Open();
                                string SetToZero = "UPDATE Customers SET LoyaltyPointsAvailable ='" + zero.ToString() + "' WHERE CustomerFullName ='" + SelectedCustomer.ToString() + "'";
                                SqlCommand sqlcom222 = new SqlCommand(SetToZero, sqlcon222);
                                sqlcom222.ExecuteNonQuery();
                                sqlcon222.Close();
                            }
                            else if (LoyaltyPointsAvailable >= sum1)
                            {
                                //Calculate Points
                                pointspoints = LoyaltyPointsAvailable - sum1;
                                SqlConnection sqlcon33 = new SqlConnection(Globals_Class.ConnectionString);
                                sqlcon33.Open();
                                string Calculate = "Update Customers SET LoyaltyPointsAvailable ='" + pointspoints.ToString() + "' WHERE CustomerFullName ='" + SelectedCustomer.ToString() + "'";
                                SqlCommand sqlcom33 = new SqlCommand(Calculate, sqlcon33);
                                sqlcom33.ExecuteNonQuery();
                                sqlcon33.Close();

                            }
                        }
                        else
                        {
                            //Update LoyaltyPoints
                            if (LoyaltyPointsAvailable <= sum1)
                            {
                                decimal zero = 0;
                                //set points to zero
                                SqlConnection sqlcon22 = new SqlConnection(Globals_Class.ConnectionString);
                                sqlcon22.Open();
                                string SetToZero = "UPDATE Customers SET LoyaltyPointsAvailable ='" + zero.ToString() + "' WHERE CustomerFullName ='" + SelectedCustomer.ToString() + "'";
                                SqlCommand sqlcom22 = new SqlCommand(SetToZero, sqlcon22);
                                sqlcom22.ExecuteNonQuery();
                                sqlcon22.Close();
                            }
                            else if (LoyaltyPointsAvailable >= sum1)
                            {
                                //Calculate Points
                                pointspoints = LoyaltyPointsAvailable - sum1;
                                SqlConnection sqlcon33 = new SqlConnection(Globals_Class.ConnectionString);
                                sqlcon33.Open();
                                string Calculate = "Update Customers SET LoyaltyPointsAvailable ='" + pointspoints.ToString() + "' WHERE CustomerFullName ='" + SelectedCustomer.ToString() + "'";
                                SqlCommand sqlcom33 = new SqlCommand(Calculate, sqlcon33);
                                sqlcom33.ExecuteNonQuery();
                                sqlcon33.Close();

                            }

                        }
                    }
                }
            }

            //Calculate Sale Total
            decimal sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }

            if (LoyaltyPointsAvailable <= sum)
            {
                MetroFramework.MetroMessageBox.Show(this, "The New Sale was Captured Successfully! The Total Cost of this Sale is:" + "\n" + "R" + " " + FinalCostAfterPoints.ToString() + " ", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else if (LoyaltyPointsAvailable >= sum)
            {
                decimal ShownAmount = 0;

                MetroFramework.MetroMessageBox.Show(this, "The New Sale was Captured Successfully! The Total Cost of this Sale is:" + "\n" + "R" + " " + ShownAmount.ToString() + " ", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            this.dataGridView1.Rows.Clear();
            panel1.Enabled = true;
            panel3.Enabled = false;
            listBox2.Items.Clear();

        }
    }
}
                  

