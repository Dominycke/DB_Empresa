using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App_MCVill
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           /* try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource      = "DESKTOP-5HI9019//SQLEXPRESS",
                    UserID          = "sa",
                    Password        = "1234",
                    InitialCatalog  = "MCVill_Empleados"
                };

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine();
                }
            }

            catch (Exception)
            {
                throw;
            }*/
        }
    }
}