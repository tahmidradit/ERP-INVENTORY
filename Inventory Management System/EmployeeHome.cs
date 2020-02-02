using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class EmployeeHome : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr intPtr,int x,int y,int z);

        private void PanelDock(object panel)
        {
            if(panel3.Controls.Count>0)
            {
                panel3.Controls.RemoveAt(0);
            }
            Form fm = panel as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fm);
            this.panel3.Tag = fm;
            fm.Show();
        }

        public EmployeeHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelDock(new balancesheet());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 142)
            {
                panel1.Width = 45;
            }
            else panel1.Width = 142;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelDock(new employee());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelDock(new Forecasting());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelDock(new generalledger());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelDock(new General_Journal());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PanelDock(new incomestatement());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PanelDock(new product_finder());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PanelDock(new salary());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHome eh = new EmployeeHome();
            eh.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            logininfo li = new logininfo();
            li.Show();
        }
    }
}
