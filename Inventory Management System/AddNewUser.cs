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

namespace Inventory_Management_System
{
    public partial class AddNewUser : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert into logininfo2 values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "')", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("User created successfully","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An unexpected error occured.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Delete from logininfo2 where Id = '" + textBox1.Text + "' ", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Successfully removed user", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An unexpected error occured.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Update logininfo2 set Username= '" + textBox2.Text + "' , Password='" + textBox3.Text + "'  where Id = '" + textBox1.Text + "' ", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Successfully removed user", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An unexpected error occured.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from logininfo2 ", sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("An unexpected error occured.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.DataGridView.ForeColor = Color.Black;
            }
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;

        }

    }
}
