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
    class ImpuestoCRUD
    {
        //Cargar Producto en una lista para dar de baja
        DataRepository.Conectar conn = new DataRepository.Conectar();
        //Cargar todos los impuestos disponibles para dar de baja
        public static List<DataRepository.Impuesto> CargarImpuestos()
        {
            DataRepository.Conectar conn = new DataRepository.Conectar();

            string sql;
            List<DataRepository.Impuesto> resultados = new List<DataRepository.Impuesto>();
            sql = @"SELECT Impuesto.IDImpuesto,Impuesto.Descripcion,Inventario.CodigoBarra, Inventario.CantidadProducto, Inventario.EstadoProducto
                  FROM Inventario.Impuesto INNER JOIN Inventario.Inventario ON Impuesto.IdInventario = Inventario.IdInventario
                  WHERE Inventario.EstadoProducto = 0";

            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                conn.DbOpen();
                SqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    DataRepository.Impuesto impuesto = new DataRepository.Impuesto();
                    impuesto.IdImpuesto = rdr.GetInt32(0);
                    resultados.Add(impuesto);
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
        //Cargar impuestos para modificar
        public static List<DataRepository.Impuesto> CargarImpuestosParaModificar()
        {
            DataRepository.Conectar conn = new DataRepository.Conectar();

            string sql;
            List<DataRepository.Impuesto> resultados = new List<DataRepository.Impuesto>();
            sql = @"SELECT Impuesto.IDImpuesto,Impuesto.Descripcion,Impuesto.EstadoImpuesto,Inventario.CodigoBarra, Inventario.CantidadProducto, Inventario.EstadoProducto
                  FROM Inventario.Impuesto INNER JOIN Inventario.Inventario ON Impuesto.IdInventario = Inventario.IdInventario
                  ";
            //sql = @"Select Descripcion From Inventario.Impuesto";
            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                conn.DbOpen();
                SqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    DataRepository.Impuesto impuesto = new DataRepository.Impuesto();
                    impuesto.IdImpuesto = rdr.GetInt32(0);
                    resultados.Add(impuesto);
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
        //Cargar el combobox con los productos a asignar impuesto
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
        //cargar todos los impuestos 
        public void PopularDataGrid(DataGridView gvImpuestos)
        {
            // Query
            string sql = @"Select * From Inventario.Impuesto";
            // Crear el comando para consulta
            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "Inventario.Impuesto");
                // Obtener la tabla de referencia
                DataTable dt = ds.Tables["Inventario.Impuesto"];

                DataView dv = new DataView(dt, "", "FechaModificacion ASC", DataViewRowState.Unchanged);
                gvImpuestos.DataSource = dv;
                gvImpuestos.Columns[0].Visible = false;
                gvImpuestos.Columns[1].HeaderText = "Nombre Impuesto";
                gvImpuestos.Columns[2].HeaderText = "Valor";
                gvImpuestos.Columns[3].HeaderText = "Fecha Creación";
                gvImpuestos.Columns[4].HeaderText = "Creado Por";
                gvImpuestos.Columns[5].HeaderText = "Fecha Modificacíon";
                gvImpuestos.Columns[6].HeaderText = "Modificado Por";
                gvImpuestos.Columns[7].HeaderText = "Id Inventario";
                gvImpuestos.Columns[8].HeaderText = "Estado";
                gvImpuestos.Columns[9].HeaderText = "Onservaciones";
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
        //Cargar el impuesto por id de impuesto
        public int CodigoProductoImpuesto(int IdIventarioImpuesto)
        {
            DataRepository.InventarioVentas resultados = new DataRepository.InventarioVentas();
            DataRepository.Conectar conn = new DataRepository.Conectar();
            int idImpuesto = -1;
            string sql = "SELECT IDImpuesto, Descripcion, Valor,IdInventario  FROM Inventario.Impuesto WHERE IdInventario = @idInventario";

            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                conn.DbOpen();
                SqlDataReader rdr;

                using (myCommand)
                {
                    myCommand.Parameters.Add("@idInventario", SqlDbType.Int, 50).Value = IdIventarioImpuesto;
                    rdr = myCommand.ExecuteReader();
                }
                while (rdr.Read())
                {
                    idImpuesto = rdr.GetInt32(0);
                    resultados.IDImpuesto = rdr.GetInt32(0);
                    resultados.Descripcion = rdr.GetString(1);
                    resultados.Valor = rdr.GetDecimal(2);
                    resultados.IdInventario = rdr.GetInt32(3);
                    resultados.ImpuestoAcumulado = decimal.Parse(rdr.GetDecimal(2).ToString());
                }
                if (idImpuesto == -1)
                {
                    throw new Helpers.CustomException("El producto solicitado no existe.");
                }
                else
                    return idImpuesto;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Helpers.CustomException ex)
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
