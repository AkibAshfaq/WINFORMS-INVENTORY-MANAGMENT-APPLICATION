using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        
        private void createaccount_Click(object sender, EventArgs e)
        {
            string Name = name.Text.ToString();
            string Email = email.Text.ToString();
            string Gender = gender.Text.ToString();
            string Password = createpassword.Text.ToString();
            string retype = retypepassword.Text.ToString();

            if (false)   
            {
                MessageBox.Show("Information missing\n All information is required to account creation");
            }
            else if(Password != retype)
            {
                MessageBox.Show("Password Incorrect");
            }

            string querey;
        }
    }
}
