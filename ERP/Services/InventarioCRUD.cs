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
    class InventarioCRUD
    {
        //Creando el objeto de conexion
        DataRepository.Conectar conn = new DataRepository.Conectar();
        //Creacion de un objeto Impuesto para obtener el idInventario
        //Creacion del metodo SqlInsert que nos ayudará a insertar el producto
        public bool SqlInsert(DataRepository.Inventario Producto)
        {
            string consultar = @"Select * From Inventario.Inventario";

            string insertar = @"Insert into Inventario.Inventario
                                (CodigoBarra, NombreProducto, DescripcionProducto, CantidadProducto, PrecioCompra, PrecioVenta, PuntoReorden, FechaElaboracionProducto, FechaVencimientoProducto, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor, EstadoProducto,Observaciones,IdProveedor)
                                Values (@codigoBarra, @nombreProducto, @descripcionProducto, @cantidadProducto, @precioCompra, @precioVenta, @puntoReorden, @fechaElaboracionProducto, @fechaVencimientoProducto, @fechaCreacion, @creadoPor, @fechaModificacion, @modificadoPor, @estadoProducto,@observaciones,@idProveedor)";
            try
            {

                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand myCommand = conn.Comando(consultar);
                da.SelectCommand = myCommand;
                // Crear y popular el Data Set
                DataSet ds = new DataSet();
                da.Fill(ds, "Inventario.Inventario");

                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["Inventario.Inventario"];

                // Añadir una nueva columna
                DataRow nuevaFila = dt.NewRow();
                nuevaFila["CodigoBarra"] = Producto.CodigoBarra;
                nuevaFila["NombreProducto"] = Producto.NombreProducto;
                nuevaFila["DescripcionProducto"] = Producto.DescripcionProducto;
                nuevaFila["CantidadProducto"] = Producto.CantidadProducto;
                nuevaFila["PrecioCompra"] = Producto.PrecioCompra;
                nuevaFila["PrecioVenta"] = Producto.PrecioVenta;
                nuevaFila["PuntoReorden"] = Producto.PuntoReorden;
                nuevaFila["FechaElaboracionProducto"] = Producto.FechaElaboracionProducto;
                nuevaFila["FechaVencimientoProducto"] = Producto.FechaVencimientoProducto;
                nuevaFila["FechaCreacion"] = Producto.FechaCreacion;
                nuevaFila["CreadoPor"] = Producto.CreadoPor;
                nuevaFila["FechaModificacion"] = Producto.FechaModificacion;
                nuevaFila["ModificadoPor"] = Producto.ModificadoPor;
                nuevaFila["EstadoProducto"] = 1;
                nuevaFila["Observaciones"] = "Producto Creado";
                nuevaFila["IdProveedor"] = Producto.IdProveedor;
                dt.Rows.Add(nuevaFila);

                // Crear el comando
                myCommand = conn.Comando(insertar);

                // Agregar los parámetros
                myCommand.Parameters.Add("@codigoBarra", SqlDbType.VarChar, 25, "CodigoBarra");
                myCommand.Parameters.Add("@nombreProducto", SqlDbType.Text,255, "NombreProducto");
                myCommand.Parameters.Add("@descripcionProducto", SqlDbType.Text, 255, "DescripcionProducto");
                myCommand.Parameters.Add("@cantidadProducto", SqlDbType.Int, 50, "CantidadProducto");
                myCommand.Parameters.Add("@precioCompra", SqlDbType.Money, 50, "PrecioCompra");
                myCommand.Parameters.Add("@precioVenta", SqlDbType.Money, 50, "PrecioVenta");
                myCommand.Parameters.Add("@puntoReorden", SqlDbType.Int, 50, "PuntoReorden");
                myCommand.Parameters.Add("@fechaElaboracionProducto", SqlDbType.DateTime, 25, "FechaElaboracionProducto");
                myCommand.Parameters.Add("@fechaVencimientoProducto", SqlDbType.DateTime, 25, "FechaVencimientoProducto");
                myCommand.Parameters.Add("@fechaCreacion", SqlDbType.DateTime, 25, "FechaCreacion");
                myCommand.Parameters.Add("@creadoPor", SqlDbType.Int, 25, "CreadoPor");
                myCommand.Parameters.Add("@fechaModificacion", SqlDbType.DateTime, 25, "FechaModificacion");
                myCommand.Parameters.Add("@modificadoPor", SqlDbType.Int, 25, "ModificadoPor");
                myCommand.Parameters.Add("@estadoProducto", SqlDbType.Bit, 25, "EstadoProducto");
                myCommand.Parameters.Add("@idProveedor", SqlDbType.Int, 25, "IdProveedor");
                myCommand.Parameters.Add("@observaciones", SqlDbType.Text, 255, "Observaciones");

                // Insertar el Producto
                da.InsertCommand = myCommand;
                da.Update(ds, "Inventario.Inventario");
                
                return true;
            }
            catch (Bussiness.CustomException Ex)
            {
                return false;
                throw Ex;

            }
            finally
            {
                //Cerrar la conexion
                conn.DbClose();
            }
        }
        //Llenar el combobox con los productos disponibles que esten en estado activo
        public void PopularComboboxProducto(ComboBox cbProducto)
        {
            // Query
            string sql = @"Select IdInventario, NombreProducto From Inventario.Inventario
                           Where EstadoProducto = 1";


            // Crear el Comando para consulta
            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "Inventario.Inventario");
                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["Inventario.Inventario"];

                DataView dv = new DataView(dt, "", "NombreProducto ASC", DataViewRowState.Unchanged);
                cbProducto.DataSource = dv;
                cbProducto.DisplayMember = "NombreProducto";
                cbProducto.ValueMember = "IdInventario";
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
        //Llenar el combobox con los proveedores disponibles que esten en estado activo
        public void PopularComboboxProveedor(ComboBox cbProveedores)
        {
            // Query
            string sql = @"Select IdClientesProveedores, Nombres From ClienteProveedor.Clientes_Proveedores
                           Where  TipoUsuarioCompraVenta = 1 and EstadoClienteProveedor = 1";


            // Crear el Comando para consulta
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

                DataView dv = new DataView(dt, "", "Nombres ASC", DataViewRowState.Unchanged);
                cbProveedores.DataSource = dv;
                cbProveedores.DisplayMember = "Nombres";
                cbProveedores.ValueMember = "IdClientesProveedores";
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
        //Insertar Impuesto
        public bool SqlInsertarImpuesto(DataRepository.Impuesto Impuesto)
        {
            string consultar = @"Select * From Inventario.Impuesto";
            string insertar = @"Insert into Inventario.Impuesto
                                (Descripcion, Valor, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor,IdInventario, EstadoImpuesto,Observaciones)
                                Values (@descripcion, @valor, @fechaCreacion, @creadoPor, @fechaModificacion, @modificadoPor,@idInventario, @estadoImpuesto,@observaciones)";
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand myCommand = conn.Comando(consultar);
                da.SelectCommand = myCommand;
                // Crear y popular el Data Set
                DataSet ds = new DataSet();
                da.Fill(ds, "Inventario.Impuesto");

                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["Inventario.Impuesto"];

                // Añadir una nueva columna
                DataRow nuevaFila = dt.NewRow();
                
                nuevaFila["Descripcion"] = Impuesto.DescripcionImpuesto;
                nuevaFila["Valor"] = Impuesto.Valor;
                nuevaFila["FechaCreacion"] = Impuesto.FechaCreacion;
                nuevaFila["CreadoPor"] = Impuesto.CreadoPor;
                nuevaFila["FechaModificacion"] = Impuesto.FechaModificacion;
                nuevaFila["ModificadoPor"] = Impuesto.ModificadoPor;
                nuevaFila["IdInventario"] = Impuesto.IdInventario;
                nuevaFila["EstadoImpuesto"] = 1;
                nuevaFila["Observaciones"] = "";
                
                dt.Rows.Add(nuevaFila);

                // Crear el comando
                myCommand = conn.Comando(insertar);

                // Agregar los parámetros
                myCommand.Parameters.Add("@descripcion", SqlDbType.NVarChar, 50, "Descripcion");
                myCommand.Parameters.Add("@valor", SqlDbType.Decimal, 25, "Valor");
                myCommand.Parameters.Add("@fechaCreacion", SqlDbType.DateTime, 25, "FechaCreacion");
                myCommand.Parameters.Add("@creadoPor", SqlDbType.Int, 25, "CreadoPor");
                myCommand.Parameters.Add("@fechaModificacion", SqlDbType.DateTime, 25, "FechaModificacion");
                myCommand.Parameters.Add("@modificadoPor", SqlDbType.Int, 25, "ModificadoPor");
                myCommand.Parameters.Add("@idInventario", SqlDbType.Int, 25, "IdInventario");
                myCommand.Parameters.Add("@estadoImpuesto", SqlDbType.Bit, 25, "EstadoImpuesto");
                myCommand.Parameters.Add("@observaciones", SqlDbType.Text, 50, "Observaciones");
                // Insertar el Impuesto
                da.InsertCommand = myCommand;
                da.Update(ds, "Inventario.Impuesto");
                return true;
            }
            catch (Bussiness.CustomException Ex)
            {
                return false;
                throw Ex;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Este producto ya tiene este impuesto");
                return false;
            }
            finally
            {
                //Cerrar la conexion
                conn.DbClose();
            }
        }
        //Validar si existe el producto
        public bool VerificarProducto(TextBox CodigoProducto)
        {
            //Query para verificar si el producto ya existe
            string sql = @"select CodigoBarra from Inventario.Inventario WHERE CodigoBarra =@Id";
            // Crear el Comando para consulta
            SqlCommand myCommand = conn.Comando(sql);
            // myCommand.Parameters.AddWithValue("@Id", CodigoProducto);
            //Abrir Conexion
            conn.DbOpen();
            using (myCommand)
            {
                myCommand.Parameters.Add("@Id", SqlDbType.NChar, 25).Value = CodigoProducto.Text;
                myCommand.ExecuteNonQuery();
            }
            try
            {
                //string Valor = myCommand.ExecuteScalar().ToString();
                //return Valor;
                SqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    return true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
                return false;
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
        }
        public bool VerificarValorImpuesto(TextBox Valor, ComboBox Id)
        {
            //Query para verificar si el producto ya existe
            string sql = @"select IdInventario, Valor from Inventario.Impuesto WHERE IdInventario = @Id AND Valor = @valor";
            // Crear el Comando para consulta
            SqlCommand myCommand = conn.Comando(sql);
            //Abrir Conexion
            conn.DbOpen();

            using (myCommand)
            {
                //Agregando Parametro
                myCommand.Parameters.Add("@Id", SqlDbType.Int, 25).Value = Id.SelectedValue;
                myCommand.Parameters.Add("@valor", SqlDbType.Decimal, 25).Value = decimal.Parse(Valor.Text);
                myCommand.ExecuteNonQuery();
            }
            try
            {
                //string Valor = myCommand.ExecuteScalar().ToString();
                //return Valor;
                SqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    return true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
                return false;
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
        }

        //Cargar Productos
        //---------------------------------------------------------
        //Cargar Producto en una lista para dar de baja
        public static List<DataRepository.Inventario> CargarCodigoProducto()
        {
            DataRepository.Conectar conn = new DataRepository.Conectar();

            string sql;
            List<DataRepository.Inventario> resultados = new List<DataRepository.Inventario>();

            sql = @"Select NombreProducto From Inventario.Inventario";

            SqlCommand myCommand = conn.Comando(sql);

            try
            {
                conn.DbOpen();
                SqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    DataRepository.Inventario producto = new DataRepository.Inventario();
                    producto.NombreProducto = rdr.GetString(0);
                    resultados.Add(producto);
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
        
        //Todos los productos
        public void PopularDataGrid(DataGridView gvProductos)
        {
            // Query
            string sql = @"Select * From Inventario.Inventario";
            // Crear el comando para consulta
            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "Inventario.Inventario");
                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["Inventario.Inventario"];

                DataView dv = new DataView(dt, "", "NombreProducto ASC", DataViewRowState.Unchanged);

                gvProductos.DataSource = dv;
                gvProductos.DataSource = dv;
                gvProductos.Columns[0].HeaderText = "Id";
                gvProductos.Columns[1].HeaderText = "Código Barra";
                gvProductos.Columns[2].HeaderText = "Nombre";
                gvProductos.Columns[3].HeaderText = "Descripción";
                gvProductos.Columns[4].HeaderText = "Cantidad";
                gvProductos.Columns[5].HeaderText = "Precio Compra";
                gvProductos.Columns[6].HeaderText = "Precio Venta";
                gvProductos.Columns[7].HeaderText = "Punto Reorden";
                gvProductos.Columns[8].HeaderText = "Fecha Elab. Producto";
                gvProductos.Columns[9].HeaderText = "Fecha Venc. Producto";
                gvProductos.Columns[10].HeaderText = "Fecha Creación";
                gvProductos.Columns[11].HeaderText = "Creado Por";
                gvProductos.Columns[12].HeaderText = "Fecha Modificación";
                gvProductos.Columns[13].HeaderText = "Modificado Por";
                gvProductos.Columns[14].HeaderText = "Estado";
                gvProductos.Columns[15].HeaderText = "Observaciones";
                gvProductos.Columns[16].HeaderText = "Id Proveedor";
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

        //Productos para reordenar
        public void ProductosPuntoReorden(DataGridView gvProductos)
        {
            string sql = @"Select CodigoBarra, NombreProducto, CantidadProducto, PrecioVenta, PrecioCompra, PuntoReorden,Observaciones,EstadoProducto From Inventario.Inventario
                           where CantidadProducto < PuntoReorden AND EstadoProducto = 1";
            // Crear el comando para consulta
            SqlCommand myCommand = conn.Comando(sql);

            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "Inventario.Inventario");
                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["Inventario.Inventario"];

                DataView dv = new DataView(dt, "", "NombreProducto ASC", DataViewRowState.Unchanged);

                gvProductos.DataSource = dv;
                gvProductos.Columns[0].HeaderText = "Código Barra";
                gvProductos.Columns[1].HeaderText = "Nombre";
                gvProductos.Columns[2].HeaderText = "Cantidad";
                gvProductos.Columns[3].HeaderText = "Precio Venta";
                gvProductos.Columns[4].HeaderText = "Precio Compra";
                gvProductos.Columns[5].HeaderText = "Punto Reorden";
                gvProductos.Columns[6].HeaderText = "Observaciones";
                gvProductos.Columns[7].HeaderText = "Estado";
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
        //Productos inactivos
        public void ProductosInactivos(DataGridView gvProductos)
        {
            // Query
            string sql = @"Select CodigoBarra, NombreProducto, CantidadProducto, PrecioVenta, PrecioCompra,PuntoReorden,EstadoProducto,Observaciones From Inventario.Inventario
                           where EstadoProducto = 0";
            // Crear el comando para consulta
            SqlCommand myCommand = conn.Comando(sql);

            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "Inventario.Inventario");
                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["Inventario.Inventario"];

                DataView dv = new DataView(dt, "", "NombreProducto ASC", DataViewRowState.Unchanged);

                gvProductos.DataSource = dv;
                gvProductos.Columns[0].HeaderText = "Código Barra";
                gvProductos.Columns[1].HeaderText = "Nombre";
                gvProductos.Columns[2].HeaderText = "Cantidad";
                gvProductos.Columns[3].HeaderText = "Precio Venta";
                gvProductos.Columns[4].HeaderText = "Precio Compra";
                gvProductos.Columns[5].HeaderText = "Punto Reorden";
                gvProductos.Columns[6].HeaderText = "Estado";
                gvProductos.Columns[7].HeaderText = "Observaciones";
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
        //Productos Activos
        public void ProductosActivos(DataGridView gvProductos)
        {
            // Query
            string sql = @"Select CodigoBarra, NombreProducto, CantidadProducto, PrecioVenta, PrecioCompra,PuntoReorden,EstadoProducto,Observaciones From Inventario.Inventario
                           where EstadoProducto = 1";
            // Crear el comando para consulta
            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "Inventario.Inventario");
                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["Inventario.Inventario"];

                DataView dv = new DataView(dt, "", "NombreProducto ASC", DataViewRowState.Unchanged);

                gvProductos.DataSource = dv;
                gvProductos.Columns[0].HeaderText = "Código Barra";
                gvProductos.Columns[1].HeaderText = "Nombre";
                gvProductos.Columns[2].HeaderText = "Cantidad";
                gvProductos.Columns[3].HeaderText = "Precio Venta";
                gvProductos.Columns[4].HeaderText = "Precio Compra";
                gvProductos.Columns[5].HeaderText = "Punto Reorden";
                gvProductos.Columns[6].HeaderText = "Estado";
                gvProductos.Columns[7].HeaderText = "Observaciones";
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
        //Alertar al comprador que productos ocupan reorden
        public List<string> ProductoReorden()
        {
            string sql = @"Select  NombreProducto From Inventario.Inventario
                           where CantidadProducto <= PuntoReorden AND EstadoProducto = 1";
            // Crear el comando para consulta
            SqlCommand myCommand = conn.Comando(sql);
            List<string> Miproductos = new List<string>();
            try
            {

                conn.DbOpen();
                // Crear el comando
                SqlCommand cmd = conn.Comando(sql);
           
                // Ejecutar el query via un Execute Reader
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Miproductos.Add(rdr.GetString(0));

                }

                return Miproductos;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return Miproductos;
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
        }
    }
}
