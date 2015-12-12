using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP.Services
{
    class TelefonosCRUD
    {
        public DataRepository.Conectar Conn = new DataRepository.Conectar();
        public DataRepository.Telefonos NuevoTelefono = new DataRepository.Telefonos();

        // Método que obtendrá los teléfonos
        public void ObtenerTelefonos(int IdClientesProveedores)
        {
            string SqlSelect = @"SELECT NumeroFijo, NumeroMovil FROM Contacto.Telefonos WHERE IdClientesProveedores =@Id ORDER BY FechaCreacion Desc";
            try
            {
                // Estableciendo la conexión
                Conn.DbOpen();

                // Creando el comando
                SqlCommand Command = Conn.Comando(SqlSelect);
                using (Command)
                {
                    Command.Parameters.Add("@Id", SqlDbType.Int).Value = IdClientesProveedores;
                    Command.ExecuteNonQuery();
                }


                // Ejecutando el query por medio de un Execute Reader
                SqlDataReader SDA = Command.ExecuteReader();

                //DataRepository.Telefonos.Telefono.Clear();
                while (SDA.Read())
                {
                    if (IdClienteProveedor != 0)
                    {
                        DataRepository.Telefonos.Telefono.Add(SDA.GetSqlString(0).ToString());
                        DataRepository.Telefonos.Telefono.Add(SDA.GetSqlString(1).ToString());
                        NuevoTelefono.TelefonosFijos.Add((SDA.GetSqlString(0).ToString()));
                        NuevoTelefono.TelefonosMoviles.Add((SDA.GetSqlString(1).ToString()));
                    }
                }
            }
            catch (SqlException Ex)
            {
                throw;
            }

            finally
            {
                Conn.DbClose();
            }
        }
        // Método que agregará los nuevos números de teléfono ingresados
        public bool AgregarNumeros(int IdtipoContacto, int IdEmpleado, string NumeroFijo, string NumeroMovil, int ClientesProveedores)
        {

            string SqlInsert;
            SqlInsert = "INSERT INTO Contacto.Telefonos(IdTipoContacto, IdEmpleado, NumeroFijo, NumeroMovil, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor, IdClientesProveedores) VALUES (@idtipocontacto, @idempleado, @numerofijo, @numeromovil, @fechacreacion, @creadopor, @fechamodificacion, @modificadopor, @idclientesproveedores)";

            try
            {
                SqlCommand Command = Conn.Comando(SqlInsert);

                Conn.DbOpen();
                using (Command)
                {
                    Command.Parameters.Add("@idtipocontacto", SqlDbType.Int).Value = IdtipoContacto;
                    Command.Parameters.Add("@idempleado", SqlDbType.Int).Value = IdEmpleado;
                    Command.Parameters.Add("@numerofijo", SqlDbType.Char, 9).Value = NumeroFijo;
                    Command.Parameters.Add("@numeromovil", SqlDbType.Char, 9).Value = NumeroMovil;
                    Command.Parameters.Add("@fechacreacion", SqlDbType.DateTime).Value = DateTime.Now;
                    Command.Parameters.Add("@creadopor", SqlDbType.Int).Value = 1;
                    Command.Parameters.Add("@fechamodificacion", SqlDbType.DateTime).Value = DateTime.Now;
                    Command.Parameters.Add("@modificadopor", SqlDbType.Int).Value = 1;
                    Command.Parameters.Add("@idclientesproveedores", SqlDbType.Int).Value = ClientesProveedores;
                    Command.ExecuteNonQuery();
                    return true;
                }
            }
            // Captar la excepciones personalizadas
            catch (Bussiness.CustomException Ex)
            {
                return false;
                throw;
            }
             //Captar las excepciones de sql
            catch (SqlException Ex)
            {
                MessageBox.Show("Uno o más números ingresados están repetidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
             //Cerrando la conexión
            finally
            {
                Conn.DbClose();
            }
        }

        int IdTelefono;
        // Método que obtendrá los Id de los teléfonos
        public int ObtenerIdtelefono(int IdClientesProveedores, string Numero, string TipoCampo)
        {

            string SqlSelect = @"SELECT IdTelefono FROM Contacto.Telefonos WHERE IdClientesProveedores =@Id AND " + TipoCampo + "=@Fijo";

            // Establecer la conexión
            Conn.DbOpen();

            // Crear el comando
            SqlCommand Command = Conn.Comando(SqlSelect);
            using (Command)
            {
                Command.Parameters.Add("@Id", SqlDbType.Int).Value = IdClientesProveedores;
                Command.Parameters.Add("@Fijo", SqlDbType.Char, 9).Value = Numero.ToString();
                Command.ExecuteNonQuery();
            }

            try
            {

                // Ejecutar el query via un Execute Reader
                SqlDataReader SDA = Command.ExecuteReader();

                while (SDA.Read())
                {

                    IdTelefono = SDA.GetInt32(0);

                }
                return IdTelefono;
            }
            // Captar las excepciones de sql
            catch (SqlException Ex)
            {
                return 0;
            }
            // Captar las excepciones de referencias nulas
            catch (NullReferenceException Ex)
            {
                MessageBox.Show("No se ha seleccionado ningún teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                Conn.DbClose();
            }
        }
        // Método que actualizará los teléfonos
        public void ActulizarTelefono(int Idtelefono, bool TipoCampo, string NuevoNumero)
        {

            string SqlUpdate = @"UPDATE Contacto.Telefonos SET " + TipoCampo + "=@Numero WHERE IdTelefono =@Id";

            // Establecer la conexión
            Conn.DbOpen();

            try
            {


                // Crear el comando
                SqlCommand Command = Conn.Comando(SqlUpdate);
                using (Command)
                {
                    Command.Parameters.Add("@Id", SqlDbType.Int).Value = Idtelefono;
                    Command.Parameters.Add("@Numero", SqlDbType.Char, 9).Value = NuevoNumero;
                    Command.ExecuteNonQuery();
                }


            }
            catch (SqlException Ex)
            {
                MessageBox.Show("Ya existe un teléfono con los valores especificados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conn.DbClose();
            }
        }
        int IdClienteProveedor;
        // Método que obtendrá la Id del cliente/Proveedor 
        public int ObtenerIdClientesProveedor(string Id)
        {
            string SqlSelect = @"SELECT IdClientesProveedores FROM ClienteProveedor.Clientes_Proveedores WHERE RTN =@Id";
            // Establecer la conexión
            Conn.DbOpen();



            try
            {
                // Crear el comando
                SqlCommand Command = Conn.Comando(SqlSelect);
                using (Command)
                {
                    Command.Parameters.Add("@Id", SqlDbType.Char, 14).Value = Id;
                    Command.ExecuteNonQuery();
                }
                // Ejecutar el query via un Execute Reader
                SqlDataReader SDA = Command.ExecuteReader();

                while (SDA.Read())
                {

                    IdClienteProveedor = SDA.GetInt32(0);

                }
                SDA.Close();
                return IdClienteProveedor;
            }
            // Captar las excepciones de Sql
            catch (SqlException Ex)
            {
                return 0;
            }
            finally
            {
                Conn.DbClose();
            }
        }

    }
}
