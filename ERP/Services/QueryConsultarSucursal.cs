using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERP.Services
{
    class QueryConsultarSucursal
    {
        DataRepository.Sucursal resultados = new DataRepository.Sucursal();
        public static List<DataRepository.Sucursal> CargarSucursales()
        {
            DataRepository.Conectar conn = new DataRepository.Conectar();

            string sql;
            List<DataRepository.Sucursal> resultados = new List<DataRepository.Sucursal>();

            sql = @"Select IdSucursal From ClienteProveedor.Sucursal";

            SqlCommand myCommand = conn.Comando(sql);

            try
            {
                conn.DbOpen();

                SqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    DataRepository.Sucursal producto = new DataRepository.Sucursal();
                    producto.IdSucursal= rdr.GetInt32(0);
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