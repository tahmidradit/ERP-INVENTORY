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
    public partial class gldata : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        public gldata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from generalledger", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            generalledger bck = new generalledger();
            bck.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            logininfo bck = new logininfo();
            bck.Show();
        }
    }
}
