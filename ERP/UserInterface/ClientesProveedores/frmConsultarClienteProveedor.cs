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

namespace ERP.UserInterface.ClientesProveedores
{
    public partial class frmConsultarClienteProveedor : Form
    {

        Services.ClientesProveedoresCRUD clienteProveedor = new Services.ClientesProveedoresCRUD();
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public frmConsultarClienteProveedor()
        {
            InitializeComponent();
        }
         private void PopularDataGridPorRTN(DataGridView gv)
        {
            // Query
            string sql = @"Select RTN,Nombres,Apellidos,CorreoElectronico,Direccion,TipoUsuarioCompraVenta,EstadoClienteProveedor,FechaModificacion From ClienteProveedor.Clientes_Proveedores WHERE RTN = '" + txtRTN.Text+"'";
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

                gv.DataSource = dv;
                gv.Columns[0].Visible = false;
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

        private void frmClienteProveedor_Load(object sender, EventArgs e)
        {
            
            clienteProveedor.PopularDataGridClienteProveedor(gvClienteProveedor);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clienteProveedor.PopularDataGridCliente(gvClienteProveedor);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            clienteProveedor.PopularDataGridProveedor(gvClienteProveedor);
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtRTN_TextChanged(object sender, EventArgs e)
        {
            PopularDataGridPorRTN(gvClienteProveedor);
        }

        private void gvClienteProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
