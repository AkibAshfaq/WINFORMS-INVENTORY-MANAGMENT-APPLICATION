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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public bool panalsize = true;
        private void button3_Click(object sender, EventArgs e)
        {
            if(!panalsize)
            {
                panel1.Height += 50;
                panalsize = true;
            }
            else
            {
                panel1.Height -= 50;
                panalsize = false; 
            }
        }

        public bool sidebar = true;
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
    }
}
