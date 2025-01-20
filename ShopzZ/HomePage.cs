using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

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

        //Array for adding item
        public string itemarray; 

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
            string adress = adressbox.Text;

            if(newpass != confirmpass)
            {
                
            }
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
