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
    public partial class Update_a_Supplier_Form : MetroFramework.Forms.MetroForm
    {
        public Update_a_Supplier_Form()
        {
            InitializeComponent();
        }

        string FileLocation;

        private void Update_a_Supplier_Form_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            btnUpdate.Enabled = false;
            listBox1.Items.Clear();
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
                    listBox1.Items.Add(Dr["SupplierName"].ToString());
                }
            }
            Dr.Close();
            sqlcon1.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Query = "SELECT SupplierImage FROM SupplierInforamtion WHERE SupplierName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                SqlCommandBuilder sqlcmb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                sqlcon.Close();
                byte[] image = ((byte[])(ds.Tables[0].Rows[0]["SupplierImage"]));
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ms.Close();

                SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon2.Open();
                string Select = "SELECT SupplierName, SupplierAddress, SupplierEmailAddress FROM SupplierInforamtion WHERE SupplierName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(Select, sqlcon2);
                SqlDataReader myReader;
                myReader = sqlcom2.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        label1.Text = (myReader["SupplierName"].ToString());
                        label2.Text = (myReader["SupplierAddress"].ToString());
                        label3.Text = (myReader["SupplierEmailAddress"].ToString());

                    }
                }
                myReader.Close();
                sqlcon2.Close();
            }
            catch
            {

                SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon2.Open();
                string Select = "SELECT SupplierName, SupplierAddress, SupplierEmailAddress FROM SupplierInforamtion WHERE SupplierName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(Select, sqlcon2);
                SqlDataReader myReader;
                myReader = sqlcom2.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        label1.Text = (myReader["SupplierName"].ToString());
                        label2.Text = (myReader["SupplierAddress"].ToString());
                        label3.Text = (myReader["SupplierEmailAddress"].ToString());

                    }
                }
                myReader.Close();
                sqlcon2.Close();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Images  (*.*)|*.*";
            ofd.Title = "Choose a Supplier Image";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileLocation = ofd.FileName;
                btnUpdate.Enabled = true;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSupplierAddress.Text == "" || txtSupplierEmailAddress.Text == "" || txtSupplierName.Text == "" || FileLocation == "" )
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                DialogResult DialogResult = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update this Supplier?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                    try
                    {


                        string SupplierName = txtSupplierName.Text;
                        string SupplierAddress = txtSupplierAddress.Text;
                        string SupplierEmailAddress = txtSupplierEmailAddress.Text;

                        byte[] image = null;
                        FileStream fs = new FileStream(FileLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        image = br.ReadBytes((int)fs.Length);

                        SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon.Open();
                        string Qyery = "UPDATE SupplierInforamtion SET SupplierName =@SupplierName, SupplierAddress =@SupplierAddress, SupplierEmailAddress =@SupplierEmailAddress, SupplierImage =@SupplierImage WHERE SupplierName ='" + listBox1.Text.ToString() + "'";
                        SqlCommand sqlcom = new SqlCommand(Qyery, sqlcon);
                        sqlcom.Parameters.Add(new SqlParameter("@SupplierName", SupplierName));
                        sqlcom.Parameters.Add(new SqlParameter("@SupplierAddress", SupplierAddress));
                        sqlcom.Parameters.Add(new SqlParameter("@SupplierEmailAddress", SupplierEmailAddress));
                        sqlcom.Parameters.Add(new SqlParameter("@SupplierImage", image));


                        sqlcom.ExecuteNonQuery();
                        sqlcon.Close();

                        MetroFramework.MetroMessageBox.Show(this, "The New Supplier informance is Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                        txtSupplierAddress.Text = "";
                        txtSupplierEmailAddress.Text = "";
                        txtSupplierName.Text = "";
                        FileLocation = "";
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "The New Supplier informance cannot be updated at this time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    }
                   
            }
        }
    }
}
