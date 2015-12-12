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
    class OperacionesEmpleado
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public static string cargo;
        public int idEmpleado;
        public static bool validacionIdentidad;
        public int ayudaComprobacion;
        public static int comprobarIdEmpleado;
        public static int idEmpleadoTelefono;
        public bool InsertarEmpleado(DataRepository.PropiedadesEmpleado empleado)
        {
            string sqlInsertar = @"Insert into Usuario.Empleado (Identidad, Nombres, Apellidos, Direccion, Genero, EstadoCivil, EstadoEmpleado, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor, Id_PuestoEmpleado) 
                                                         values (@Identidad, @Nombres, @Apellidos, @Direccion, @Genero, @EstadoCivil, @EstadoEmpleado, @FechaCreacion, @CreadoPor, @FechaModificacion, @ModificadoPor, @Id_PuestoEmpleado)";

            SqlCommand command = conn.Comando(sqlInsertar);

            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@Identidad", SqlDbType.Char, 15).Value = empleado.Identidad;
                    command.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = empleado.Nombres;
                    command.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = empleado.Apellidos;
                    command.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = empleado.Direccion;
                    command.Parameters.Add("@Genero", SqlDbType.Bit).Value = empleado.Genero;
                    command.Parameters.Add("@EstadoCivil", SqlDbType.Bit).Value = empleado.EstadoCivil;
                    command.Parameters.Add("@EstadoEmpleado", SqlDbType.Bit).Value = empleado.EstadoEmpleado;
                    command.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@CreadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                    command.Parameters.Add("@FechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@ModificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                    command.Parameters.Add("@Id_PuestoEmpleado", SqlDbType.Int).Value = empleado.Id_PuestoEmpleado;
                    command.ExecuteNonQuery();
                }
                validacionIdentidad = true;
                return validacionIdentidad;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("¡La identidad del empleado que intenta ingresar ya existe!");
                validacionIdentidad = false;
                return validacionIdentidad;
            }
            finally
            {
                conn.DbClose();
            }
        }

        public List<DataRepository.PropiedadesCargosEmpleado> ConsultarCargos()
        {
            string sqlConsultar = @"Select Id_PuestoEmpleado, Nombre_Puesto from Usuario.Puesto_Empleados";
            ComboBox cbCargo = new ComboBox();
            SqlCommand command2 = conn.Comando(sqlConsultar);
            DataRepository.PropiedadesCargosEmpleado cargo = new DataRepository.PropiedadesCargosEmpleado();
            List<DataRepository.PropiedadesCargosEmpleado> miLista = new List<DataRepository.PropiedadesCargosEmpleado>();

            try
            {
                string g;
                conn.DbOpen();
                SqlDataReader rdr = command2.ExecuteReader();
                while (rdr.Read())
                {
                    cargo = new DataRepository.PropiedadesCargosEmpleado();
                    cargo.Id_PuestoEmpleado = rdr.GetInt32(0);
                    cargo.Nombre_Puesto = rdr.GetString(1);
                    miLista.Add(cargo);
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
        public void ConsultarNombreCargo(int id)
        {
            string sqlConsultarId = @"Select Nombre_Puesto from Usuario.Puesto_Empleados Where Id_PuestoEmpleado = @idcargo";

            SqlCommand command = conn.Comando(sqlConsultarId);
            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@idcargo", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    cargo = (rdr.GetString(0));
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
        public void ConsultarId(string id)
        {
            string sqlConsultarId = @"Select IdEmpleado from Usuario.Empleado Where Identidad = @id";

            SqlCommand command = conn.Comando(sqlConsultarId);
            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@id", SqlDbType.Char).Value = id;
                    command.ExecuteNonQuery();
                }
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    idEmpleadoTelefono = (rdr.GetInt32(0));
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

        public bool ModificarEmpleado(DataRepository.PropiedadesEmpleado empleado, string id)
        {
            string sqlModificar = @"Update Usuario.Empleado set Nombres = @nombres, Apellidos = @apellidos, Direccion = @direccion, Genero = @genero, EstadoCivil = @estadoCivil,
                                    FechaModificacion = @fechaModificacion, ModificadoPor = @modificadoPor, Id_PuestoEmpleado = @cargo Where Identidad = @id";
            SqlCommand command = conn.Comando(sqlModificar);
            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@id", SqlDbType.Char).Value = id;
                    command.Parameters.Add("@nombres", SqlDbType.VarChar).Value = empleado.Nombres;
                    command.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = empleado.Apellidos;
                    command.Parameters.Add("@direccion", SqlDbType.VarChar).Value = empleado.Direccion;
                    command.Parameters.Add("@genero", SqlDbType.Bit).Value = empleado.Genero;
                    command.Parameters.Add("@estadoCivil", SqlDbType.Bit).Value = empleado.EstadoCivil;
                    command.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                    command.Parameters.Add("@cargo", SqlDbType.Int).Value = empleado.Id_PuestoEmpleado;
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
        public bool DarDeBaja(bool Estado, string id)
        {
            string sqlModificar = @"Update Usuario.Empleado set EstadoEmpleado =@estado, FechaModificacion = @fechaModificacion, ModificadoPor = @modificadoPor where Identidad = @Id";
            string sqlConsultarIdPorIdentidad = @"Select IdEmpleado from Usuario.Empleado Where Identidad = @Id";
            string sqlDarBajaUsuario = @"Update Usuario.Usuarios set Estado = @estado, FechaModificacion = @fechaModificacion, ModificadoPor = @modificadoPor Where IdEmpleado=@Id";
            SqlCommand command = conn.Comando(sqlModificar);
            SqlCommand commandConsultar = conn.Comando(sqlConsultarIdPorIdentidad);
            SqlCommand commandDBU = conn.Comando(sqlDarBajaUsuario);
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
                using (commandConsultar)
                {
                    commandConsultar.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                    commandConsultar.ExecuteNonQuery();

                }
                SqlDataReader rdr = commandConsultar.ExecuteReader();
                while (rdr.Read())
                {
                    idEmpleado = (rdr.GetInt32(0));
                }
                rdr.Close();
                using (commandDBU)
                {
                    commandDBU.Parameters.Add("@Id", SqlDbType.Char).Value = idEmpleado;
                    commandDBU.Parameters.Add("@estado", SqlDbType.Bit).Value = Estado;
                    commandDBU.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;
                    commandDBU.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                    commandDBU.ExecuteNonQuery();

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
        public void ConsultarSiTieneUsuario(string id)
        {
            string sqlConsultar = @"Select IdEmpleado from Usuario.Empleado where Identidad = @id and exists (Select IdEmpleado from Usuario.Usuarios Where Usuario.Usuarios.IdEmpleado = Usuario.Empleado.IdEmpleado)";
            SqlCommand command = conn.Comando(sqlConsultar);

            try
            {
                conn.DbOpen();
                using (command)
                {
                    command.Parameters.Add("@id", SqlDbType.Char).Value = id;
                    command.ExecuteNonQuery();
                }
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    ayudaComprobacion= (rdr.GetInt32(0));
                }
                comprobarIdEmpleado = ayudaComprobacion;
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
    }
}
