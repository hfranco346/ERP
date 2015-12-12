using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ERP.Services
{
    class Proveedor
    {
        string sql;
        DataRepository.Conectar conn = new DataRepository.Conectar();
        SqlCommand myCommand = new SqlCommand();

        /// <summary>
        /// Devuelve el Id segun el nombre del proovedor que se indique en el parametro
        /// </summary>
        /// <param name="nombreProveedor"></param>
        /// <returns></returns>
        public int getIdProveedor(string nombreProveedor)
        {
            try
            {
                
                sql = @"select IdClientesProveedores from ClienteProveedor.Clientes_Proveedores Where Nombres = @nombres";
                myCommand = conn.Comando(sql);
                using (myCommand)
                {
                    myCommand.Parameters.Add("@nombres", SqlDbType.VarChar, 30).Value = nombreProveedor;
                }
                conn.DbOpen();
                return int.Parse(myCommand.ExecuteScalar().ToString());

            }
            catch (Helpers.CustomException ex)
            {
                return 0;
            }
            finally
            {
                conn.DbClose();
            }
        }

        /// <summary>
        /// Devuelve los nombres de clientes o proveedores 
        /// segun el valor que se le de al parametro
        /// 0-Cliente
        /// 1-Proveedor
        /// </summary>
        /// <param name="tipoClienteProveedor"></param>
        /// <returns></returns>
        public List<string> GetNombreProveedoresCliente(int tipoClienteProveedor)
        {
            List<string> nombreProveedores = new List<string>();

            try
            {
                sql = @"select Nombres from ClienteProveedor.Clientes_Proveedores where TipoUsuarioCompraVenta = @tipoClienteProveedor";
                myCommand = conn.Comando(sql);
                using (myCommand)
                {
                    myCommand.Parameters.Add("@tipoClienteProveedor", SqlDbType.Bit).Value = tipoClienteProveedor;
                }
                conn.DbOpen();
                SqlDataReader dtr = myCommand.ExecuteReader();
                while (dtr.Read())
                {
                    nombreProveedores.Add(dtr.GetString(0));
                }
                return nombreProveedores;
            }
            catch (Exception)
            {
                nombreProveedores.Clear();
                nombreProveedores.Add("0");
                return nombreProveedores;
            }
            finally
            {
                conn.DbClose();
            }
        }
    }
}
