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
    class OperacionesRoles
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public int filas = 0;
        public int IdSeguridad;

        public bool InsertarRol (DataRepository.PropiedadesRol roles)
        {
            string sqlInsertar = @"Insert into Usuario.Seguridad (Rol, Descripcion, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor) values (@rol, @descripcion, @fechaCreacion, @creadoPor, @fechaModificacion, @modificadoPor)";

            SqlCommand command = conn.Comando(sqlInsertar);

            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@rol", SqlDbType.VarChar).Value = roles.Rol;
                    command.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = roles.Descripcion;
                    command.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@creadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                    command.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                    command.ExecuteNonQuery();

                    MessageBox.Show("Se ha agregado exitosamente el rol");
                }
                return true;
            }
            catch (SqlException ex)
            {

                MessageBox.Show("No se puede ingresar este nuevo rol, ya que el nombre existe.");
                return false;
            }
            finally
            {
                conn.DbClose();
            }
        }

        public bool AgregarPermisos(int ID,string nombre)
        {
            string sqlInsertar = @"Insert into Usuario.Permisos (NombrePermiso, IdRol, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor) values (@Nombre, @idRol, @fechaCreacion, @creadoPor, @fechaModificacion, @modificadoPor)";

            SqlCommand command = conn.Comando(sqlInsertar);

            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                    command.Parameters.Add("@idRol", SqlDbType.Int).Value = ID;
                    command.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@creadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                    command.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
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

        public bool QuitarPermisos(int ID, string nombre)
        {
            string sqlInsertar = @"Delete from Usuario.Permisos where IdRol = @idrol and NombrePermiso = @nombre";

            SqlCommand command = conn.Comando(sqlInsertar);

            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@idrol", SqlDbType.Int).Value = ID;
                    command.Parameters.Add("@nombre", SqlDbType.VarChar,30).Value = nombre;
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
        public List<string> PopularLista(int ID)
        {
            List<string> Milista = new List<string>();
            string sql = @"Select NombrePermiso From Usuario.Permisos WHERE IdRol =@id ";


            
            try
            {
                // Establecer la conexión
                conn.DbOpen();

                // Crear el comando
                SqlCommand cmd = conn.Comando(sql);
                using (cmd)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                    cmd.ExecuteNonQuery();
                }

                // Ejecutar el query via un Execute Reader
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    Milista.Add(rdr.GetString(0));


                }

                return Milista;
            }

            catch (SqlException ex)
            {
                return Milista;
            }
            finally
            {
                conn.DbClose();
            }
        }
        public List<string> ComprobarRoles(int ID)
        {
            List<string> Milista = new List<string>();
            string sqlConsultarIdSeguridad = @"Select IdSeguridad from Usuario.Usuarios Where IdUsuario = @idEmpleado";
            string sql = @"Select NombrePermiso From Usuario.Permisos WHERE IdRol =@id ";



            try
            {
                // Establecer la conexión
                conn.DbOpen();

                // Crear el comando
                SqlCommand cmd1 = conn.Comando(sqlConsultarIdSeguridad);
                using (cmd1)
                {
                    cmd1.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = ID;
                    cmd1.ExecuteNonQuery();
                }

                // Ejecutar el query via un Execute Reader
                SqlDataReader rdr1 = cmd1.ExecuteReader();

                while (rdr1.Read())
                {

                    IdSeguridad = rdr1.GetInt32(0);
                }
                rdr1.Close();

                // Crear el comando
                SqlCommand cmd = conn.Comando(sql);
                using (cmd)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = IdSeguridad;
                    cmd.ExecuteNonQuery();
                }

                // Ejecutar el query via un Execute Reader
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    Milista.Add(rdr.GetString(0));


                }

                return Milista;
            }

            catch (SqlException ex)
            {
                return Milista;
            }
            finally
            {
                conn.DbClose();
            }
        }
        public int idrol;
        public int ObtenerIdRol(string nombre)
        {

            string sql = @"Select IdSeguridad From Usuario.Seguridad WHERE Rol =@nombre ";

            // Establecer la conexión
            conn.DbOpen();
            

            // Crear el comando
            SqlCommand cmd = conn.Comando(sql);
            using (cmd)
            {
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar,30).Value = nombre;
                cmd.ExecuteNonQuery();
            }

            try
            {
                
                // Ejecutar el query via un Execute Reader
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    idrol = rdr.GetInt32(0);


                }

                return idrol;
            }

            catch (SqlException ex)
            {
                return 0;
            }
            finally
            {
                conn.DbClose();
            }
        }
        public List<DataRepository.PropiedadesRol> ConsultarRoles()
        {
            string sqlConsultar = @"Select IdSeguridad, Rol from Usuario.Seguridad";
            ComboBox cbRoles = new ComboBox();
            SqlCommand command2 = conn.Comando(sqlConsultar);
            DataRepository.PropiedadesRol rol = new DataRepository.PropiedadesRol();
            List<DataRepository.PropiedadesRol> miLista = new List<DataRepository.PropiedadesRol>();
            
                try
                {
                    string g;
                    conn.DbOpen();
                    SqlDataReader rdr = command2.ExecuteReader();
                    while (rdr.Read())
                    {
                        rol = new DataRepository.PropiedadesRol();
                        rol.IdSeguridad = rdr.GetInt32(0);
                        rol.Rol = rdr.GetString(1);
                        miLista.Add(rol);
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

        public List<DataRepository.PropiedadesRol> ConsultarRol(int id)
        {
            string sqlConsultar = @"Select Rol, Descripcion from Usuario.Seguridad where IdSeguridad = @id";
            SqlCommand command = conn.Comando(sqlConsultar);
            DataRepository.PropiedadesRol rol = new DataRepository.PropiedadesRol();
            List<DataRepository.PropiedadesRol> miLista = new List<DataRepository.PropiedadesRol>();
            miLista.Add(rol);
            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    rol.Rol =(rdr.GetString(0));
                    rol.Descripcion = rdr.GetString(1);
                    miLista.Add(rol);
                }
                return miLista;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.DbClose();
            }
        }

        public bool ModificarRol(DataRepository.PropiedadesRol rol, int id)
        {
            string sqlModificar = @"Update Usuario.Seguridad set Rol = @rol, Descripcion = @descripcion, FechaModificacion = @fechaModificacion, ModificadoPor = @modificadoPor Where IdSeguridad = @id";
            SqlCommand command = conn.Comando(sqlModificar);
            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@rol", SqlDbType.VarChar).Value = rol.Rol;
                    command.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = rol.Descripcion;
                    command.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
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
    }
}
