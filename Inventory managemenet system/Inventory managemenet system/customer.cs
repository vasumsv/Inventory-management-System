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

namespace Inventory_managemenet_system
{
    public partial class customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Inventory_system.mdf;Integrated Security=True;Connect Timeout=30");
        public customer()
        {
            InitializeComponent();
            customertable();
        }

        //Back button redirected to home page

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.SetVisibleCore(false);


        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" INSERT INTO customer (Id,customer_name,address,phone_number) values ( '" + textBox1.Text.ToString().Trim().Replace("'", "''") + "','" + textBox2.Text.ToString().Trim().Replace("'", "''") + "','" + richTextBox1.Text.ToString().Trim().Replace("'", "''") + "','" + textBox3.Text.ToString().Trim().Replace("'", "''") + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved","Customer Details");
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
        private void customertable()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from customer", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dataGridView1.DataSource = ds.Tables["ss"];
                con.Close();


            }
            catch
            {
                MessageBox.Show("No Record Found");
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            category c = new category();
            c.Show();
            this.SetVisibleCore(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                richTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               



            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE customer SET customer_name='" + textBox2.Text.ToString().Trim().Replace("'", "''") + "',address='" + richTextBox1.Text.ToString().Trim().Replace("'", "''") + "',phone_number='" + textBox3.Text.ToString().Trim().Replace("'", "''") + "' WHERE Id='" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Details Updated Sucessfully");
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                richTextBox1.Text = "";
                textBox3.Text = "";
                customertable();
            }
            catch (Exception)
            {
                MessageBox.Show("update customer","something went wrong");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM customer WHERE Id='" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("customer  details ","Deleted");
                con.Close();
           
                textBox1.Text = "";
                textBox2.Text = "";
                richTextBox1.Text = "";
                textBox3.Text = "";
                customertable();


            }
            catch (Exception)
            {
                MessageBox.Show("Please check the student ID");
            }
        }
    }
}
