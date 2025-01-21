using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmaZon
{
    public partial class Adminportal : Form
    {
        public Adminportal()
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
            SqlCommand sqlCommand2 = new SqlCommand("SELECT * from AdminTable WHERE Admin_mail = @email and Admin_pass = @password", connection);
            sqlCommand2.Parameters.AddWithValue("@email", mail.Text);
            sqlCommand2.Parameters.AddWithValue("@password", password.Text);
            DataTable dtbl = new DataTable();
            SqlDataReader sdr = sqlCommand2.ExecuteReader();
            dtbl.Load(sdr);

            if (dtbl.Rows.Count == 1)
            {
                SqlCommand saveid = new SqlCommand("select AID_number from Admintable where Admin_mail = @email and Admin_pass = @password", connection);
                saveid.Parameters.AddWithValue("@email", mail.Text);
                saveid.Parameters.AddWithValue("@password", password.Text);
                int idnum = Convert.ToInt32(saveid.ExecuteScalar());
                connection.Close();
                this.Hide();
                Admin page = new Admin();
                page.Visible = true;
                page.admin_id = idnum;

            }
            else
            {
                MessageBox.Show("Incorrect or not registered");
            }

            connection.Close();
        }

        private void admintouser_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogPage page = new LogPage();
            page.Visible = true;

        }
    }
}
