using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AmaZon
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            homepagepanel.Visible = true;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        public int userid;
        //Array for adding item
        public string itemarray;


        SqlConnection connection;
        public void DBconnection()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\CODE Files\\VS 2022\\ShopzZ\\DB\\DemoDB.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            connection.Open();
        }

        public void view(int id)
        {


        }


        public bool panalsize = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if(!panalsize)
            {
                panel1.Height += 160;
                panalsize = true;
            }
            else
            {
                panel1.Height -= 160;
                panalsize = false; 
            }
        }

        public bool sidebar = false;
        private void button5_Click(object sender, EventArgs e)
        {
            if(!sidebar)
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

        private void HomeApplience_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;       
            homeappliencespage.Visible = true;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        private void Electronics_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = true;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        private void groceries_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = true;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        private void furniture_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = true;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        private void view1_Click(object sender, EventArgs e)
        {
            
        }

        private void addtocart1_Click(object sender, EventArgs e)
        {
            
        }

        private void home_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = true;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        // profile info sho panel
        private void Profile_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = true;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;

            DBconnection();
            SqlCommand profileinformation = new SqlCommand("select * from usertable where UID_number = @num",connection);
            profileinformation.Parameters.AddWithValue("@num",userid);
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



        private void contactbutton_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = true;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        

        

        private void viewcartbutton_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = true;
            paymentpanel.Visible = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string name =  namebox.Text;
            string mail = mailbox.Text;
            string newpass = newpassbox.Text;
            string confirmpass  = confirmpassbox.Text;
            string currpass = currentpassbox.Text;
            string gender = genderbox.Text;
            string country = countrybox.Text;
            string city = statebox.Text;

            DBconnection();
            SqlCommand saveid = new SqlCommand("select user_pass from usertable where UID_number = @num", connection);
            saveid.Parameters.AddWithValue("@num", userid);
            string idpass = Convert.ToString(saveid.ExecuteScalarAsync());

            if (newpass == confirmpass)
            {
                if (idpass == currpass) 
                {
                    SqlCommand saveUser = new SqlCommand("update usertable set user_name = @name , user_mail = @mail, user_gender = @gender, user_pass = @pass, user_adress_country = @country, user_adress_city = @city ", connection);
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

        private void checkoutbutton_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = true;
        }

        private void visabutton_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = true;
            cashondelivarypanel.Visible = false;
            cardpaypanel.Visible = true;
        }

        private void mastercardbutton_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = true;
            cashondelivarypanel.Visible = false;
            cardpaypanel.Visible = true;
        }

        private void cashbutton_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = true;
            cashondelivarypanel.Visible = true;
            cardpaypanel.Visible = false;
        }

        private void backfromviewcart_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = true;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = false;
            paymentpanel.Visible = false;
        }

        private void backtocart_Click(object sender, EventArgs e)
        {
            homepagepanel.Visible = false;
            homeappliencespage.Visible = false;
            electronicspage.Visible = false;
            furniturepage.Visible = false;
            groceriespage.Visible = false;
            userinfo.Visible = false;
            contactpanel.Visible = false;
            viewcartpanel.Visible = true;
            paymentpanel.Visible = false;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogPage logPage = new LogPage();
            logPage.Visible = true;
        }









    }
}
