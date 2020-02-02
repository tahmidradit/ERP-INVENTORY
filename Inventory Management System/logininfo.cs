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
using System.Runtime.InteropServices;

namespace Inventory_Management_System
{
    public partial class logininfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr intPtr,int x, int y, int z);
        public logininfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from logininfo where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'   ", con);
                SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from logininfo2 where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'   ", con);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                sda.Fill(dt);
                sda2.Fill(dt2);
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        Form1 fm1 = new Form1();
                        fm1.Show();
                    } 

                    else if (dt2.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        EmployeeHome eh = new EmployeeHome();
                        eh.Show();
                    }
                    
                    else
                    {
                        MessageBox.Show("Wrong User ID & Password combination !\nPlease try again !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty !\nPlease try again !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            catch
            {
                MessageBox.Show("An error occured during inserting credentials !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
