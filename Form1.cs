using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_MCVill
{
    public partial class Form1 : Form
    {
        static string conServer = "Data Source=DESKTOP-5HI9019\\SQLEXPRESS;Initial Catalog=MCVill_Empleados;Integrated Security=True";

        SqlConnection  con   = new SqlConnection(conServer);
        Empleados      emp   = new Empleados();
        Fecha_Empleado f_emp = new Fecha_Empleado();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {}

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            lblVacTom.Visible = false;
            tbVacTom.Visible  = false;

            dgvEmpleados.DataSource = emp.MostrarEmpleados();

            columnasEmpleados();

            lblID.Text       = "ID Emleado";
            lblNomEmp.Text   = "Nombre(s) Empleado";
            lblApeEmp.Text   = "Apellidos Empleado";
            lblFechaIng.Text = "Fecha Ingreso";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblVacTom.Visible = true;
            tbVacTom.Visible  = true;

            dgvEmpleados.DataSource = f_emp.MostrarEmpleados();

            columnasFechas();

            lblID.Text       = "ID Emleado";
            lblNomEmp.Text   = "Vacaciones Activas";
            lblApeEmp.Text   = "Dias restantes por tomar";
            lblFechaIng.Text = "Vacaciones tomadas?";
            lblVacTom.Text   = "Periodo";

        }

        private void label1_Click(object sender, EventArgs e)
        {}

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if(lblVacTom.Visible == false)
            {
                string cad = "INSERT INTO Empleados(IDEmp, NomEmp, ApeEmp, FechaIngreso) " +
                "values ('" + tbID.Text + "','" + tbNomEmp.Text + "','" + tbApeEmp.Text+ "','" + tbFechaIng.Text + "')";

                SqlCommand cmd = new SqlCommand(cad, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("El Empleado se ah agregado correctamente");
                
                string tab = "Empleados";
                consulta(tab);

                cleanEmpleados();
            }
            else
            {
                string cad = "INSERT INTO Fecha_Empleado (IDEmp, VacAct, DiasXtomar, VacTom, Periodo) " +
                "values ('" + tbID.Text + "','" + tbNomEmp.Text + "','" + tbApeEmp.Text + "','" + tbFechaIng.Text + "','"+ tbVacTom.Text + "')";

                SqlCommand cmd = new SqlCommand(cad, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("El Empleado se ah agregado correctamente");

                string tab = "Fecha_Empleado";
                consulta(tab);

                cleanFechas();
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("Conectado a la BD: " + con.Database);
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            con.Close();
            MessageBox.Show("Deconectado de la BD: " + con.Database);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (lblVacTom.Visible == false)
            {
                if (tbID.Text == "")
                {
                    string query        = "Select * from Empleados";
                    SqlCommand cmd      = new SqlCommand(query, con);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable tabla     = new DataTable();
                    data.Fill(tabla);
                    dgvEmpleados.DataSource = tabla;

                    columnasEmpleados();
                }
                else
                {
                    string query        = "Select * from Empleados where IDEmp = '" + tbID.Text + "'";
                    SqlCommand cmd      = new SqlCommand(query, con);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable tabla     = new DataTable();
                    data.Fill(tabla);
                    dgvEmpleados.DataSource = tabla;

                    columnasEmpleados();
                }

            }
            else
            {
                if (tbID.Text == "")
                {
                    string query        = "Select * from Fecha_Empleado";
                    SqlCommand cmd      = new SqlCommand(query, con);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable tabla     = new DataTable();
                    data.Fill(tabla);
                    dgvEmpleados.DataSource = tabla;

                    columnasFechas();
                }
                else
                {
                    string query        = "Select * from Fecha_Empleado where IDEmp = '" + tbID.Text + "'";
                    SqlCommand cmd      = new SqlCommand(query, con);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable tabla     = new DataTable();
                    data.Fill(tabla);
                    dgvEmpleados.DataSource = tabla;

                    columnasFechas();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int flag = 0;
            
            if (lblVacTom.Visible == false)
            {
                string cad = "DELETE FROM Empleados where IDEmp = "+ tbID.Text;

                SqlCommand cmd = new SqlCommand(cad, con);
                flag =  cmd.ExecuteNonQuery(); //Si es positivo nos dara un 1, si no, nos mandara un 0

                if( flag == 1)
                {
                    MessageBox.Show("El registro se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser eliminado, verifica que los datos ingresados sean correctos.");
                }

                tbID.Text  = "";
                string tab = "Empleados";
                consulta(tab);
            }
            else
            {
                string cad = "DELETE FROM Fecha_Empleado where IDEmp = " + tbID.Text;

                SqlCommand cmd = new SqlCommand(cad, con);
                flag = cmd.ExecuteNonQuery(); //Si es positivo nos dara un 1, si no, nos mandara un 0

                if (flag == 1)
                {
                    MessageBox.Show("El registro se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser eliminado, verifica que los datos ingresados sean correctos.");
                }

                tbID.Text = "";
                string tab = "Fecha_Empleado";
                consulta(tab);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int flag = 0;

            if(lblVacTom.Visible == false)
            {
                                                //IDEmp = '"+ tbID.Text+ "',
                string cad = "UPDATE Empleados set NomEmp = '"+ tbNomEmp.Text + "', ApeEmp = '"+ tbApeEmp.Text + "', FechaIngreso = '" + tbFechaIng.Text + "' where IDEmp = "+ tbID.Text;

                SqlCommand cmd = new SqlCommand(cad, con);
                flag = cmd.ExecuteNonQuery(); //Si es positivo nos dara un 1, si no, nos mandara un 0

                if (flag == 1)
                {
                    MessageBox.Show("El registro se modifico correctamente");
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser modificado, verifica que los datos ingresados sean correctos.");
                }

                cleanEmpleados();

                string tab = "Empleados";
                consulta(tab);
            }
            else
            {
                string cad = "UPDATE Fecha_Empleado set VacAct = '" + tbNomEmp.Text + "', DiasXtomar = '" + tbApeEmp.Text + "', VacTom = '" + tbFechaIng.Text + "', Periodo = '" + tbVacTom.Text + "' where IDEmp = " + tbID.Text;

                SqlCommand cmd = new SqlCommand(cad, con);
                flag = cmd.ExecuteNonQuery(); //Si es positivo nos dara un 1, si no, nos mandara un 0

                if (flag == 1)
                {
                    MessageBox.Show("El registro se modifico correctamente");
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser modificado, verifica que los datos ingresados sean correctos.");
                }

                tbID.Text = "";
                string tab = "Fecha_Empleado";
                consulta(tab);

            }
            
        }

        public void consulta(string tab)
        {
            string query = "Select * from " + tab;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgvEmpleados.DataSource = tabla;
        }

        public void columnasEmpleados()
        {
            dgvEmpleados.Columns[0].HeaderText = "ID Empleado";
            dgvEmpleados.Columns[1].HeaderText = "Nombre(s)";
            dgvEmpleados.Columns[2].HeaderText = "Apellidos";
            dgvEmpleados.Columns[3].HeaderText = "Fecha Ingreso";
        }

        public void columnasFechas()
        {
            dgvEmpleados.Columns[0].HeaderText = "ID Empleado";
            dgvEmpleados.Columns[1].HeaderText = "Vacaciones Activas";
            dgvEmpleados.Columns[2].HeaderText = "Dias restantes por tomar";
            dgvEmpleados.Columns[3].HeaderText = "Vacaciones tomadas?";
            dgvEmpleados.Columns[4].HeaderText = "Periodo";
        }
        public void cleanEmpleados()
        {
            tbID.Text       = "";
            tbNomEmp.Text   = "";
            tbApeEmp.Text   = "";
            tbFechaIng.Text = "";
        }

        public void cleanFechas()
        {
            tbID.Text       = "";
            tbNomEmp.Text   = "";
            tbApeEmp.Text   = "";
            tbFechaIng.Text = "";
            tbVacTom.Text   = "";
        }
    }
}