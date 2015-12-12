using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace ERP.Services
{
    class ClientesProveedoresCRUD
    {
        // Creando la conexión mediante un objeto.
        DataRepository.Conectar conn = new DataRepository.Conectar();
        // Creando el método que agregará a los Clientes/Proveedores.
        public bool SqlAgregar(DataRepository.ClientesProveedores CP)
        {
            // Creando los querys que consultarán y agregarán la información de los clientes/proveedores

            string Consulta = @"SELECT * FROM ClienteProveedor.Clientes_Proveedores";

            string Agregar = @"INSERT INTO ClienteProveedor.Clientes_Proveedores
                               (RTN, Nombres, Apellidos, CorreoElectronico, Direccion, TipoUsuarioCompraVenta, EstadoClienteProveedor, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor,Observaciones)
                               VALUES (@rtn, @nombres, @apellidos, @correoelectronico, @direccion, @tipousuariocompraventa, @estadoclienteproveedor, @fechacreacion, @creadopor, @fechamodificacion, @modificadopor,@observaciones)";
            try
            {
                // Creando el Data Adapter
                SqlDataAdapter SDA = new SqlDataAdapter();

                // Creando el comando que consultará
                SqlCommand SelCommand = conn.Comando(Consulta);
                SDA.SelectCommand = SelCommand;

                // Creando y populando el Dataset
                DataSet DS = new DataSet();
                SDA.Fill(DS, "ClienteProveedor.Clientes_Proveedores");

                // Obteniendo la tabla de referencia
                DataTable DT = DS.Tables["ClienteProveedor.Clientes_Proveedores"];

                // Añadiendo una nueva columna
                DataRow nuevaFila = DT.NewRow();
                nuevaFila["RTN"] = CP.RTN;
                nuevaFila["Nombres"] = CP.Nombres;
                nuevaFila["Apellidos"] = CP.Apellidos;
                nuevaFila["CorreoElectronico"] = CP.CorreoElectronico;
                nuevaFila["Direccion"] = CP.Direccion;
                nuevaFila["TipoUsuarioCompraVenta"] = CP.TipoUsuarioCompraVenta;
                nuevaFila["EstadoClienteProveedor"] = CP.EstadoClienteProveedor;
                nuevaFila["FechaCreacion"] = CP.FechaCreacion;
                nuevaFila["CreadoPor"] = CP.CreadoPor;
                nuevaFila["FechaModificacion"] = CP.FechaModificacion;
                nuevaFila["ModificadoPor"] = CP.ModificadoPor;
                nuevaFila["Observaciones"] = CP.ModificadoPor;
                DT.Rows.Add(nuevaFila);

                // Creando el Comando
                SelCommand = conn.Comando(Agregar);

                // Agregando los parámetros
                SelCommand.Parameters.Add("@rtn", SqlDbType.NChar, 14, "RTN");
                SelCommand.Parameters.Add("@nombres", SqlDbType.VarChar, 30, "Nombres");
                SelCommand.Parameters.Add("@apellidos", SqlDbType.VarChar, 30, "Apellidos");
                SelCommand.Parameters.Add("@correoelectronico", SqlDbType.NVarChar, 30, "CorreoElectronico");
                SelCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 30, "Direccion");
                SelCommand.Parameters.Add("@tipousuariocompraventa", SqlDbType.Bit, 30, "TipoUsuarioCompraVenta");
                SelCommand.Parameters.Add("@estadoclienteproveedor", SqlDbType.Bit, 30, "EstadoClienteProveedor");
                SelCommand.Parameters.Add("@fechacreacion", SqlDbType.DateTime, 30, "FechaCreacion");
                SelCommand.Parameters.Add("@creadopor", SqlDbType.Int, 30, "CreadoPor");
                SelCommand.Parameters.Add("@fechamodificacion", SqlDbType.DateTime, 30, "FechaModificacion");
                SelCommand.Parameters.Add("@modificadopor", SqlDbType.Int, 30, "ModificadoPor");
                SelCommand.Parameters.Add("@observaciones", SqlDbType.Text, 255, "Observaciones");

                // Insertando los datos
                SDA.InsertCommand = SelCommand;
                SDA.Update(DS, "ClienteProveedor.Clientes_Proveedores");
                return true;
            }
            // Captar la excepción personalizada
            catch (Bussiness.CustomException EX)
            {
                return false;
                throw;
            }
            // Captar las excepciones de Sql
            catch (SqlException Ex)
            {
                MessageBox.Show("El RTN ingresado ya está en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
             //Captar las excepciones de tipos de Sql
            catch (SqlTypeException Ex)
            {
                MessageBox.Show("Uno o más campos no han sido agregados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Cerrando la conexión
                conn.DbClose();
            }
        }
        public List<DataRepository.ClientesProveedores> ConsultarIdProveedor()
        {
            string sqlConsultar = @"SELECT IdClientesProveedores, Nombres FROM ClienteProveedor.Clientes_Proveedores WHERE TipoUsuarioCompraVenta = 'True'";
            ComboBox cbIdProveedor = new ComboBox();
            SqlCommand command2 = conn.Comando(sqlConsultar);
            DataRepository.ClientesProveedores Proveedor = new DataRepository.ClientesProveedores();
            List<DataRepository.ClientesProveedores> listaId = new List<DataRepository.ClientesProveedores>();

            try
            {
                conn.DbOpen();
                SqlDataReader rdr = command2.ExecuteReader();
                while (rdr.Read())
                {
                    Proveedor = new DataRepository.ClientesProveedores();
                    Proveedor.IdClientesProveedores = rdr.GetInt32(0);
                    Proveedor.Nombres = rdr.GetString(1);
                    listaId.Add(Proveedor);
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
        public void PopularDataGridClienteProveedor(DataGridView clienteProveedor)
        {
            string sql;

            sql = @"Select * From ClienteProveedor.Clientes_Proveedores";
            // Crear la conexión

            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "ClienteProveedor.Clientes_Proveedores");
                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["ClienteProveedor.Clientes_Proveedores"];

                DataView dv = new DataView(dt, "", "FechaModificacion ASC", DataViewRowState.Unchanged);

                clienteProveedor.DataSource = dv;
                clienteProveedor.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
        }
        //Consultar Cliente
        public void PopularDataGridCliente(DataGridView cliente)
        {
            string sql;

            sql = @"Select * From ClienteProveedor.Clientes_Proveedores WHERE TipoUsuarioCompraVenta = 0";
            // Crear la conexión

            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "ClienteProveedor.Clientes_Proveedores");
                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["ClienteProveedor.Clientes_Proveedores"];

                DataView dv = new DataView(dt, "", "FechaModificacion ASC", DataViewRowState.Unchanged);

                cliente.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
        }

        //Consultar Proveedor
        public void PopularDataGridProveedor(DataGridView proveedor)
        {
            string sql;

            sql = @"Select * From ClienteProveedor.Clientes_Proveedores WHERE TipoUsuarioCompraVenta = 1";
            // Crear la conexión

            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "ClienteProveedor.Clientes_Proveedores");
                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["ClienteProveedor.Clientes_Proveedores"];

                DataView dv = new DataView(dt, "", "FechaModificacion ASC", DataViewRowState.Unchanged);

                proveedor.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
        }
        public void PopularDataGridSucursal(DataGridView sucursal)
        {
            string sql;

            sql = @"Select * From ClienteProveedor.Sucursal";
            // Crear la conexión

            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "ClienteProveedor.Sucursal");
                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["ClienteProveedor.Sucursal"];

                DataView dv = new DataView(dt, "", "FechaModificacion ASC", DataViewRowState.Unchanged);

                sucursal.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                // Cerrar la conexión
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
        //Dar de Baja
        public static List<DataRepository.PropiedadesClienteProveedor> CargarRTN()
        {
            DataRepository.Conectar conn = new DataRepository.Conectar();

            string sql;
            List<DataRepository.PropiedadesClienteProveedor> resultados = new List<DataRepository.PropiedadesClienteProveedor>();

            sql = @"Select RTN From ClienteProveedor.Clientes_Proveedores";

            SqlCommand myCommand = conn.Comando(sql);

            try
            {
                conn.DbOpen();

                SqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    DataRepository.PropiedadesClienteProveedor proveedorCliente = new DataRepository.PropiedadesClienteProveedor();
                    proveedorCliente.RTN = rdr.GetString(0);
                    resultados.Add(proveedorCliente);
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