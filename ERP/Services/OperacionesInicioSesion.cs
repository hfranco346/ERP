using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace ERP.Services
{
    class OperacionesInicioSesion
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public static string alias;
        public static string clave;
        public static bool estado;
        public void ConsultarAlias()
        {
            string sqlConsultar = @"Select u.IdUsuario, u.Alias, u.Clave, u.Estado, e.Nombres from Usuario.Usuarios u join Usuario.Empleado e on Alias = @alias and e.IdEmpleado=u.IdEmpleado";
            SqlCommand command2 = conn.Comando(sqlConsultar);

            try
            {
                conn.DbOpen();
                using (command2)
                {
                    command2.Parameters.Add("@alias", SqlDbType.NChar).Value = UserInterface.Usuarios.frmInicioSesion.alias;
                    command2.ExecuteNonQuery();

                }
                SqlDataReader rdr = command2.ExecuteReader();
                while (rdr.Read())
                {
                    DataRepository.PropiedadesInicioSesion.IdUsuario = rdr.GetInt32(0);
                    alias = rdr.GetString(1);
                    clave = rdr.GetString(2);
                    estado = rdr.GetBoolean(3);
                    DataRepository.PropiedadesInicioSesion.nombreUsuario = rdr.GetString(4);
                    
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

        public void ValidarInicioSesion()
        {
            string sqlConsultar = @"Select *from Usuario.Usuarios";
            SqlCommand command2 = conn.Comando(sqlConsultar);

            try
            {
                conn.DbOpen();
  
                SqlDataReader rdr = command2.ExecuteReader();
                while (rdr.Read())
                {
                    DataRepository.PropiedadesInicioSesion.Login = true;

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
