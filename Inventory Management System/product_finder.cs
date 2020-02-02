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
    public partial class product_finder : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        public product_finder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedItem != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into stock(ID,Category,Name) values ('" + textBox1.Text + "' ,'" + comboBox1.SelectedItem.ToString() + "', '" + textBox2.Text + "')", con);
                    SqlDataAdapter sda2 = new SqlDataAdapter("insert into Approval values ( '" + textBox3.Text + "', '" + textBox2.Text + "' ,'" + label5.Text + "' )", con);
                    DataTable dt = new DataTable();
                    DataTable dt2 = new DataTable();
                    sda.Fill(dt);
                    sda2.Fill(dt2);
                    MessageBox.Show("Successfully added in database !\nPlease refresh to view latest data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("An error occurred while adding data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from stock", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An error occurred !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from stock where id ='" + textBox1.Text + "' ", con);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update stock set Name= '" + textBox2.Text + "', Price=  '" + textBox3.Text + "', Category =  '" + comboBox1.SelectedItem.ToString() + "' where ID = '" + textBox1.Text + "'  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh to view latest data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch
            {
                MessageBox.Show("An error occurred while updating data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedItem = null;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.SelectedItem != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into stock(ID,Name,Price,Category) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "', '" + comboBox1.SelectedItem + "')", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Successfully added in database !\nPlease refresh to view latest data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty.\nPlease try again !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("An error occurred while adding data !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from stock", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An error occurred !\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("update stock set Name= '" + textBox2.Text + "', Price=  '" + textBox3.Text + "', Category =  '" + comboBox1.SelectedItem.ToString() + "' where ID = '" + textBox1.Text + "'  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Database updated successfully !\nPlease refresh to view latest data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && comboBox1.SelectedItem != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("delete from stock where id ='" + textBox1.Text + "' ", con);
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedItem = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                comboBox1.SelectedItem = row.Cells[1].Value.ToString();

            }
            catch
            {

            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DataGridView.ForeColor = Color.Black;
            }
        }

        private void product_finder_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
        }
    }
}
