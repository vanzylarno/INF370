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
using System.Net;
using System.Net.Mail;
using System.Web;


namespace Test
{
    public partial class Mailing_Form : MetroFramework.Forms.MetroForm
    {
        public Mailing_Form()
        {
            InitializeComponent();
        }
        string SelectedEmail;
        string FileLocation;

        private void Mailing_Form_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT ContactName FROM EmailContacts";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    metroComboBox1.Items.Add((dr["ContactName"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Find_Contact myform = new Find_Contact();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Add_EmailContact myform = new Add_EmailContact();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Update_a_Contact myform = new Update_a_Contact();
            myform.ShowDialog();

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Delete_a_Contact myform = new Delete_a_Contact();
            myform.ShowDialog();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT EmailAddress FROM EmailContacts WHERE ContactName ='" + metroComboBox1.SelectedItem.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SelectedEmail = (dr["EmailAddress"].ToString());
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileLocation = ofd.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("inf370arnovanzyl@gmail.com");
                    mail.To.Add(SelectedEmail);
                    mail.Subject = txtSubject.Text;
                    mail.Body = txtBody.Text;

                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(FileLocation);
                    mail.Attachments.Add(attachment);

                    smtpServer.Port = 587;
                    smtpServer.Credentials = new System.Net.NetworkCredential("inf370arnovanzyl@gmail.com", "Arno1717");
                    smtpServer.EnableSsl = true;

                    smtpServer.Send(mail);

                    MetroFramework.MetroMessageBox.Show(this, "Email Sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtBody.Text = "";
                    txtSubject.Text = "";
                    metroComboBox1.Text = "";
                }
                catch
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("inf370arnovanzyl@gmail.com");
                    mail.To.Add(SelectedEmail);
                    mail.Subject = txtSubject.Text;
                    mail.Body = txtBody.Text;

                    smtpServer.Port = 587;
                    smtpServer.Credentials = new System.Net.NetworkCredential("inf370arnovanzyl@gmail.com", "Arno1717");
                    smtpServer.EnableSsl = true;

                    smtpServer.Send(mail);

                    MetroFramework.MetroMessageBox.Show(this, "Email Sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtBody.Text = "";
                    txtSubject.Text = "";
                    metroComboBox1.Text = "";
                }
  
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "An Error has Occurred!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void metroComboBox1_Click(object sender, EventArgs e)
        {
            metroComboBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT ContactName FROM EmailContacts";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    metroComboBox1.Items.Add((dr["ContactName"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtSubject_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtBody_Click(object sender, EventArgs e)
        {

        }
    }
}
