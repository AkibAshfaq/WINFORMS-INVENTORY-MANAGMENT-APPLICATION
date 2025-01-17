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
    public partial class LogPage : Form
    {
        public LogPage()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {   
            if(name.Text.ToString() == "admin" && password.Text.ToString() == "admin")
            {
                this.Hide();
                HomePage page = new HomePage();
                page.Visible = true;
                
            }
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
