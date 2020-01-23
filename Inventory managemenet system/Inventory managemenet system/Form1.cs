using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_managemenet_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HOME_Click(object sender, EventArgs e)
        {

        }

        private void seller_Click(object sender, EventArgs e)
        {
            sellerlogin s = new sellerlogin();
            s.Show();
            this.SetVisibleCore(false);
        }

        private void customer_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.Show();
            this.SetVisibleCore(false);
                 
        }
    }
}
