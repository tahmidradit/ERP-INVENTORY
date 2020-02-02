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
    public partial class incomestatement : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        public incomestatement()
        {
            InitializeComponent();
        }
        //[Amount for Revenues],[Amount for Expenses]
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" || textBox4.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into incomestatement (Serial,Date,Account) values('" + textBox1.Text + "', '" + dateTimePicker1.Text + "', '" + textBox2.Text + "')", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    
                    if (textBox3.Text != "" && textBox4.Text =="")
                    {
                        SqlDataAdapter sda2 = new SqlDataAdapter("insert into Approval(Amount,Name,SourceName) values('" + textBox3.Text + "','" + textBox2.Text + "','"+ label8.Text +  "')", con);
                        //SqlDataAdapter sda3 = new SqlDataAdapter("insert into Approval(SourceName) values('"+ label6.Text + "')", con);
                        DataTable dt2 = new DataTable();
                        //DataTable dt3 = new DataTable();
                        sda2.Fill(dt2);
                        //sda3.Fill(dt3);
                        MessageBox.Show("Successfully inserted in database !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (textBox3.Text == "" && textBox4.Text != "")
                    {
                        SqlDataAdapter sda3 = new SqlDataAdapter("insert into Approval values('" + textBox4.Text + "','" + textBox2.Text + "', '" + label9.Text + "')", con);
                        DataTable dt3 = new DataTable();
                        sda3.Fill(dt3);
                        MessageBox.Show("Successfully inserted in database !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else { }
                    
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
               
            }
            catch
            {
                MessageBox.Show("An error occured while inserting data !" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from incomestatement", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt ;
                
            }
            catch 
            {
                MessageBox.Show("An error occured inserting data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox1.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from incomestatement where Serial = '" + textBox1.Text + "' ", con);
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
                MessageBox.Show("An error occured while deleting data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update incomestatement set Date= '" + dateTimePicker1.Text + "', Account =  '" + textBox2.Text + "', [Amount for Revenues] = '" + textBox3.Text + "' , [Amount for Expenses] = '" + textBox4.Text + "'  where Serial = '" + textBox1.Text + "'  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh to view latest data.\nPlease refresh to view latest data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox3.Clear();
            textBox2.Clear(); textBox4.Clear();
            dateTimePicker1.Text = null;
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            { 
               SqlDataAdapter sda = new SqlDataAdapter("select sum(RevenuesUSD)-sum(ExpensesUSD) as 'NetIncome' from incomestatement ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            catch 
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox3.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into incomestatement (Serial,Date,Account,[Amount for Revenues],[Amount for Expenses]) values('" + textBox1.Text + "', '" + dateTimePicker1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "')", con);
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
                MessageBox.Show("An error occured while inserting data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update incomestatement set Date= '" + dateTimePicker1.Text + "', Account =  '" + textBox2.Text + "', [Amount for Revenues] = '" + textBox3.Text + "' , [Amount for Expenses] = '" + textBox4.Text + "'  where Serial = '" + textBox1.Text + "'  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh to view latest data.\nPlease refresh to view latest data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Text = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from incomestatement where Serial = '" + textBox1.Text + "' ", con);
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
                MessageBox.Show("An error occured while deleting data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from incomestatement", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("An error occured inserting data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void netIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select sum([Amount for Revenues])-sum([Amount for Expenses]) from incomestatement ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void totalExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(" select sum([Amount for Expenses]) from incomestatement  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                textBox1.Text = row.Cells[0].Value.ToString();
                dateTimePicker1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();

            }
            catch
            {
               
            }
            

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows )
            {
                row.DataGridView.ForeColor = Color.Black;
            }
        }

        private void incomestatement_Load(object sender, EventArgs e)
        {
            
            label2.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;

            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(" select sum(ExpensesUSD) as 'TotalExpenses' from incomestatement  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(" select sum(RevenuesUSD) as 'TotalRevenues' from incomestatement  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
