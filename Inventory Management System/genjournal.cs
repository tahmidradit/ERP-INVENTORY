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
    public partial class General_Journal : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        public General_Journal()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from gj", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An unexpected error occured" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" &&  textBox4.Text != "" || textBox5.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into gj(Serial,Date,Account,Ref) values('" + textBox1.Text + "','" + dateTimePicker1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (textBox4.Text != "" && textBox5.Text =="")
                    {
                        SqlDataAdapter sda2 = new SqlDataAdapter("insert into Approval values('" + textBox4.Text + "','" + textBox2.Text + "', '" + label8.Text + "')", con);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        MessageBox.Show("Successfully inserted in database !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (textBox4.Text == "" && textBox5.Text != "")
                    {
                        SqlDataAdapter sda2 = new SqlDataAdapter("insert into Approval values('" + textBox5.Text + "','" + textBox2.Text + "', '" + label9.Text + "')", con);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        MessageBox.Show("Successfully inserted in database !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            catch
            {
                MessageBox.Show("Unexpected Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update gj set Date = '" + dateTimePicker1.Text + "', Account = '" + textBox2.Text + "', Ref. = '" + textBox3.Text + "', Debit = '" + textBox4.Text + "', Credit = '" + textBox5.Text + "' where Serial = '" + textBox1.Text + "'  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("An unexpected Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear(); textBox1.Clear();
            dateTimePicker1.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(" delete from gj where Serial = '" + textBox1.Text + "'  ", con);
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
                MessageBox.Show("An unexpected error occured" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            logininfo bck = new logininfo();
            bck.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from gj", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An unexpected error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into gj(Serial,Date,Account,Ref,Debit,Credit) values('" + textBox1.Text + "','" + dateTimePicker1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "' ,'" + textBox4.Text + "', '" + textBox5.Text + "')", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully inserted in database !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("Unexpected Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker1.Text = null;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update from gj set Date = '" + dateTimePicker1.Text + "', Account = '" + textBox2.Text + "', Ref. = '" + textBox3.Text + "', Debit = '" + textBox4.Text + "', Credit = '" + textBox5.Text + "' where Serial = '" + textBox1.Text + "'  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An unexpected Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(" delete from gj where Serial = '" + textBox1.Text + "'  ", con);
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
                MessageBox.Show("An unexpected error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Text = row.Cells[1].Value.ToString();

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
