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
    public partial class Sellercontrol : Form
    {
        public Sellercontrol()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            sellerlogin s = new sellerlogin();
            s.Show();
            this.SetVisibleCore(false);
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" INSERT INTO customer (Id,customer_name,address,phone_number) values ( '" + textBox1.Text.ToString().Trim().Replace("'", "''") + "','" + textBox2.Text.ToString().Trim().Replace("'", "''") + "','" + richTextBox1.Text.ToString().Trim().Replace("'", "''") + "','" + textBox3.Text.ToString().Trim().Replace("'", "''") + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved", "Customer Details");
                con.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                richTextBox1.Text = "";
                textBox3.Text = "";
                customertable();


            }
            catch (Exception)
            {
                MessageBox.Show("try agiain or check the Id");
            }
        }
    }
}
