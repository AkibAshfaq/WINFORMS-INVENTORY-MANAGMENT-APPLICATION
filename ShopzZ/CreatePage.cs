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
    public partial class CreatePage : Form
    {
        public CreatePage()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        public void DBconnection()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\CODE Files\\VS 2022\\ShopzZ\\DB\\DemoDB.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            connection.Open();
        }

        public int id = 1;
        
        private void createaccount_Click(object sender, EventArgs e)
        {
            string Name = name.Text.ToString();
            string Email = email.Text.ToString();
            string Gender = gender.Text.ToString();
            string Password = createpassword.Text.ToString();
            string retype = retypepassword.Text.ToString();

            if (Password == retype)
            {
                id++;
                DBconnection();
                SqlCommand saveUser = new SqlCommand("insert into UserTable(user_id,user_name,user_mail,user_gender,user_pass) values(@id,@name,@mail,@gender,@pass)", connection);
                saveUser.Parameters.AddWithValue("@id", id);
                saveUser.Parameters.AddWithValue("@name",name.Text);
                saveUser.Parameters.AddWithValue("@mail",email.Text);
                saveUser.Parameters.AddWithValue("@gender",gender.Text);
                saveUser.Parameters.AddWithValue("@pass",createpassword.Text);
                saveUser.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Account created");

                this.Hide();
                HomePage page = new HomePage();
                page.Visible = true;
            }
            else
            {
                MessageBox.Show("Retry");
            }

            
        }

        private void backtologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogPage l = new LogPage();
            l.Show();
        }
    }
}
