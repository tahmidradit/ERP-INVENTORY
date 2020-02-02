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
    public partial class salary : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        public salary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into salary(Serial,Employee,Designation,Status,Department)values('" + textBox3.Text + "' , '" + textBox1.Text + "','" + comboBox3.SelectedItem.ToString() + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "')", con);
                    SqlDataAdapter sda2 = new SqlDataAdapter("insert into Approval values('" + textBox2.Text + "' , '" + textBox1.Text + "','" + label1.Text + "')", con);
                    DataTable dt = new DataTable();
                    DataTable dt2 = new DataTable();
                    sda.Fill(dt);
                    sda2.Fill(dt2);
                    MessageBox.Show("Successfully inserted in database !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty !\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch 
            {
                MessageBox.Show("An error occured while inserting data ! Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from salary", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception )
            {
                MessageBox.Show("An error occured while inserting data ! Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update salary set Employee = '" + textBox1.Text + "', Designation = '" + comboBox3.SelectedItem.ToString() + "', Salary = '" + textBox2.Text + "', Status = '" + comboBox1.SelectedItem.ToString() + "' , Department = '" + comboBox2.SelectedItem.ToString() + "' where Serial = '" + textBox3.Text + "'  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Data updated successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch  
            {
                MessageBox.Show("An error occured while updating data !\nPlease try again !" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "" )
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from salary where Serial ='" + textBox3.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully deleted from database !\nPlease refresh database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please reset the text boxes first & put the serial number and try again to delete from database !", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            catch 
            {
                MessageBox.Show("An error occurred while deleting data !\nPlease try again." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from salary", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception )
            {
                MessageBox.Show("An error occured while inserting data ! Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.SelectedItem != null && comboBox3.SelectedItem != null && comboBox2.SelectedItem != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from salary where Serial ='" + textBox3.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully deleted from database !\nPlease refresh database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please reset the text boxes first & put the serial number and try again to delete from database !", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("An error occurred while deleting data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[3].Value.ToString();
                textBox3.Text = row.Cells[0].Value.ToString();
                comboBox1.SelectedItem = row.Cells[4].Value.ToString();
                comboBox2.SelectedItem = row.Cells[5].Value.ToString();
                comboBox3.SelectedItem = row.Cells[2].Value.ToString();

            }
            catch (Exception)
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
