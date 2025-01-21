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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            Addproductpanel.Visible = false;
            Adminhomepagepanel.Visible = true;
            banpanel.Visible = false;
            dbpanel.Visible = false;
        }

        public int admin_id;

        
        

        SqlConnection connection;
        public void DBconnection()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\CODE Files\\VS 2022\\ShopzZ\\DB\\DemoDB.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            connection.Open();
        }

        private void Logout_Click(object sender, EventArgs e)
        {   
            this.Hide();
            LogPage logPage = new LogPage();
            logPage.Show();
        }

        public void show()
        {
            DBconnection();
            SqlCommand profileinformation = new SqlCommand("select * from admintable where AID_number = @num", connection);
            profileinformation.Parameters.AddWithValue("@num", userid);
            SqlDataReader reader = profileinformation.ExecuteReader();
            while (reader.Read())
            {
                namebox.Text = Convert.ToString(reader.GetValue(2));
                mailbox.Text = Convert.ToString(reader.GetValue(3));
                genderbox.Text = Convert.ToString(reader.GetValue(4));
                adressbox.Text = Convert.ToString(reader.GetValue(6) + " " + reader.GetValue(5));
                countrybox.Text = Convert.ToString(reader.GetValue(5));
                statebox.Text = Convert.ToString(reader.GetValue(6));
            }
            connection.Close();
        }
        
        private void submit_Click(object sender, EventArgs e)
        {   

            string id = productidnum.Text;
            string name = productname.Text;
            int catagorynum = Convert.ToInt32(catagoryselector.Text);
            int ammount = Convert.ToInt32(ammounttoadd.Text);
            string descrip1 = description1add.Text;
            string descrip2 = description2add.Text;
            string descrip3 = description3add.Text;


            DBconnection();
            SqlCommand productsave = new SqlCommand("insert into producttable(product_id,product_name,product_description1,product_description2,product_description3,product_stock,product_catagory_id) " +
                                                           "values(@id,@name,@des1,@des2,@des3,@stock,@catagory) ", connection);
            productsave.Parameters.AddWithValue("@id", id);
            productsave.Parameters.AddWithValue("@name",name);
            productsave.Parameters.AddWithValue("@des1",descrip1);
            productsave.Parameters.AddWithValue("@des2", descrip2);
            productsave.Parameters.AddWithValue("@des3", descrip3);
            productsave.Parameters.AddWithValue("@stock", ammount);
            productsave.Parameters.AddWithValue("catagory", catagorynum);
            productsave.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Saved");

            productidnum.Clear();
            productname.Clear();
            catagoryselector.SelectedValue = 0;
            ammounttoadd.Value = 0;
            description1add.Clear();
            description2add.Clear();
            description3add.Clear();

        }

        private void save_Click(object sender, EventArgs e)
        {
            string name = namebox.Text;
            string mail = mailbox.Text;
            string newpass = newpassbox.Text;
            string confirmpass = confirmpassbox.Text;
            string currpass = currentpassbox.Text;
            string gender = genderbox.Text;
            string country = countrybox.Text;
            string city = statebox.Text;

            mailbox.Enabled = false;

            DBconnection();
            SqlCommand saveid = new SqlCommand("select user_pass from admintable where AID_number = @num", connection);
            saveid.Parameters.AddWithValue("@num", admin_id);
            string idpass = Convert.ToString(saveid.ExecuteScalarAsync());

            if (newpass == confirmpass)
            {
                if (idpass == currpass)
                {
                    SqlCommand saveUser = new SqlCommand("update admintable set user_name = @name , user_mail = @mail, user_gender = @gender, user_pass = @pass, user_adress_country = @country, user_adress_city = @city ", connection);
                    saveUser.Parameters.AddWithValue("@name", name);
                    saveUser.Parameters.AddWithValue("@mail", mail);
                    saveUser.Parameters.AddWithValue("@gender", gender);
                    saveUser.Parameters.AddWithValue("@pass", newpass);
                    saveUser.Parameters.AddWithValue("@country", country);
                    saveUser.Parameters.AddWithValue("@city", city);
                    saveUser.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Current password doesn't match");
                }
            }
            else
            {
                MessageBox.Show("New password doesn't match");
            }
            connection.Close();
        }

        private void tohome_Click(object sender, EventArgs e)
        {
            Addproductpanel.Visible = false;
            Adminhomepagepanel.Visible = true;
            banpanel.Visible = false;
            dbpanel.Visible = false;
        }

        private void tobanbutton_Click(object sender, EventArgs e)
        {
            Addproductpanel.Visible = false;
            Adminhomepagepanel.Visible = false;
            banpanel.Visible = true;
            dbpanel.Visible = false;
        }

        public bool sidebar = false;
        private void menubutton_Click(object sender, EventArgs e)
        {
            if (!sidebar)
            {
                flowLayoutPanel1.Width += 140;
                sidebar = true;
            }
            else
            {
                flowLayoutPanel1.Width -= 140;
                sidebar = false;
            }
        }

        private void toaddproduct_Click(object sender, EventArgs e)
        {
            Addproductpanel.Visible = true;
            Adminhomepagepanel.Visible = false;
            banpanel.Visible = false;
            dbpanel.Visible = false;
        }

        private void UserDetails_Click(object sender, EventArgs e)
        {
            dbpanel.Visible = true;
            Addproductpanel.Visible = false;
            Adminhomepagepanel.Visible = false;
            banpanel.Visible = false;
        }
    }
}
