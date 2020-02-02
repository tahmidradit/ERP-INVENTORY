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
    public partial class Forecasting : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");

        public Forecasting()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from forecasting ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An unexpected error occured !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && comboBox1.SelectedItem != null )
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into forecasting(Serial,Month,Year)values('" + textBox4.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox2.Text + "') ", con);
                    SqlDataAdapter sda2 = new SqlDataAdapter("insert into Approval values('" + textBox1.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + label1.Text + "') ", con);
                    DataTable dt = new DataTable();
                    DataTable dt2 = new DataTable();
                    sda.Fill(dt);
                    sda2.Fill(dt2);
                    MessageBox.Show("Successfully submited in database !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
                }
            catch 
            {
                MessageBox.Show("An error occured while inserting data !\nPlease try again !" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox4.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from forecasting where Serial = '" + textBox4.Text + "' ", con);
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

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select avg ( Sale ) from forecasting  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
            textBox2.Text = null;
            textBox1.Text = null;
            comboBox1.SelectedItem = null ;
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update forecasting set Month ='" + comboBox1.SelectedItem.ToString() + "' , Year = '" + textBox2.Text + "' , Sale ='" + textBox1.Text + "'   where Serial = '" + textBox4.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && comboBox1.SelectedItem != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into forecasting(Serial,Month,Year,Sale)values('" + textBox4.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox2.Text + "', '" + textBox1.Text + "') ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully submited in database !\nPlease refresh to view latest data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("An error occured while inserting data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update balancesheet set Month ='" + comboBox1.SelectedItem.ToString() + "' , Year = '" + textBox2.Text + "' , Sale ='" + textBox1.Text + "'   where Serial = '" + textBox4.Text + "' ", con);
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
                if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.SelectedItem != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from forecasting where Serial = '" + textBox4.Text + "' ", con);
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

        private void forecastedValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select avg ( Sale ) from forecasting  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
            textBox2.Text = null;
            textBox1.Text = null;
            comboBox1.SelectedItem = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from forecasting ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An unexpected error occured !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                textBox1.Text = row.Cells[3].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[0].Value.ToString();
                comboBox1.SelectedItem = row.Cells[1].Value.ToString();
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

        private void Forecasting_Load(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
        }
    }
}
