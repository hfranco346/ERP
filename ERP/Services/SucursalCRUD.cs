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
    class SucursalCRUD
    {
        // Creando la conexión mediante un objeto.
        DataRepository.Conectar conn = new DataRepository.Conectar();

        DataRepository.ClientesProveedores cliente = new DataRepository.ClientesProveedores();
        // Creando el método que agregará las sucursales.
        public bool sqlAgregar(DataRepository.Sucursal Srl)
        {
            // Creando los querys que consultarán y agregarán la información de las sucursales

            string Consulta = @"SELECT * FROM ClienteProveedor.Sucursal";

            string Agregar = @"INSERT INTO ClienteProveedor.Sucursal
                               (NombreSucursal, DireccionSucursal, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor, IdClientesProveedores,Observaciones,EstadoSucursal)
                               VALUES (@nombresucursal, @direccionsucursal, @fechacreacion, @creadopor, @fechamodificacion, @modificadopor, @idclientesproveedores,@observaciones,@estadoSucursal)";

            try
            {
                // Creando el DataAdapter 
                SqlDataAdapter SDA = new SqlDataAdapter();

                // Creando el comando que consultará
                SqlCommand SelCommand = conn.Comando(Consulta);
                SDA.SelectCommand = SelCommand;

                // Creando y populando el Dataset
                DataSet DS = new DataSet();
                SDA.Fill(DS, "ClienteProveedor.Sucursal");

                // Obteniendo la tabla de referencia
                DataTable DT = DS.Tables["ClienteProveedor.Sucursal"];

                // Añadiendo una nueva columna
                DataRow nuevaFila = DT.NewRow();
                nuevaFila["NombreSucursal"] = Srl.NombreSucursal;
                nuevaFila["DireccionSucursal"] = Srl.DireccionSucursal;
                nuevaFila["FechaCreacion"] = Srl.FechaCreacion;
                nuevaFila["CreadoPor"] = Srl.CreadoPor;
                nuevaFila["FechaModificacion"] = Srl.FechaModificacion;
                nuevaFila["ModificadoPor"] = Srl.ModificadoPor;
                nuevaFila["IdClientesProveedores"] = Srl.IdClientesProveedores;
                nuevaFila["Observaciones"] = "Sucursal creada";
                nuevaFila["EstadoSucursal"] = 1;
                DT.Rows.Add(nuevaFila);

                // Creando el Comando
                SelCommand = conn.Comando(Agregar);

                // Agregando los parámetros
                SelCommand.Parameters.Add("@nombresucursal", SqlDbType.VarChar, 30, "NombreSucursal");
                SelCommand.Parameters.Add("@direccionsucursal", SqlDbType.Text, 50, "DireccionSucursal");
                SelCommand.Parameters.Add("@fechacreacion", SqlDbType.DateTime, 30, "FechaCreacion");
                SelCommand.Parameters.Add("@creadopor", SqlDbType.Int, 30, "CreadoPor");
                SelCommand.Parameters.Add("@fechamodificacion", SqlDbType.DateTime, 30, "FechaModificacion");
                SelCommand.Parameters.Add("@modificadopor", SqlDbType.Int, 30, "ModificadoPor");
                SelCommand.Parameters.Add("@idclientesproveedores", SqlDbType.Int, 30, "IdClientesProveedores");
                SelCommand.Parameters.Add("@observaciones", SqlDbType.Text, 255, "Observaciones");
                SelCommand.Parameters.Add("@estadoSucursal", SqlDbType.Bit, 1, "EstadoSucursal");

                // Insertando los datos
                SDA.InsertCommand = SelCommand;
                SDA.Update(DS, "ClienteProveedor.Sucursal");
                return true;
            }
            // Captar las excepciones personalizadas
            catch (Bussiness.CustomException EX)
            {
                return false;
                throw;
            }
            // Captar las excepciones de sql
            catch (SqlException Ex)
            {
                MessageBox.Show("El proveedor ya se encuentra en esta Sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Cerrando la conexión
                conn.DbClose();
            }
        }
        int IdClienteProveedor;
        public int ObtenerIdClientesProveedor(string Id)
        {
            string SqlSelect = @"SELECT IdClientesProveedores, Nombres, Apellidos FROM ClienteProveedor.Clientes_Proveedores WHERE RTN =@Id";

            // Establecer la conexión
            conn.DbOpen();

            // Crear el comando
            SqlCommand Command = conn.Comando(SqlSelect);
            using (Command)
            {
                Command.Parameters.Add("@Id", SqlDbType.Char, 14).Value = Id;
                Command.ExecuteNonQuery();
            }

            try
            {

                // Ejecutar el query via un Execute Reader
                SqlDataReader SDA = Command.ExecuteReader();

                while (SDA.Read())
                {

                    IdClienteProveedor = SDA.GetInt32(0);
                    cliente.IdClientesProveedores = SDA.GetInt32(0);
                    cliente.Nombres = SDA.GetString(1);
                    cliente.Apellidos = SDA.GetString(2);
                    

                }
                return IdClienteProveedor;
            }

            catch (SqlException Ex)
            {
                return 0;
            }
            finally
            {
                conn.DbClose();
            }
        }
        // Método que hará una lista con la Id de la sucursal y el nombre de la misma

        public List<DataRepository.Sucursal> ConsultarIdSucursal()
        {
            string sqlConsultar = @"SELECT IdSucursal, NombreSucursal FROM ClienteProveedor.Sucursal";
            ComboBox cbIdSucursal = new ComboBox();
            SqlCommand command2 = conn.Comando(sqlConsultar);
            DataRepository.Sucursal Sucursal = new DataRepository.Sucursal();
            List<DataRepository.Sucursal> listaId = new List<DataRepository.Sucursal>();

            try
            {
                conn.DbOpen();
                SqlDataReader rdr = command2.ExecuteReader();
                while (rdr.Read())
                {
                    Sucursal = new DataRepository.Sucursal();
                    Sucursal.IdSucursal = rdr.GetInt32(0);
                    Sucursal.NombreSucursal = rdr.GetString(1);
                    listaId.Add(Sucursal);
                }

                return listaId;

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
        public static List<DataRepository.PropiedadesClienteProveedorsucursales> CargarNombreSucursal()
        {
            DataRepository.Conectar conn = new DataRepository.Conectar();

            string sql;
            List<DataRepository.PropiedadesClienteProveedorsucursales> resultados = new List<DataRepository.PropiedadesClienteProveedorsucursales>();

            sql = @"Select NombreSucursal From ClienteProveedor.Sucursal";

            SqlCommand myCommand = conn.Comando(sql);

            try
            {
                conn.DbOpen();
                SqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    DataRepository.PropiedadesClienteProveedorsucursales sucursales = new DataRepository.PropiedadesClienteProveedorsucursales();
                    sucursales.NombreSucursal = rdr.GetString(0);
                    resultados.Add(sucursales);
                }

                return resultados;
            }
            catch (Exception ex)
            {
                return resultados;
            }
            finally
            {
                conn.DbClose();
            }
        }


    }
}
