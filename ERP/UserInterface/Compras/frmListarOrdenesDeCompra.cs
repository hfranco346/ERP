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
namespace ERP.UserInterface.Compras
{
    public partial class frmListarOrdenesDeCompra : Form
    {
        Services.Proveedor proveedor = new Services.Proveedor();
        Services.ComprasCRUD comprasCRUD = new Services.ComprasCRUD();
        string sql;
        SqlCommand myCommand = new SqlCommand();
        DataRepository.Conectar conn = new DataRepository.Conectar();
        double totalCompra;
        public frmListarOrdenesDeCompra()
        {
            InitializeComponent();
        }

        private void frmListarOrdenesDeCompra_Load(object sender, EventArgs e)
        {
            foreach (var nombre in proveedor.GetNombreProveedoresCliente(1))
            {
                cmbProveedores.Items.Add(nombre);
            }
            
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvDetalleCompra.DataSource = comprasCRUD.ListarComprasPendientes(proveedor.getIdProveedor(cmbProveedores.Text));
            RenombrarEstados();
        }

         //variable que cuenta las filas del Datgridview
        string filas;
                    
        private void gvDetalleCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            filas = e.RowIndex.ToString();
            gvDetalleProducto.DataSource = comprasCRUD.ListarDetalleDeCompra(Int32.Parse( gvDetalleCompra[0,gvDetalleCompra.CurrentRow.Index].Value.ToString()));
            gvDetalleProducto.EditMode = DataGridViewEditMode.EditOnEnter;
            SumarTotalGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SumarTotalGrid()
        {
            totalCompra = 0;
            for (int i = 0; i < gvDetalleProducto.Rows.Count; i++)
            {
                gvDetalleProducto[0,i].Value=decimal.Parse(gvDetalleProducto[4,i].Value.ToString())* decimal.Parse(gvDetalleProducto[5,i].Value.ToString());
            }

            for (int i = 0; i < gvDetalleProducto.Rows.Count; i++)
            {
                totalCompra += double.Parse(gvDetalleProducto[0, i].Value.ToString());
                lblValorTotalCompra.Text = string.Format("{0:C}", totalCompra.ToString());
            }
            if (gvDetalleProducto.Rows.Count == 0)
            {
                totalCompra = 0;
                lblValorTotalCompra.Text = totalCompra.ToString();
            }
        }
        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDetalleCompra.Rows.Count > 0 && gvDetalleProducto.Rows.Count > 0)
                {

                    if (gvDetalleCompra.Rows[int.Parse(filas)].Cells[6].Value.ToString() != "APR")
                    {

                        SumarTotalGrid();
                        if (comprasCRUD.CancelarOCerrarOrdenDeCompra(1, Int32.Parse(gvDetalleCompra[0, gvDetalleCompra.CurrentRow.Index].Value.ToString()), decimal.Parse(lblValorTotalCompra.Text)))
                        {
                            ActualizarInventario();
                            ActualizarDetalleCompra();
                            cmbProveedores.Text = " ";

                        }
                    }
                    else 
                    {
                        MessageBox.Show("¡Esta compra ya fue aprobada no puede cerrar la compra!","NOTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("¡Debe Seleccionar un proveedor con un pedido para cerrar una orden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbProveedores.Focus();
                }
            }
            catch (Exception)
            {
                
            }
            
            
            
        }

        private void ActualizarDetalleCompra()
        {
            try
            {
                conn.DbOpen();
                for (int i = 0; i < gvDetalleProducto.Rows.Count; i++)
                {
                    sql = @"update Compra.Detalle_Compras set CantidadProducto = @cantidadProducto, PrecioUnitario=@precioUnitario where IdInventario=@idInventario and IdCompra = @idCompra";
                    myCommand = conn.Comando(sql);
                    using (myCommand)
                    {
                        myCommand.Parameters.Add("@cantidadProducto", SqlDbType.Int).Value = Int32.Parse(gvDetalleProducto[4, i].Value.ToString());
                        myCommand.Parameters.Add("@precioUnitario", SqlDbType.Decimal).Value = Decimal.Parse(gvDetalleProducto[5, i].Value.ToString());
                        myCommand.Parameters.Add("@idInventario", SqlDbType.Int).Value = Int32.Parse(gvDetalleProducto[2, i].Value.ToString());
                        myCommand.Parameters.Add("@idCompra", SqlDbType.Int).Value = Int32.Parse(gvDetalleCompra[0, gvDetalleCompra.CurrentRow.Index].Value.ToString());

                    }

                    myCommand.ExecuteNonQuery();
                }
                gvDetalleCompra.DataSource = comprasCRUD.ListarComprasPendientes(proveedor.getIdProveedor(cmbProveedores.Text));
                RenombrarEstados();
                gvDetalleProducto.DataSource = null;
                cmbProveedores.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.DbClose();
            }
        }

        private void ActualizarInventario()
        {
            try
            {
                conn.DbOpen();
                for (int i = 0; i < gvDetalleProducto.Rows.Count; i++)
                {
                    sql = @"update Inventario.Inventario set CantidadProducto = CantidadProducto + @cantidadProducto where IdInventario = @idInventario";
                    myCommand = conn.Comando(sql);
                    using (myCommand)
                    {
                        myCommand.Parameters.Add("@cantidadProducto", SqlDbType.Int).Value = Int32.Parse(gvDetalleProducto[4, i].Value.ToString());
                        myCommand.Parameters.Add("@idInventario", SqlDbType.Int).Value = Int32.Parse(gvDetalleProducto[2, i].Value.ToString());
                    }

                    myCommand.ExecuteNonQuery();
                }
                gvDetalleCompra.DataSource = comprasCRUD.ListarComprasPendientes(proveedor.getIdProveedor(cmbProveedores.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.DbClose();
            }
        }

        private void gvDetalleProducto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SumarTotalGrid();
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            if (gvDetalleProducto.Rows.Count > 0 && gvDetalleCompra.Rows.Count > 0)
            {
                if (gvDetalleCompra.Rows[int.Parse(filas)].Cells[6].Value.ToString() != "APR")
                {
                    SumarTotalGrid();
                    if (comprasCRUD.CancelarOCerrarOrdenDeCompra(2, Int32.Parse(gvDetalleCompra[0, gvDetalleCompra.CurrentRow.Index].Value.ToString()), decimal.Parse(lblValorTotalCompra.Text)))
                    {
                        ActualizarDetalleCompra();
                    }
                }
                else
                {
                    MessageBox.Show("¡Esta compra ya fue aprobada no puede ser cancelada!", "NOTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            else
            {
                MessageBox.Show("¡Debe Seleccionar un proveedor con un pedido para cancelar una orden!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProveedores.Focus();
            }
            
        }

        private void RenombrarEstados()
        {
            for (int i = 0; i < gvDetalleCompra.Rows.Count; i++)
            {
                switch (gvDetalleCompra[6,i].Value.ToString())
                {
                    case "0":
                        gvDetalleCompra[6, i].Value = "PDE";
                        break;
                    case "1":
                        gvDetalleCompra[6, i].Value = "APR";
                        break;
                    case "2":
                        gvDetalleCompra[6, i].Value = "CND";
                        break;
                    default:
                        break;
                }
                
            }
        }

        private void gvDetalleCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
