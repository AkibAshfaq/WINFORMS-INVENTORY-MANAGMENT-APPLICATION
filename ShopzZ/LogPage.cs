using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SqlCommand sqlCommand2 = new SqlCommand("SELECT * from UserTable WHERE  user_mail = @email and user_pass = @password", connection);
            sqlCommand2.Parameters.AddWithValue("@email", mail.Text);
            sqlCommand2.Parameters.AddWithValue("@password", password.Text);
            DataTable dtbl = new DataTable();

            SqlDataAdapter sqlsda = new SqlDataAdapter(sqlCommand2);
            sqlsda.Fill(dtbl);



            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                HomePage page = new HomePage();
                page.Visible = true;

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
            
        }
    }
}
