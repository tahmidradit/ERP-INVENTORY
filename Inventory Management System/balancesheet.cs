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
    public partial class balancesheet : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        public balancesheet()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from balancesheet ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An unexpected error occured !\nPlease try again !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedItem != null && dateTimePicker1.Text != null )
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into balancesheet(Serial,Date,Account,Category) values ('" + textBox1.Text + "' , '" + dateTimePicker1.Text + "' ,'" + textBox2.Text + "', '" + comboBox1.SelectedItem.ToString() + "')", con);
                    SqlDataAdapter sda2 = new SqlDataAdapter("insert into Approval(Amount,Name,[Source Name]) values ('" + textBox3.Text + "', '" + textBox2.Text + "', '" + label1.Text + "')", con);
                    DataTable dt = new DataTable();
                    DataTable dt2 = new DataTable();
                    sda.Fill(dt);
                    sda2.Fill(dt2);
                    MessageBox.Show("Successfully inserted in database !\nPlease refresh database. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                
            }
            catch
            {
                MessageBox.Show("An error occurred while inserting data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox2.Text == "" && textBox3.Text == "" && textBox1.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from balancesheet where Serial = '" + textBox1.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully deleted from database !\nPlease refresh database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please reset the text boxes and other inputs first if having any data in text boxes & put the serial number and try again to delete from database !", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("An error occurred while deleting data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); comboBox1.SelectedItem = null ; dateTimePicker1.Text = null;
            textBox3.Clear(); textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update balancesheet set Date ='" + dateTimePicker1.Text + "' , Account = '" + textBox2.Text + "' , Category ='" + comboBox1.SelectedItem.ToString() + "' , Amount = '" + textBox3.Text + "'  where Serial = '" + textBox1.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select sum(Amount) from balancesheet", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An error occurred !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        private void loginPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            logininfo bck = new logininfo();
            bck.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update balancesheet set Date ='" + dateTimePicker1.Text + "' , Account = '" + textBox2.Text + "' , Category ='" + comboBox1.SelectedItem.ToString() + "' , Amount = '" + textBox3.Text + "'  where Serial = '" + textBox1.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" && textBox3.Text == "" && comboBox1.SelectedItem != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from balancesheet where Serial = '" + textBox1.Text + "' ", con);
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

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); comboBox1.SelectedItem = null; dateTimePicker1.Text = null;
            textBox3.Clear(); textBox2.Clear();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        private void totalBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select sum(Amount) from balancesheet", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An error occurred !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from balancesheet ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An unexpected error occured !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedItem != null && dateTimePicker1.Text != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into balancesheet(Serial,Date,Account,Category,Amount) values ('" + textBox1.Text + "' , '" + dateTimePicker1.Text + "' , '" + textBox2.Text + "', '" + comboBox1.SelectedItem.ToString() + "', '" + textBox3.Text + "')", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully inserted in database !\nPlease refresh database. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }
            catch
            {
                MessageBox.Show("An error occurred while inserting data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[4].Value.ToString();
                comboBox1.SelectedItem = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[1].Value.ToString();

            }
            catch
            {
                
            }
          
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                r.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void balancesheet_Load(object sender, EventArgs e)
        {
            //  3764
            label3.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
        }
    }
}
