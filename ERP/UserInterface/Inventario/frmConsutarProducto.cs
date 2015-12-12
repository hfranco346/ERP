using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ERP.UserInterface.Inventario
{
    public partial class frmConsutarProducto : Form
    {
        Services.InventarioCRUD todosProductos = new Services.InventarioCRUD();
        DataRepository.Conectar conn = new DataRepository.Conectar();
        DataTable dt;
        public frmConsutarProducto()
        {
            InitializeComponent();
        }
        //LLenar dataGrid con los datos de los impuestos agregados
        private void llenargrid()
        {
            txtbuscar.Focus();
            //todosProductos.PopularDataGrid(gvProductos); 
            // Query
            string sql = @"Select * From Inventario.Inventario";
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

                dt = ds.Tables["Inventario.Inventario"];

                DataView dv = new DataView(dt, "", "NombreProducto", DataViewRowState.Unchanged);

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

        //Cargar todos los producto cuando presionesmos el botón todos los productos
        private void btnTodosProductos_Click(object sender, EventArgs e)
        {
            llenargrid();
        }

        //Cargar productos inactivos
        private void btnProductosInactivos_Click(object sender, EventArgs e)
        {
            todosProductos.ProductosInactivos(gvProductos); 
        }
        //Cargar productos activos
        private void btnProductosActivos_Click(object sender, EventArgs e)
        {
            todosProductos.ProductosActivos(gvProductos); 
        }
        //cargar productos para reorden
        private void btnReorden_Click(object sender, EventArgs e)
        {
            todosProductos.ProductosPuntoReorden(gvProductos);
        }
        //Botón cerrar ventana actual
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //Buscar producto por su nombre, código barra, y proveedor
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            try
            {
                if (rbNombreProducto.Checked == false && rbCodigoBarra.Checked == false && rbProveedor.Checked == false)
                {
                    MessageBox.Show("Seleccione como desea buscar: por nombre o código del producto");
                }
                else
                {
                    if (rbNombreProducto.Checked)
                    {
                        DV.RowFilter = string.Format("NombreProducto LIKE '%{0}%'", txtbuscar.Text);
                    }
                    else if (rbCodigoBarra.Checked)
                    {
                        DV.RowFilter = string.Format("CodigoBarra LIKE '%{0}%'", txtbuscar.Text);
                    }
                    else if (rbProveedor.Checked)
                    {
                        DV.RowFilter = ("IdProveedor ='" + txtbuscar.Text + "'").ToString();
                    }
                    gvProductos.DataSource = DV;
                }

            }
            catch (Exception) { }
        }

        private void rbNombreProducto_CheckedChanged(object sender, EventArgs e)
        {
            txtbuscar.Focus();
        }

        private void rbCodigoBarra_CheckedChanged(object sender, EventArgs e)
        {
            txtbuscar.Focus();
        }

        private void rbProveedor_CheckedChanged(object sender, EventArgs e)
        {
            txtbuscar.Focus();
        }
        //Cargar todos los productos en el load
        private void frmConsutarProducto_Load(object sender, EventArgs e)
        {
            llenargrid();
        }
    }
}
