using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    static class Program
    {
       public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-H8FALR0\SQLEXPRESS;Initial Catalog=finalproducts;Integrated Security=True");
        

        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new logininfo());
        }
    }
}
