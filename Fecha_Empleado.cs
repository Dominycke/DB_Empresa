using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MCVill
{
    public class Fecha_Empleado
    {
        Conexion cn = new Conexion();

        public DataTable MostrarEmpleados()
        {
            //Manda a llamar el metodo para mostrar la tabla desde el servidor en conjunto con el metodo LeerCadena de la clase conexion
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARTABLAFECHAEMPLEADO", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            //Se devuelve un objeto con el metodo para transferir todos los datos al DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
