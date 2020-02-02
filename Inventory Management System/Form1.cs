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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr intPtr, int u, int p, int w);
        private void PanelDock(object ObjPanel)
        {
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            Form fm = ObjPanel as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fm);
            this.panel2.Tag = fm;
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelDock(new salary());
            //this.Hide();
            //salary salary = new salary();
            //salary.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelDock(new product_finder());
            //this.Hide();
            //product_finder productfinder = new product_finder();
            //productfinder.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PanelDock(new employee());
            //this.Hide();
            //employee employee = new employee();
            //employee.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PanelDock(new Forecasting());
            //this.Hide();
            //Forecasting forecasting = new Forecasting();
            //forecasting.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inventory Management System v1.1\nDeveloped by Tahmid Radit","About", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            logininfo li = new logininfo();
            li.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelDock(new balancesheet());
            //this.Hide();
            //balancesheet balancesheet = new balancesheet();
            //balancesheet.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PanelDock(new incomestatement());
            //this.Hide();
            //incomestatement incomestatement = new incomestatement();
            //incomestatement.Show();
        }

        private void currentStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product_finder productfinder = new product_finder();
            productfinder.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PanelDock(new General_Journal());
            //this.Hide();
            //General_Journal genjournal = new General_Journal();
            //genjournal.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            PanelDock(new generalledger());
            //this.Hide();
            //generalledger gl = new generalledger();
            //gl.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inventory Management System v1.1\nDeveloped by Tahmid Radit", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PanelDock(new employee());
            //this.Hide();
            //employee employee = new employee();
            //employee.Show();
        }

        private void productsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PanelDock(new product_finder());
            //this.Hide();
            //product_finder productfinder = new product_finder();
            //productfinder.Show();
        }

        private void salaryManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PanelDock(new salary());
            //this.Hide();
            //salary salary = new salary();
            //salary.Show();
        }

        private void salesForecastingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PanelDock(new Forecasting());
            //this.Hide();
            //Forecasting forecasting = new Forecasting();
            //forecasting.Show();
        }

        private void balanceSheetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            balancesheet balancesheet = new balancesheet();
            balancesheet.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer - Tahmid Radit\nDhaka,Bangladesh\nWebsite : tahmidradit.blogspot.com\nE-mail : tahmidradit@yahoo.com\n", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PanelDock(new Approvals());
            //this.Hide();
            //Approvals ap = new Approvals();
            //ap.Show();
            
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(panel3.Width == 185)
            {
                panel3.Width = 43;
            }
            else
            {
                panel3.Width = 185;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PanelDock(new AddNewUser());
        }
    }
}
