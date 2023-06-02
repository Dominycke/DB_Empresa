using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace App_MCVill
{
    public class Conexion
    {
        SqlCommand     cmd;
        SqlConnection  cn;
        

        public SqlConnection LeerCadena()
        {
            //Se ace la conexion por medio de 'unica', entre la app y la base de datos de sql server
            //Data Source=DESKTOP-5HI9019\SQLEXPRESS;Initial Catalog=MCVill_Empleados;Integrated Security=True
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);

            if( cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }
    }
}
