using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ERP.Services
{
    class OperacionesCargos
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public static int IdCargo;
        
        public bool InsertarCargo(DataRepository.PropiedadesCargos cargo)
        {
            string sqlInsertar = @"Insert into Usuario.Puesto_Empleados (Nombre_Puesto) values (@Nombre_Puesto)";

            SqlCommand command = conn.Comando(sqlInsertar);

            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@Nombre_Puesto", SqlDbType.VarChar).Value = cargo.Nombre_Puesto;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se ha agregado exitosamente el cargo.");
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se puede ingresar este nuevo cargo, ya que el nombre existe.");
                return false;
            }
            finally
            {
                conn.DbClose();
            }
        }

        public List<string> ConsultarCargos()
        {
            string sqlConsultar = @"Select Nombre_Puesto from Usuario.Puesto_Empleados order by Id_PuestoEmpleado desc";
            SqlCommand command2 = conn.Comando(sqlConsultar);
            List<string> miLista = new List<string>();

            try
            {
                string g;
                conn.DbOpen();
                SqlDataReader rdr = command2.ExecuteReader();
                while (rdr.Read())
                {
                    miLista.Add(rdr.GetString(0));
                }

                return miLista;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                conn.DbClose();
            }
        }
        public bool ModificarCargos(DataRepository.PropiedadesCargos cargo, int id)
        {
            string sqlModificar = @"Update Usuario.Puesto_Empleados set Nombre_Puesto = @Nombre_Puesto Where Id_PuestoEmpleado = @id";
            SqlCommand command = conn.Comando(sqlModificar);
            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@Nombre_Puesto", SqlDbType.VarChar).Value = cargo.Nombre_Puesto; 
                    command.ExecuteNonQuery();

                }
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.DbClose();
            }
        }

        public void ConsultarIdCargo()
        {
            string sqlConsultar = @"Select Id_PuestoEmpleado from Usuario.Puesto_Empleados Where Nombre_Puesto = @nombre";
            SqlCommand command2 = conn.Comando(sqlConsultar);

            try
            {

                conn.DbOpen();
                using (command2)
                {
                    command2.Parameters.Add("@nombre", SqlDbType.VarChar).Value = UserInterface.Usuarios.frmModificarCargo.NombreCargo;
                    command2.ExecuteNonQuery();

                }
                SqlDataReader rdr = command2.ExecuteReader();
                while (rdr.Read())
                {
                    IdCargo = rdr.GetInt32(0);
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                conn.DbClose();
            }
        }
    }
}
