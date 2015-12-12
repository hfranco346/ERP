using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace ERP.Services
{
    class ComprasCRUD
    {

        DataRepository.Conectar conn = new DataRepository.Conectar();
        SqlCommand myCommand = new SqlCommand();
        
        public DataTable ListarComprasPendientes(int IdProveedor)
        {
            DataView dv = new DataView() ;
            DataTable dt = new DataTable();
            // Query
            string sql;

            sql = @"select IdCompra 'ID COMPRA',FechaCompra 'FECHA COMPRA',NumeroFactura 'NUMERO FACTURA', Total 'TOTAL',Observaciones 'OBSERVACIONES', FechaCreacion 'FECHA DE CREACIÓN',EstadoCompra, IdClientesProveedores FROM Compra.Compras where IdClientesProveedores = @idCliente order by EstadoCompra asc";

            // Crear la conexión

            SqlCommand myCommand = conn.Comando(sql);
            using (myCommand)
            {
                myCommand.Parameters.Add("@idCliente",SqlDbType.Int).Value=IdProveedor;
            }
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "Compra.Compras");
                // Obtener la tabla de referencia
                dt = ds.Tables["Compra.Compras"];
                //dv = new DataView(dt, "IdClientesProveedores =" + IdProveedor.ToString() , "EstadoCompra asc", DataViewRowState.Unchanged);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return dt;
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
        }



        public DataTable ListarDetalleDeCompra(int IdFactura)
        {
            DataView dv = new DataView();
            DataTable dt = new DataTable();
            // Query
            string sql;

            sql = @"select NumeroProducto,IdInventario,Descripcion,CantidadProducto,PrecioUnitario,CreadoPor,FechaCreacion,ModificadoPor,FechaModificacion,IdCompra from Compra.Detalle_Compras where IdCompra = @idCompra order by NumeroProducto asc";
            
            // Crear la conexión

            SqlCommand myCommand = conn.Comando(sql);
            using (myCommand)
            {
                myCommand.Parameters.Add("@IdCompra",SqlDbType.Int).Value=IdFactura;
            }
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "Compra.Detalle_Compras");
                // Obtener la tabla de referencia
                dt = ds.Tables["Compra.Detalle_Compras"];
                
                return dt ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return dt;
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
        }
        /// <summary>
        /// Metodo encargado de cerrar o cancelar una orden de compra
        /// </summary>
        /// <param name="EstadoCompra"></param>
        /// <returns></returns>
        public bool CancelarOCerrarOrdenDeCompra(int EstadoCompra, int IdCompra, decimal Total)
        {
            try
            {
                
                string sql;
                sql = @"update Compra.Compras set EstadoCompra = @estadoCompra, Total= @total where IdCompra = @idCompra";
                myCommand = conn.Comando(sql);
                using (myCommand)
                {
                    myCommand.Parameters.Add("@estadoCompra", SqlDbType.Int).Value = EstadoCompra;
                    myCommand.Parameters.Add("@idCompra", SqlDbType.Int).Value = IdCompra;
                    myCommand.Parameters.Add("@total", SqlDbType.Money).Value = Total;

                }
                conn.DbOpen();
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.DbClose();
            }
        }

    }
}
