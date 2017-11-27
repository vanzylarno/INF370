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
    public partial class Find_a_User : MetroFramework.Forms.MetroForm
    {
        public Find_a_User()
        {
            InitializeComponent();
        }

        private void Find_a_User_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT UserEmailAddress FROM Users";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader["UserEmailAddress"].ToString());
                }
            }
            Reader.Close();
            sqlcon.Close();

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT UserEmailAddress FROM Users WHERE UserEmailAddress LIKE '" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader["UserEmailAddress"].ToString());
                }
            }
            Reader.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string CMD = "SELECT * FROM Users WHERE UserEmailAddress ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                SqlCommandBuilder sqlcmb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);

                byte[] image = ((byte[])(ds.Tables[0].Rows[0]["UserImage"]));
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ms.Close();
                SqlDataReader Reader;
                Reader = sqlcom.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        txtUserName.Text = (Reader["UserName"].ToString());
                        txtPassword.Text = (Reader["UserPassword"].ToString());
                        txtSecurityQ.Text = (Reader["UserSecurityQuestion"].ToString());
                        txtSecurityQuestionAnswer.Text = (Reader["UserSecurityQuestionAnswer"].ToString());
                        txtEmailAddress.Text = (Reader["UserEmailAddress"].ToString());
                    }
                }
                Reader.Close();
                sqlcon.Close();
            }
            catch
            {

                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string CMD = "SELECT * FROM Users WHERE UserEmailAddress ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
                SqlDataReader Reader;
                Reader = sqlcom.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        txtUserName.Text = (Reader["UserName"].ToString());
                        txtPassword.Text = (Reader["UserPassword"].ToString());
                        txtSecurityQ.Text = (Reader["UserSecurityQuestion"].ToString());
                        txtSecurityQuestionAnswer.Text = (Reader["UserSecurityQuestionAnswer"].ToString());
                        txtEmailAddress.Text = (Reader["UserEmailAddress"].ToString());
                    }
                }
                Reader.Close();
                sqlcon.Close();
            }
        }

        private void txtFilter_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
