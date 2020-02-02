using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        public employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null )
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into employeelist(Serial,Name,Designation,Department,Email,Mobile,Joined)values('" + textBox4.Text + "','" + textBox1.Text + "','" + comboBox1.SelectedItem.ToString() + "', '" + comboBox2.SelectedItem.ToString() + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + dateTimePicker1.Text.ToString() + "') ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully added in database !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            catch
            {
                MessageBox.Show("An error occured while adding data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from employeelist ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An error occured while inserting data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from employeelist where Serial = '" + textBox4.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully deleted from database !\nPlease refresh database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please reset the text boxes first & put the serial number and try again to delete from database !", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                
            }
            catch 
            {
                MessageBox.Show("An error occured while deleting data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();dateTimePicker1.Text = null;
            comboBox1.SelectedItem = null; comboBox2.SelectedItem = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update employeelist set Name = '" + textBox1.Text + "', Designation= '" + comboBox1.SelectedItem.ToString() + "', Department = '" + comboBox2.SelectedItem.ToString() + "',Email = '" + textBox2.Text + "' ,Mobile = '" + textBox3.Text + "' ,Joined = '" + dateTimePicker1.Text.ToString() + "' where Serial = '" + textBox4.Text + "' " , con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("An error occured while updating data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into employeelist(Serial,Name,Designation,Department,Email,Mobile,Joined)values('" + textBox4.Text + "','" + textBox1.Text + "','" + comboBox1.SelectedItem.ToString() + "', '" + comboBox2.SelectedItem.ToString() + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + dateTimePicker1.Text.ToString() + "') ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully added in database !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("An error occured while adding data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update employeelist set Name = '" + textBox1.Text + "', Designation= '" + comboBox1.SelectedItem.ToString() + "', Department = '" + comboBox2.SelectedItem.ToString() + "',Email = '" + textBox2.Text + "' ,Mobile = '" + textBox3.Text + "' ,Joined = '" + dateTimePicker1.Text.ToString() + "' where Serial = '" + textBox4.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An error occured while updating data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from employeelist where Serial = '" + textBox4.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully deleted from database !\nPlease refresh database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please reset the text boxes first & put the serial number and try again to delete from database !", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }
            catch
            {
                MessageBox.Show("An error occured while deleting data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); dateTimePicker1.Text = null;
            comboBox1.SelectedItem = null; comboBox2.SelectedItem = null;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from employeelist ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An error occured while inserting data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[4].Value.ToString();
                textBox3.Text = row.Cells[5].Value.ToString();
                textBox4.Text = row.Cells[0].Value.ToString();
                comboBox1.SelectedItem = row.Cells[2].Value.ToString();
                comboBox2.SelectedItem = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[6].Value.ToString();
            }
            catch
            {

            }
           
            

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.DataGridView.ForeColor = Color.Black;
            }
        }
    }
}
