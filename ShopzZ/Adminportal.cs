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
    public partial class Adminportal : Form
    {
        public Adminportal()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (name.Text.ToString() == "admin" && password.Text.ToString() == "admin")
            {
                this.Hide();
                
            }
        }

        private void admintouser_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogPage page = new LogPage();
            page.Show();
        }
    }
}
