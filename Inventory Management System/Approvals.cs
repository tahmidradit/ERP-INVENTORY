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
    public partial class Approvals : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        public Approvals()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Approval ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (textBox3.Text == "BALANCE SHEET")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Update balancesheet set Amount = '" + textBox2.Text + "' where balancesheet.Account = '" + textBox1.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Approved successfully","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                else if (textBox3.Text == "SALES FORECASTING")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Update forecasting set Sale = '" + textBox2.Text + "' where forecasting.Month = '" + textBox1.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Approved successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else if (textBox3.Text == "INCOME STATEMENTRevenuesUSD")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Update incomestatement set RevenuesUSD = '" + textBox2.Text + "' where incomestatement.Account = '" + textBox1.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Approved successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (textBox3.Text == "INCOME STATEMENTExpensesUSD")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Update incomestatement set ExpensesUSD = '" + textBox2.Text + "' where incomestatement.Account = '" + textBox1.Text + "'  ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Approved successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (textBox3.Text == "CURRENT STOCK")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Update stock set Price = '" + textBox2.Text + "' where stock.Name = '" + textBox1.Text + "'  ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Approved successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBox3.Text == "SALARY MANAGEMENT")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Update salary set Salary = '" + textBox2.Text + "' where salary.Employee = '" + textBox1.Text + "'  ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Approved successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (textBox3.Text == "GENERAL JOURNAL-Debit")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Update gj set Debit = '" + textBox2.Text + "' where gj.Account = '" + textBox1.Text + "'  ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Approved successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBox3.Text == "GENERAL JOURNAL-Credit")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Update gj set Credit = '" + textBox2.Text + "' where gj.Account = '" + textBox1.Text + "'  ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Approved successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("An unexpected error occured. Try again.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("An unexpected error occured. Try again.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();

            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Delete from Approval", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MessageBox.Show("Success");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
