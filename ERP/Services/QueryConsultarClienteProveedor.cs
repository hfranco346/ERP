using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERP.Services
{
    class QueryConsultarClienteProveedor
    {
        DataRepository.ClientesProveedores resultados = new DataRepository.ClientesProveedores();
        public static List<DataRepository.ClientesProveedores> CargarClienteProveedor()
        {
            DataRepository.Conectar conn = new DataRepository.Conectar();

            string sql;
            List<DataRepository.ClientesProveedores> resultados = new List<DataRepository.ClientesProveedores>();

            sql = @"Select RTN From ClienteProveedor.Clientes_Proveedores";

            SqlCommand myCommand = conn.Comando(sql);

            try
            {
                conn.DbOpen();

                SqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    DataRepository.ClientesProveedores producto = new DataRepository.ClientesProveedores();
                    producto.RTN = rdr.GetString(0);
                    resultados.Add(producto);
                }
                return resultados;
            }
            catch (Exception ex)
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
