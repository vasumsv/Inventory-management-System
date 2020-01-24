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
    
    public partial class Sellercontrol : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Inventory_system.mdf;Integrated Security=True;Connect Timeout=30");
        public Sellercontrol()
        {
            InitializeComponent();
            categorytable1();
            categorytable2();
        }

        private void back_Click(object sender, EventArgs e)
        {
            sellerlogin s = new sellerlogin();
            s.Show();
            this.SetVisibleCore(false);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if ("Laptop".Equals(comboBox1.SelectedItem.ToString()))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" INSERT INTO laptop (Id,Laptop_name,laptop_price) values ( '" + richTextBox2.Text.ToString().Trim().Replace("'", "''") + "','" + richTextBox3.Text.ToString().Trim().Replace("'", "''") + "','" + richTextBox1.Text.ToString().Trim().Replace("'", "''") + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved", "Laptop Details");
                    con.Close();

                    richTextBox2.Text = "";
                    richTextBox3.Text = "";
                    comboBox1.Text = "";
                    richTextBox1.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("try agiain or check the Id");
                }
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" INSERT INTO mobile (Id,mobile_name,mobile_price) values ( '" + richTextBox2.Text.ToString().Trim().Replace("'", "''") + "','" + richTextBox3.Text.ToString().Trim().Replace("'", "''") + "','" + richTextBox1.Text.ToString().Trim().Replace("'", "''") + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved", "Mobile Details");
                    con.Close();

                    richTextBox2.Text = "";
                    richTextBox3.Text = "";
                    comboBox1.Text = "";
                    richTextBox1.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("try agiain or check the Id");
                }
            }
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if ("Laptop".Equals(comboBox1.SelectedItem.ToString()))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM laptop WHERE Id='" + richTextBox2.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Laptop  details ", "Deleted");
                    con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Please check the  ID", "category");
                }
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM mobile WHERE Id='" + richTextBox2.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile  details ", "Deleted");
                    con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Please check the  ID", "category");
                }
            }
        }

        private void categorytable1()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from laptop", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dataGridView2.DataSource = ds.Tables["ss"];
                con.Close();


            }
            catch
            {
                MessageBox.Show("No Record Found");
            }
        }
        private void categorytable2()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from mobile", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dataGridView3.DataSource = ds.Tables["ss"];
                con.Close();


            }
            catch
            {
                MessageBox.Show("No Record Found");
            }
        }


        private void update_Click(object sender, EventArgs e)
        {
            if ("Laptop".Equals(comboBox1.SelectedItem.ToString()))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE laptop SET Laptop_name='" + richTextBox3.Text.ToString().Trim().Replace("'", "''") + "',laptop_price='" + richTextBox1.Text.ToString().Trim().Replace("'", "''") + "' WHERE Id='" + richTextBox2.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Laptop Details", " Updated Sucessfully");
                    con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("update Laptop", "something went wrong");
                }
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE mobile SET mobile_name='" + richTextBox3.Text.ToString().Trim().Replace("'", "''") + "',mobile_price='" + richTextBox1.Text.ToString().Trim().Replace("'", "''") + "' WHERE Id='" + richTextBox2.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile Details", " Updated Sucessfully");
                    con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("update Mobile", "something went wrong");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.RowCount > 0)
            {
                richTextBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                richTextBox3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                //  comboBox1.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                richTextBox1.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.RowCount > 0)
            {
                richTextBox2.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                richTextBox3.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
              //  comboBox1.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                richTextBox1.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();

            }
        }
    }
}
