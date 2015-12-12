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
    class OperacionesTelefonos
    {
        public DataRepository.Conectar Conn = new DataRepository.Conectar();
        public DataRepository.PropiedadesTelefonos Nuevofrm = new DataRepository.PropiedadesTelefonos();
        public static bool validacionTelefonos = false;
        public void ObtenerTelefonos(int IdEmpleado)
        {
            string sql = @"Select NumeroFijo,NumeroMovil From Contacto.Telefonos WHERE IdEmpleado =@Id Order by FechaCreacion Desc";
            
            try
            {
                // Establecer la conexión
                Conn.DbOpen();
                // Crear el comando
                SqlCommand cmd = Conn.Comando(sql);
                using (cmd)
                { cmd.Parameters.Add("@Id", SqlDbType.Int).Value = IdEmpleado; 
                    cmd.ExecuteNonQuery(); 
                }
                // Ejecutar el query via un Execute Reader
                SqlDataReader rdr = cmd.ExecuteReader();

                DataRepository.PropiedadesTelefonos.Telefonos.Clear();
                while (rdr.Read())
                {
                    DataRepository.PropiedadesTelefonos.Telefonos.Add(rdr.GetSqlString(0).ToString());
                    DataRepository.PropiedadesTelefonos.Telefonos.Add(rdr.GetSqlString(1).ToString());
                    Nuevofrm.TelefonosFijos.Add((rdr.GetSqlString(0).ToString()));
                    Nuevofrm.TelefonosMoviles.Add((rdr.GetSqlString(1).ToString()));

                }

            }
            catch (SqlException ex)
            {

            }
            finally
            {
                Conn.DbClose();
            }
        }

        public void AgregarNumeros(bool idTipoContacto,int IdEmpleado, string NumeroFijo, string NumeroMovil, int ClienteProveedor)
        {
            string sql;
            sql = "Insert into Contacto.Telefonos(IdTipoContacto, IdEmpleado, NumeroFijo, NumeroMovil, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor, IdClientesProveedores) values (@idtipocontacto, @idempleado, @numerofijo, @numeromovil, @fechacreacion, @creadopor, @fechamodificacion, @modificadopor, @idclienteproveedor)";
            SqlCommand cmd = Conn.Comando(sql);

            try
            {
                Conn.DbOpen();
                using (cmd)
                {

                    cmd.Parameters.Add("@idtipocontacto", SqlDbType.Bit).Value = idTipoContacto;
                    cmd.Parameters.Add("@idempleado", SqlDbType.Int).Value = IdEmpleado;
                    cmd.Parameters.Add("@numerofijo", SqlDbType.Char, 9).Value = NumeroFijo;
                    cmd.Parameters.Add("@numeromovil", SqlDbType.Char, 9).Value = NumeroMovil;
                    cmd.Parameters.Add("@fechacreacion", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@creadopor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                    cmd.Parameters.Add("@fechamodificacion", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@modificadopor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                    cmd.Parameters.Add("@idclienteproveedor", SqlDbType.Int).Value = ClienteProveedor;
                    cmd.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ya existe telefono","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            finally
            {

                Conn.DbClose();

            }
        }
        int IdTelefono;
        public int ObtenerIdtelefono(int IdEmpleado, string Numero, string TipoCampo)
        {
            string sql = @"Select IdTelefono From Contacto.Telefonos WHERE IdEmpleado =@Id and " + TipoCampo + "=@Fijo";
         
            try
            {
                // Establecer la conexión
                Conn.DbOpen();

                // Crear el comando
                SqlCommand cmd = Conn.Comando(sql);
                using (cmd)
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = IdEmpleado;
                    cmd.Parameters.Add("@Fijo", SqlDbType.Char, 9).Value = Numero.ToString();
                    cmd.ExecuteNonQuery();
                }
                // Ejecutar el query via un Execute Reader
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    IdTelefono = rdr.GetInt32(0);
                }
                return IdTelefono;
            }
            catch (SqlException ex)
            {
                return 0;
            }
            finally
            {
                Conn.DbClose();
            }
        }

        public void ActulizarTelefono(int Idtelefono, string TipoCampo, string NuevoNumero)
        {
            string sql = @"Update Contacto.Telefonos set " + TipoCampo + "=@Numero,ModificadoPor=@modificadopor,FechaModificacion=@fecha WHERE IdTelefono =@Id";

            try
            {
                // Establecer la conexión
                Conn.DbOpen();
                // Crear el comando
                SqlCommand cmd = Conn.Comando(sql);
                using (cmd)
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Idtelefono;
                    cmd.Parameters.Add("@Numero", SqlDbType.Char, 9).Value = NuevoNumero;
                    cmd.Parameters.Add("@modificadopor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario; 
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Uno o ambos teléfonos ya estan registrados.");
                validacionTelefonos = true;

            }
            finally
            {
                Conn.DbClose();
            }
        }
    }
}
