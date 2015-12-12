using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ERP.UserInterface.Usuarios;

namespace ERP.Services
{
    class OperacionesUsuarios
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public static string idEmpleado;
        public int id;
        public static string rol;
        public static string clave;
        public int idEmpleadoInsertarUsuario;
        public static int IdEmpleadoModificar;
        public static int idEmpleadoModificarUsuario;
        public static string aliasModificarUsuario;
        public static int idSeguridadModifciarUsuario;
        public static string rolModificarUsuario;
        public static string claveModificarUsuario;
        public static int idUsuarioAModificar;
        public bool DarDeBaja(bool Estado, string id)
        {
            string sqlModificar = @"Update Usuario.Usuarios set Estado =@estado, FechaModificacion = @fechaModificacion, ModificadoPor = @modificadoPor where IdUsuario = @Id";
            SqlCommand command = conn.Comando(sqlModificar);
            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                    command.Parameters.Add("@estado", SqlDbType.Bit).Value = Estado;
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

        public bool SqlUpdate(DataRepository.Usuarios users, int id)
        {


            string consultar = @"Select IdSeguridad, Alias, Clave,
                               FechaModificacion, ModificadoPor
                                   From Usuario.Usuarios";

            string modificar = @"Update Usuario.Usuarios set IdSeguridad = @IdSeguridad,
                                Alias = @Alias, 
                                Clave = @Clave,
                                FechaModificacion = @FechaModificacion,
                                ModificadoPor = @ModificadoPor WHERE IdUsuario = @id";

            
            try
            {
                conn.DbOpen();
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand myCommand = conn.Comando(consultar);
                da.SelectCommand = myCommand;
 
                // Crear y popular el Data Set
                DataSet ds = new DataSet();
                da.Fill(ds, "Usuario.Usuarios");

                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["Usuario.Usuarios"];

                //Añadir una nueva columna
                DataRow nuevaFila = dt.NewRow();
                nuevaFila["IdSeguridad"] = users.IdSeguridad;
                nuevaFila["Alias"] = users.Alias;
                nuevaFila["Clave"] = users.Clave;
                nuevaFila["FechaModificacion"] = DateTime.Now;
                nuevaFila["ModificadoPor"] = DataRepository.PropiedadesInicioSesion.IdUsuario;
                dt.Rows.Add(nuevaFila);

                // Crear el comando
                myCommand = conn.Comando(modificar);
                using (myCommand)
                {
                    myCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
          
                }
                // Agregar los parámetros
                myCommand.Parameters.Add("@IdSeguridad", SqlDbType.Int, 25, "IdSeguridad");
                myCommand.Parameters.Add("@Alias", SqlDbType.NChar, 15, "Alias");
                myCommand.Parameters.Add("@Clave", SqlDbType.NChar, 30, "Clave");
                myCommand.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 25, "FechaModificacion");
                myCommand.Parameters.Add("@ModificadoPor", SqlDbType.Int, 25, "ModificadoPor");

                // Insertar el departamento
                da.InsertCommand = myCommand;
                da.Update(ds, "Usuario.Usuarios");
                return true;
            }
            catch (SqlException Ex)
            {
                throw Ex;

            }
            finally
            {
                conn.DbClose();
            }
        }
        public void ConsultarIdEmpleado()
        {
            string consultarId = @"Select IdEmpleado From Usuario.Empleado Where Identidad = @identidad";
            SqlCommand commandConsultarId = conn.Comando(consultarId);
            try
            {
                conn.DbOpen();
                using (commandConsultarId)
                {
                    commandConsultarId.Parameters.Add("@identidad", SqlDbType.NChar).Value = UserInterface.Usuarios.frmBuscarEmpleadosSinUsuario.identidad;
                    commandConsultarId.ExecuteNonQuery();
                }
                SqlDataReader rdr = commandConsultarId.ExecuteReader();
                while(rdr.Read())
                {
                    idEmpleadoInsertarUsuario = (rdr.GetInt32(0));
                }
                rdr.Close();
            }
            catch (Exception)
            {
                
                throw;
            } 
        }
        public void ConsultarIdEmpleadoParaModificar(string id)
        {
            string consultarId = @"Select IdEmpleado From Usuario.Empleado Where Identidad = @identidad";
            SqlCommand commandConsultarId = conn.Comando(consultarId);
            try
            {
                conn.DbOpen();
                using (commandConsultarId)
                {
                    commandConsultarId.Parameters.Add("@identidad", SqlDbType.NChar).Value = id;
                    commandConsultarId.ExecuteNonQuery();
                }
                SqlDataReader rdr = commandConsultarId.ExecuteReader();
                while (rdr.Read())
                {
                    IdEmpleadoModificar = (rdr.GetInt32(0));
                }
                rdr.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool ConsultarUsuarioCompleto(string identidad)
        {
            string sqlConsultarId = @"Select IdEmpleado from Usuario.Empleado Where Identidad = @id";
            string sqlConsultarUsuario = @"Select IdUsuario, IdSeguridad, Alias, Clave from Usuario.Usuarios Where IdEmpleado = @idEmpleado";
            string sqlConsultarRol = @"Select Rol from Usuario.Seguridad Where IdSeguridad = @idrol";
            SqlCommand commandRol = conn.Comando(sqlConsultarRol);
            SqlCommand commandConsultar = conn.Comando(sqlConsultarId);
            SqlCommand command = conn.Comando(sqlConsultarUsuario);

            try
            {
                conn.DbOpen();
                using (commandConsultar)
                {
                    commandConsultar.Parameters.Add("@id", SqlDbType.Char, 15).Value = identidad;
                    commandConsultar.ExecuteNonQuery();
                }
                SqlDataReader rdr = commandConsultar.ExecuteReader();
                while (rdr.Read())
                {
                    idEmpleadoModificarUsuario = rdr.GetInt32(0);
                }
                rdr.Close();
                using (command)
                {
                    command.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleadoModificarUsuario;
                    command.ExecuteNonQuery();
                }
                SqlDataReader rdr2 = command.ExecuteReader();
                while (rdr2.Read())
                {
                    idUsuarioAModificar = rdr2.GetInt32(0);
                    idSeguridadModifciarUsuario = rdr2.GetInt32(1);
                    aliasModificarUsuario = rdr2.GetString(2);
                    claveModificarUsuario = rdr2.GetString(3);
                }
                rdr2.Close();
                using (commandRol)
                {
                    commandRol.Parameters.Add("@idrol", SqlDbType.Int).Value = idSeguridadModifciarUsuario;
                    commandRol.ExecuteNonQuery();
                }
                SqlDataReader rdr3 = commandRol.ExecuteReader();
                while (rdr3.Read())
                {
                    rolModificarUsuario = (rdr3.GetString(0));
                }
                rdr3.Close();
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
        public bool SqlInsert(DataRepository.Usuarios users)
        {
            string consultar = @"Select IdEmpleado, IdSeguridad, Alias, Clave, Estado, FechaCreacion, CreadoPor,
                               FechaModificacion, ModificadoPor From Usuario.Usuarios";

            string insertar = @"Insert into Usuario.Usuarios
                                (IdEmpleado, IdSeguridad, Alias, Clave, Estado, FechaCreacion, CreadoPor,
                               FechaModificacion, ModificadoPor)
                                Values (@IdEmpleado, @IdSeguridad, @Alias, @Clave, @Estado, @FechaCreacion, @CreadoPor, 
                                @FechaModificacion, @ModificadoPor)";
            try
            {
                if (frmModificarEmpleado.ingresar == true)
                {
                    ConsultarIdEmpleadoParaModificar(frmAgregarUsuario.identidadDesdeModificarEmpleado);
                    idEmpleadoInsertarUsuario = IdEmpleadoModificar;
                }
                else
                {
                    ConsultarIdEmpleado();
                }
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand myCommand = conn.Comando(consultar);
                da.SelectCommand = myCommand;
                // Crear y popular el Data Set
                DataSet ds = new DataSet();
                da.Fill(ds, "Usuario.Usuarios");

                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["Usuario.Usuarios"];

                // Añadir una nueva columna
                DataRow nuevaFila = dt.NewRow();
                nuevaFila["IdSeguridad"] = users.IdSeguridad;
                nuevaFila["IdEmpleado"] = idEmpleadoInsertarUsuario;
                nuevaFila["Alias"] = users.Alias;
                nuevaFila["Clave"] = users.Clave;
                nuevaFila["Estado"] = users.Estado;
                nuevaFila["FechaCreacion"] = DateTime.Now;
                nuevaFila["CreadoPor"] = DataRepository.PropiedadesInicioSesion.IdUsuario;
                nuevaFila["FechaModificacion"] = DateTime.Now;
                nuevaFila["ModificadoPor"] = DataRepository.PropiedadesInicioSesion.IdUsuario;

                dt.Rows.Add(nuevaFila);

                // Crear el comando
                myCommand = conn.Comando(insertar);

                // Agregar los parámetros
                myCommand.Parameters.Add("@IdEmpleado", SqlDbType.Int, 25, "IdEmpleado");
                myCommand.Parameters.Add("@IdSeguridad", SqlDbType.Int, 25, "IdSeguridad");
                myCommand.Parameters.Add("@Alias", SqlDbType.NChar, 15, "Alias");
                myCommand.Parameters.Add("@Clave", SqlDbType.NChar, 30, "Clave");
                myCommand.Parameters.Add("@Estado", SqlDbType.Bit, 0, "Estado");
                myCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 25, "FechaCreacion");
                myCommand.Parameters.Add("@CreadoPor", SqlDbType.Int, 25, "CreadoPor");
                myCommand.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 25, "FechaModificacion");
                myCommand.Parameters.Add("@ModificadoPor", SqlDbType.Int, 25, "ModificadoPor");
                // Insertar el departamento
                da.InsertCommand = myCommand;
                da.Update(ds, "Usuario.Usuarios");
                return true;
            }
            catch (SqlException Ex)
            {
                throw Ex;

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

        public void ConsultarIdentidad(int id)
        {
            string sqlConsultarId = @"Select Identidad from Usuario.Empleado Where IdEmpleado = @idEmpleado";

            SqlCommand command = conn.Comando(sqlConsultarId);
            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
                SqlDataReader rdr = command.ExecuteReader();
                while(rdr.Read())
                {
                    idEmpleado = (rdr.GetString(0));
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
        public void ConsultarNombreRol(int id)
        {
            string sqlConsultarId = @"Select Rol from Usuario.Seguridad Where IdSeguridad = @idrol";

            SqlCommand command = conn.Comando(sqlConsultarId);
            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@idrol", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    rol = (rdr.GetString(0));
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

        public void ConsultarClave(int id)
        {
            string sqlConsultarId = @"Select Clave from Usuario.Usuarios Where IdUsuario = @idUsuario";

            SqlCommand command = conn.Comando(sqlConsultarId);
            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    clave = (rdr.GetString(0));
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
        public bool InsertarUsuarioAEmpleado(DataRepository.Usuarios usuario)
        {
            string sqlConsultarId = @"Select IdEmpleado from Usuario.Empleado Where Identidad = @id";
            string sqlInsertar = @"Insert into Usuario.Usuarios (IdEmpleado, IdSeguridad, Alias, Clave, Estado, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor) 
                                                         values (@IdEmpleado, @IdSeguridad, @Alias, @Clave, @Estado, @FechaCreacion, @CreadoPor, @FechaModificacion, @ModificadoPor)";
            SqlCommand commandConsultar = conn.Comando(sqlConsultarId);
            SqlCommand command = conn.Comando(sqlInsertar);

            try
            {
                conn.DbOpen();
                using (commandConsultar)
                {
                    if (UserInterface.Usuarios.frmBuscarEmpleadosSinUsuario.identidad == null)
                    {
                        commandConsultar.Parameters.Add("@id", SqlDbType.Char, 15).Value = UserInterface.Usuarios.frmAgregarUsuario.identidad;
                        commandConsultar.ExecuteNonQuery();
                    }
                    else
                    {
                        commandConsultar.Parameters.Add("@id", SqlDbType.Char, 15).Value = UserInterface.Usuarios.frmBuscarEmpleadosSinUsuario.identidad;
                        commandConsultar.ExecuteNonQuery();
                    }
                    
                }
                SqlDataReader rdr = commandConsultar.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr.GetInt32(0);
                }
                rdr.Close();
                using (command)
                {
                    command.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@IdSeguridad", SqlDbType.Int).Value = usuario.IdSeguridad;
                    command.Parameters.Add("@Alias", SqlDbType.NChar).Value = usuario.Alias;
                    command.Parameters.Add("@Clave", SqlDbType.NChar).Value = usuario.Clave;
                    command.Parameters.Add("@Estado", SqlDbType.Bit).Value = true;
                    command.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@CreadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                    command.Parameters.Add("@FechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@ModificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
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
