using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace ERP.Services
{
    class ventasCRUD
    {
        public DataTable ListarDetalleFactura(int IdFactura)
        {
            // Instanciando la clase conectar para la comunicacion con la base de datos
            DataRepository.Conectar conn = new DataRepository.Conectar();
            DataView dv = new DataView();
            DataTable dt = new DataTable();
            // Query
            string sql;

            sql = @"select IdDetalleVenta, Descripcion, CantidadProducto, PrecioUnitario, IdInventario from Venta.Detalle_Ventas where IdVenta=@idVenta order by NumeroProducto ASC";

            // Crear la conexión

            SqlCommand myCommand = conn.Comando(sql);
            using (myCommand)
            {
                myCommand.Parameters.Add("@idVenta", SqlDbType.Int).Value = IdFactura;
            }
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "Venta.Detalle_Ventas");
                // Obtener la tabla de referencia
                dt = ds.Tables["Venta.Detalle_Ventas"];
                
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
        }
    }
}
