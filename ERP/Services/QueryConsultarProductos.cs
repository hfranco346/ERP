using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace ERP.Services
{
    class QueryConsultarProductos
    {
        DataRepository.Inventario resultados = new DataRepository.Inventario();
        public bool CodigoProducto(string codigoBarra)
        {
            DataRepository.InventarioVentas resultados = new DataRepository.InventarioVentas();
            DataRepository.Conectar conn = new DataRepository.Conectar();
            int idInventario = -1;
            string sql = "SELECT IdInventario, CodigoBarra, NombreProducto, DescripcionProducto, FechaElaboracionProducto, FechaVencimientoProducto, PrecioCompra, PrecioVenta, CantidadProducto,PuntoReorden,Observaciones,EstadoProducto FROM Inventario.Inventario WHERE CodigoBarra = @codigoBarra";

            SqlCommand myCommand = conn.Comando(sql);
            if (codigoBarra=="")
            {
                return false;
            }
            try
            {
                conn.DbOpen();
                SqlDataReader rdr;

                using (myCommand)
                {
                    myCommand.Parameters.Add("@codigoBarra", SqlDbType.VarChar, 25).Value = codigoBarra;
                }
                rdr = myCommand.ExecuteReader();
                while (rdr.Read())
                {
                    idInventario = rdr.GetInt32(0);
                    resultados.IdInventario = rdr.GetInt32(0);
                    resultados.CodigoBarra = rdr.GetString(1);
                    resultados.NombreProducto = rdr.GetString(2);
                    resultados.DescripcionProducto = rdr.GetString(3);
                    resultados.FechaElaboracionProducto = rdr.GetDateTime(4);
                    resultados.FechaVencimientoProducto = rdr.GetDateTime(5);
                    resultados.PrecioCompra = rdr.GetDecimal(6);
                    resultados.PrecioVenta = rdr.GetDecimal(7);
                    resultados.Cantidad = rdr.GetInt32(8);
                    resultados.PuntoReorden = rdr.GetInt32(9);
                    resultados.Observaciones = rdr.GetString(10);
                    resultados.EstadoProducto = rdr.GetBoolean(11);
                }
                if (idInventario == -1)
                {
                    return false;
                }
                else
                    return true;
            }
            catch (SqlException ex)
            {
                throw new Helpers.CustomException("El producto solicitado no existe.");
                throw ex;
            }
            finally
            {
                conn.DbClose();
            }
        }

       
       
    }
}
