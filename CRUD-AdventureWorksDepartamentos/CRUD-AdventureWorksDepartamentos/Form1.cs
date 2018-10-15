using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agregar el namespaces para realizar la conexion a la base de datos
using System.Data.SqlClient;

namespace CRUD_AdventureWorksDepartamentos
{
    public partial class frmOpetacionesCRUD : Form
    {


        // Crear la conexion 
        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress; integrated security = true; database = AdventureWorks2014;");

        public frmOpetacionesCRUD()
        {
            InitializeComponent();
        }

        private void btnListarDepartamento_Click(object sender, EventArgs e)
        {
          
            // DML Seleccionar
            string sqlSel = @"SELECT COUNT(*) FROM HumanResources.Department";

            // Crear el comando 
            SqlCommand cmd = new SqlCommand(sqlSel, conn);

            try
            {
                // Establecer la conexion 
                conn.Open();

                // Ejecutar el query
                SqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    lbReader.Items.Add(rdr[0]);
                }
            
                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la exepcion");
            }
            finally
            {
                // Cerrar la conexion
                conn.Close();
            }

        }

        private void btnCrearDepartementos_Click(object sender, EventArgs e)
        {


            // DML Insertar
            // crear el comando para llamar al store procedure
            SqlCommand cmd = new SqlCommand("sp_InsertDepartment", conn);


            // Establecer el comando como un store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                // Establecer la conexion
                conn.Open();

                // Parametros del store procedure
                cmd.Parameters.Add(new SqlParameter("@departmentId", SqlDbType.SmallInt, 3)).Value = txtCodigoDepto.Text;
                cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar)).Value = txtNombreDepto.Text;
                cmd.Parameters.Add(new SqlParameter("@group", SqlDbType.NVarChar)).Value = txtGrupoDepto.Text;
                cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime)).Value = dtpFecha.Value;

                // Ejecutar el comando
                cmd.ExecuteNonQuery();

                // Mostrar el mensaje del Query
                lbEstadoCRUD.Text = "Nuevo departamento agregado";

      
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la exepcion");
            }
            finally
            {
                // Cerrar la conexion
                conn.Close();
            }
        }

        private void btnActualizarDepartamento_Click(object sender, EventArgs e)
        {
            // DML Actualizar
            // crear el comando para llamar al store procedure
            SqlCommand cmd = new SqlCommand("sp_UpdateDepartment", conn);


            // Establecer el comando como un store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {

                // Establecer la conexion
                conn.Open();

                // Parametros del store procedure
                cmd.Parameters.Add(new SqlParameter("@departmentId", SqlDbType.SmallInt, 3)).Value = txtCodigoDepto.Text;
                cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar)).Value = txtNombreDepto.Text;
                cmd.Parameters.Add(new SqlParameter("@group", SqlDbType.NVarChar)).Value = txtGrupoDepto.Text;
                cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime)).Value = dtpFecha.Value;
     
                // Ejecutar el comando
                cmd.ExecuteNonQuery();


                // Mostrar el mensaje del Query
                lbEstadoCRUD.Text = "Departamento actualizado";

                
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la exepcion");
            }
            finally
            {
                // Cerrar la conexion
                conn.Close();
            }
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            // DML Insert
            // crear el comando para llamar al store procedure
            SqlCommand cmd = new SqlCommand("sp_DeleteDepartment", conn);


            // Establecer el comando como un store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {

                // Establecer la conexion
                conn.Open();

                // Parametros del store procedure
                cmd.Parameters.Add(new SqlParameter("@departmentId", SqlDbType.SmallInt, 3)).Value = txtCodigoDepto.Text;

                // Ejecutar el comando
                cmd.ExecuteNonQuery();

                // Mostrar el mensaje del Query
                lbEstadoCRUD.Text = "Departamento Eliminado";

                
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la exepcion");
            }
            finally
            {
                // Cerrar la conexion
                conn.Close();
            }
        }

        
    }
}
