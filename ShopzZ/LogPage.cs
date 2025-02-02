using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AmaZon
{
    public partial class LogPage : Form
    {
        public LogPage()
        {
            InitializeComponent();
            errortag.Visible = false;
        }

        SqlConnection connection;
        public void DBconnection()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\CODE Files\\VS 2022\\ShopzZ\\DB\\DemoDB.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            connection.Open();
        }

        

        // Email Box Design
        private void mail_Enter(object sender, EventArgs e)                                                                                                                                                                                                                                                                                                        
        {
            if (mail.Text == "Email")
            {
                mail.Text = "";
                mail.ForeColor = System.Drawing.Color.Black;
            }


        }

        private void mail_Leave(object sender, EventArgs e)
        {
            if (mail.Text == "")
            {    
                mail.Text = "Email";
                mail.ForeColor = System.Drawing.Color.LightGray;
            }
        }


        // Password Box Design
        private void password_Enter(object sender, EventArgs e)
        {
            
            if (showpass.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }


            if (password.Text == "Password")
            {
                password.Text = "";
                password.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (showpass.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }


            if (password.Text == "")
            {
                password.UseSystemPasswordChar = false;
                password.Text = "Password";
                password.ForeColor = System.Drawing.Color.LightGray;
            }
            
        }

        // Log in with DB
        private void login_Click(object sender, EventArgs e)
        {
            string pass = password.Text;
            string email = mail.Text;

            try
            {
                DBconnection();

                // Chaecking if exists or not
                SqlCommand sqlCommand1 = new SqlCommand("SELECT * from BANTABLE WHERE BanUser_mail = @email", connection);
                sqlCommand1.Parameters.AddWithValue("@email", email);
                DataTable dtbl1 = new DataTable();
                SqlDataReader sdr1 = sqlCommand1.ExecuteReader();
                dtbl1.Load(sdr1);

                // Chaecking if exists or not
                SqlCommand sqlCommand2 = new SqlCommand("SELECT * from UserTable WHERE User_mail = @email and User_pass = @password", connection);
                sqlCommand2.Parameters.AddWithValue("@email", email);
                sqlCommand2.Parameters.AddWithValue("@password", pass);
                DataTable dtbl2 = new DataTable();
                SqlDataReader sdr2 = sqlCommand2.ExecuteReader();
                dtbl2.Load(sdr2);
            

                if (dtbl2.Rows.Count == 1 && dtbl1.Rows.Count ==0)
                {
                    {
                        SqlCommand saveid = new SqlCommand("select UID_number from usertable where user_mail = @email and user_pass = @password", connection);
                        saveid.Parameters.AddWithValue("@email", mail.Text);
                        saveid.Parameters.AddWithValue("@password", password.Text);
                        int idnum = Convert.ToInt32(saveid.ExecuteScalar());
                        connection.Close();
                        this.Hide();
                        HomePage page = new HomePage();
                        page.userid = idnum;
                        page.Visible = true; 
                    }
                }
                else
                {
                     errortag.Visible = true;
                     errortag.Text = "Invalid Credential";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Log in check not working");
            }
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            
        }

        public bool show_button = false;
        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void createaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreatePage create = new CreatePage();
            create.Visible = true;
        }
    }
}
