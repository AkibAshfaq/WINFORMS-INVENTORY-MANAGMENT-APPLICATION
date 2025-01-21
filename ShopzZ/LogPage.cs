using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AmaZon
{
    public partial class LogPage : Form
    {
        public LogPage()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        public void DBconnection()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\CODE Files\\VS 2022\\ShopzZ\\DB\\DemoDB.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            connection.Open();
        }
        private void login_Click(object sender, EventArgs e)
        {
            DBconnection();
            SqlCommand sqlCommand2 = new SqlCommand("SELECT * from UserTable WHERE User_mail = @email and User_pass = @password", connection);
            sqlCommand2.Parameters.AddWithValue("@email", mail.Text);
            sqlCommand2.Parameters.AddWithValue("@password", password.Text);
            DataTable dtbl = new DataTable();
            SqlDataReader sdr = sqlCommand2.ExecuteReader();
            dtbl.Load(sdr);

            if (dtbl.Rows.Count == 1)
            {
                SqlCommand saveid = new SqlCommand("select UID_number from usertable where user_mail = @email and user_pass = @password", connection);
                saveid.Parameters.AddWithValue("@email", mail.Text);
                saveid.Parameters.AddWithValue("@password", password.Text);
                int idnum = Convert.ToInt32(saveid.ExecuteScalar());
                connection.Close();
                this.Hide();
                HomePage page = new HomePage();
                page.Visible = true;
                page.userid = idnum;

            }
            else
            {
                MessageBox.Show("Incorrect or not registered");
            }

            connection.Close();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreatePage cp1 = new CreatePage();
            cp1.Show();
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminportal adminportal = new Adminportal();
            adminportal.Visible = true;
        }
    }
}
