using System;
using System.Data;
using System.Data.SqlClient;

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

        
        //User ID number
        public int Num()
        {
            DBconnection();
            SqlCommand saveUser = new SqlCommand("select count(user_id) from Usertable");
            DataTable dtbl = new DataTable();
            int id= dtbl.Rows.Count;
            return id + 2;
        }

        
        
        private void createaccount_Click(object sender, EventArgs e)
        {
            string Password = createpassword.Text.ToString();
            string retype = retypepassword.Text.ToString();
 
            if (Password == retype)
            {
                DBconnection();
                SqlCommand saveUser = new SqlCommand("insert into Usertable(user_name,user_mail,user_gender,user_pass) values(@name,@mail,@gender,@pass)", connection);
                saveUser.Parameters.AddWithValue("@name",name.Text);
                saveUser.Parameters.AddWithValue("@mail",email.Text);
                saveUser.Parameters.AddWithValue("@gender",gender.Text);
                saveUser.Parameters.AddWithValue("@pass",createpassword.Text);
                saveUser.ExecuteNonQuery();
               
                SqlCommand saveid = new SqlCommand("select UID_number from usertable where user_mail = @email and user_pass = @password", connection);
                saveid.Parameters.AddWithValue("@email", email.Text);
                saveid.Parameters.AddWithValue("@password", createpassword.Text);
                int idnum = Convert.ToInt32(saveid.ExecuteScalar());
                connection.Close();
                this.Hide();
                HomePage page = new HomePage();
                page.Visible = true;
                page.userid = idnum;
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
