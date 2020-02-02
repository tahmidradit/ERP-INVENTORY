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
    public partial class generalledger : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        public generalledger()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            gldata gd = new gldata();
            gd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int n = int.Parse(textBox53.Text);
            switch(n)
            {
                case 1:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Cash],[Cash Date],Cash,[Cash Debit],[Cash Credit],[Cash Balance])values('" + textBox53.Text + "','" + dateTimePicker12.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 2:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Supplies],[Supplies Date],Supplies,[Supplies Debit],[Supplies Credit],[Supplies Balance])values('" + textBox53.Text + "','" + dateTimePicker12.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox3.Text + "','" + textBox1.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 3:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Paid Insurance],[Prepaid Insurance Date],[Prepaid Insurance],[PI Debit],[PI Credit],[PI Balance])values('" + textBox53.Text + "', '" + dateTimePicker12.Text + "',   '" + textBox12.Text + "','" + textBox11.Text + "','" + textBox10.Text + "','" + textBox9.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 4 :
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Equipment],[Equipment Date],Equipment,[Equipment Debit],[Equipment Credit],[Equipment Balance])values('" + textBox53.Text + "', '" + dateTimePicker12.Text + "' ,   '" + textBox16.Text + "','" + textBox15.Text + "','" + textBox14.Text + "','" + textBox13.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 5:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Notes Payable],[Notes Payable Date],[Notes Payable],[NP Debit],[NP Credit],[NP Balance])values('" + textBox53.Text + "',  '" + dateTimePicker12.Text + "','" + textBox24.Text + "','" + textBox23.Text + "','" + textBox22.Text + "','" + textBox21.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 6:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Accounts Payable],[Accounts Payable Date],[Accounts Payable],[AP Debit],[AP Credit],[AP Balance])values('" + textBox53.Text + "',  '" + dateTimePicker12.Text + "' ,'" + textBox28.Text + "','" + textBox27.Text + "','" + textBox26.Text + "','" + textBox25.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 7:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Unearned Service Revenue],[Unearned Service Revenue Date],[Unearned Service Revenue],[USR Debit],[USR Credit],[USR Balance])values('" + textBox53.Text + "',  '" + dateTimePicker12.Text + "'  ,'" + textBox32.Text + "','" + textBox31.Text + "','" + textBox30.Text + "','" + textBox29.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 8:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Owner's Capital],[Owner’s Capital Date],[Owner’s Capital],[OC Debit],[OC Credit],[OC Balance])values('" + textBox53.Text + "', '" + dateTimePicker12.Text + "' ,'" + textBox36.Text + "','" + textBox35.Text + "','" + textBox34.Text + "','" + textBox33.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 9:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Owner's Drawings],[Owner’s Drawings Date],[Owner’s Drawings],[OD Debit],[OD Credit],[OD Balance])values('" + textBox53.Text + "', '" + dateTimePicker12.Text + "','" + textBox40.Text + "','" + textBox39.Text + "','" + textBox38.Text + "','" + textBox37.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 10:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Service Revenue],[Service Revenue Date],[Service Revenue],[SR Debit],[SR Credit],[SR Balance])values( '" + textBox53.Text + "', '" + dateTimePicker12.Text + "' ,'" + textBox44.Text + "','" + textBox43.Text + "','" + textBox42.Text + "','" + textBox41.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 11:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Salaries and Wages Expense],[Salaries and Wages Expense Date],[Salaries and Wages Expense],[SWE Debit],[SWE Credit],[SWE Balance])values('" + textBox53.Text + "',  '" + dateTimePicker12.Text + "','" + textBox48.Text + "','" + textBox47.Text + "','" + textBox46.Text + "','" + textBox45.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                case 12:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Rent Expense],[Rent Expense Date],[Rent Expense],[RE Debit],[RE Credit],[RE Balance])values('" + textBox53.Text + "', '" + dateTimePicker12.Text + "' ,'" + textBox52.Text + "','" + textBox51.Text + "','" + textBox50.Text + "','" + textBox49.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;
                default:
                    {
                        MessageBox.Show("An error occured during inserting data !\nPlease try again !" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } break;
                
            }

           
                
            
                
                


            

            

            

            

            

            

            

            

            

            

           

            




        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox12.Clear(); textBox23.Clear(); textBox34.Clear(); textBox45.Clear();
            textBox2.Clear(); textBox13.Clear(); textBox24.Clear(); textBox35.Clear(); textBox46.Clear();
            textBox3.Clear(); textBox14.Clear(); textBox25.Clear(); textBox36.Clear(); textBox47.Clear();
            textBox4.Clear(); textBox15.Clear(); textBox26.Clear(); textBox37.Clear(); textBox48.Clear();
            textBox5.Clear(); textBox16.Clear(); textBox27.Clear(); textBox38.Clear(); textBox49.Clear();
            textBox50.Clear(); textBox51.Clear(); textBox52.Clear(); dateTimePicker12.Text = null; 
            textBox6.Clear();  textBox28.Clear(); textBox39.Clear();
            textBox7.Clear();  textBox29.Clear(); textBox40.Clear();
            textBox8.Clear();  textBox30.Clear(); textBox41.Clear();
            textBox9.Clear();  textBox31.Clear(); textBox42.Clear();
            textBox10.Clear(); textBox21.Clear(); textBox32.Clear(); textBox43.Clear();
            textBox11.Clear(); textBox22.Clear(); textBox33.Clear(); textBox44.Clear();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox53.Text);
            switch (n)
            {
                case 1:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Cash] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 2:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Supplies] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 3:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Paid Insurance] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 4:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Equipment] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 5:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Notes Payable] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 6:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Accounts Payable] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 7:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Unearned Service Revenue] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 8:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Owner's Capital] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 9:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Owner's Drawings] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleting successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 10:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No.  Service Revenue] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 11:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Salaries and Wages Expense] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 12:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Rent Expense] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                default:
                    {
                        MessageBox.Show("An error occured during deleting data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox53.Text);
            switch (n)
            {
                case 1:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Cash],[Cash Date],Cash,[Cash Debit],[Cash Credit],[Cash Balance])values('" + textBox53.Text + "','" + dateTimePicker12.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 2:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Supplies],[Supplies Date],Supplies,[Supplies Debit],[Supplies Credit],[Supplies Balance])values('" + textBox53.Text + "','" + dateTimePicker12.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox3.Text + "','" + textBox1.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 3:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Paid Insurance],[Prepaid Insurance Date],[Prepaid Insurance],[PI Debit],[PI Credit],[PI Balance])values('" + textBox53.Text + "', '" + dateTimePicker12.Text + "',   '" + textBox12.Text + "','" + textBox11.Text + "','" + textBox10.Text + "','" + textBox9.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 4:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Equipment],[Equipment Date],Equipment,[Equipment Debit],[Equipment Credit],[Equipment Balance])values('" + textBox53.Text + "', '" + dateTimePicker12.Text + "' ,   '" + textBox16.Text + "','" + textBox15.Text + "','" + textBox14.Text + "','" + textBox13.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 5:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Notes Payable],[Notes Payable Date],[Notes Payable],[NP Debit],[NP Credit],[NP Balance])values('" + textBox53.Text + "',  '" + dateTimePicker12.Text + "','" + textBox24.Text + "','" + textBox23.Text + "','" + textBox22.Text + "','" + textBox21.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 6:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Accounts Payable],[Accounts Payable Date],[Accounts Payable],[AP Debit],[AP Credit],[AP Balance])values('" + textBox53.Text + "',  '" + dateTimePicker12.Text + "' ,'" + textBox28.Text + "','" + textBox27.Text + "','" + textBox26.Text + "','" + textBox25.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 7:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Unearned Service Revenue],[Unearned Service Revenue Date],[Unearned Service Revenue],[USR Debit],[USR Credit],[USR Balance])values('" + textBox53.Text + "',  '" + dateTimePicker12.Text + "'  ,'" + textBox32.Text + "','" + textBox31.Text + "','" + textBox30.Text + "','" + textBox29.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 8:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Owner's Capital],[Owner’s Capital Date],[Owner’s Capital],[OC Debit],[OC Credit],[OC Balance])values('" + textBox53.Text + "', '" + dateTimePicker12.Text + "' ,'" + textBox36.Text + "','" + textBox35.Text + "','" + textBox34.Text + "','" + textBox33.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 9:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Owner's Drawings],[Owner’s Drawings Date],[Owner’s Drawings],[OD Debit],[OD Credit],[OD Balance])values('" + textBox53.Text + "', '" + dateTimePicker12.Text + "','" + textBox40.Text + "','" + textBox39.Text + "','" + textBox38.Text + "','" + textBox37.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 10:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No.  Service Revenue],[Service Revenue Date],[Service Revenue],[SR Debit],[SR Credit],[SR Balance])values( '" + textBox53.Text + "', '" + dateTimePicker12.Text + "' ,'" + textBox44.Text + "','" + textBox43.Text + "','" + textBox42.Text + "','" + textBox41.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 11:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Salaries and Wages Expense],[Salaries and Wages Expense Date],[Salaries and Wages Expense],[SWE Debit],[SWE Credit],[SWE Balance])values('" + textBox53.Text + "',  '" + dateTimePicker12.Text + "','" + textBox48.Text + "','" + textBox47.Text + "','" + textBox46.Text + "','" + textBox45.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 12:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("insert into generalledger([Serial No. Rent Expense],[Rent Expense Date],[Rent Expense],[RE Debit],[RE Credit],[RE Balance])values('" + textBox53.Text + "', '" + dateTimePicker12.Text + "' ,'" + textBox52.Text + "','" + textBox51.Text + "','" + textBox50.Text + "','" + textBox49.Text + "')", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during inserting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                default:
                    {
                        MessageBox.Show("An error occured during inserting data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox12.Clear(); textBox23.Clear(); textBox34.Clear(); textBox45.Clear();
            textBox2.Clear(); textBox13.Clear(); textBox24.Clear(); textBox35.Clear(); textBox46.Clear();
            textBox3.Clear(); textBox14.Clear(); textBox25.Clear(); textBox36.Clear(); textBox47.Clear();
            textBox4.Clear(); textBox15.Clear(); textBox26.Clear(); textBox37.Clear(); textBox48.Clear();
            textBox5.Clear(); textBox16.Clear(); textBox27.Clear(); textBox38.Clear(); textBox49.Clear();
            textBox50.Clear(); textBox51.Clear(); textBox52.Clear(); dateTimePicker12.Text = null;
            textBox6.Clear(); textBox28.Clear(); textBox39.Clear();
            textBox7.Clear(); textBox29.Clear(); textBox40.Clear();
            textBox8.Clear(); textBox30.Clear(); textBox41.Clear();
            textBox9.Clear(); textBox31.Clear(); textBox42.Clear();
            textBox10.Clear(); textBox21.Clear(); textBox32.Clear(); textBox43.Clear();
            textBox11.Clear(); textBox22.Clear(); textBox33.Clear(); textBox44.Clear();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox53.Text);
            switch (n)
            {
                case 1:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Cash] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 2:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Supplies] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 3:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Paid Insurance] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 4:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Equipment] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 5:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Notes Payable] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 6:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Accounts Payable] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 7:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Unearned Service Revenue] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 8:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Owner's Capital] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 9:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Owner's Drawings] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleting successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 10:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No.  Service Revenue] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 11:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Salaries and Wages Expense] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 12:
                    {
                        try
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("delete from generalledger where [Serial No. Rent Expense] = '" + textBox53.Text + "' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured during deleting data !\nPlease try again !" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                default:
                    {
                        MessageBox.Show("An error occured during deleting data !\nPlease try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bck = new Form1();
            bck.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gldata gd = new gldata();
            gd.Show();
        }
    }
    }

