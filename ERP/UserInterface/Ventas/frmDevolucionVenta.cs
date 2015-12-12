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
namespace ERP.UserInterface.Ventas
{
    public partial class frmDevolucionVenta : Form
    {
        // Instanciando la clase conectar para la comunicacion con la base de datos
        DataRepository.Conectar conn = new DataRepository.Conectar();
        // Creando el comando encargado de ejecutar las instrucciones CRUD
        SqlCommand myCommand= new SqlCommand();
        // Variable en la cual se escribira el Query deseado
        string sql;
        // Instanciando la clase ventasCRUD
        Services.ventasCRUD ventas = new Services.ventasCRUD();
        // Variable total del grid
        decimal total;
        // Lista que contendra los productos a devolver
        List<string> productosAdevolver = new List<string>();

        public frmDevolucionVenta()
        {
            InitializeComponent();
        }

        private void SumarTotalGrid()
        {
            total = 0;
            for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
            {
                total += decimal.Parse(gvDetalleVenta[2, i].Value.ToString())* decimal.Parse(gvDetalleVenta[3,i].Value.ToString());
                lblValorTotal.Text = total.ToString();
            }
            if (gvDetalleVenta.Rows.Count == 0)
            {
                total = 0;
                lblValorTotal.Text = total.ToString();
            }
        }
        private void frmDevolucionVenta_Load(object sender, EventArgs e)
        {

        }

        private void txtNumeroFactura_Leave(object sender, EventArgs e)
        {
            if (txtNumeroFactura.Text!="")
            {
                gvDetalleVenta.DataSource = ventas.ListarDetalleFactura(Int32.Parse(txtNumeroFactura.Text));
                SumarTotalGrid();
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gvDetalleVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            productosAdevolver.Add(Int32.Parse(gvDetalleVenta[0, gvDetalleVenta.CurrentRow.Index].Value.ToString()) + ";" + Int32.Parse(gvDetalleVenta[2, gvDetalleVenta.CurrentRow.Index].Value.ToString()) + ";" + Int32.Parse(gvDetalleVenta[4, gvDetalleVenta.CurrentRow.Index].Value.ToString()));
            gvDetalleVenta.Rows.RemoveAt(gvDetalleVenta.CurrentRow.Index);
            SumarTotalGrid();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            ActualizarInventario();
            DataRepository.Ventas.idVenta = int.Parse(txtNumeroFactura.Text);

            foreach (var item in productosAdevolver)
            {
                try
                {
                    sql = @"delete from Venta.Detalle_Ventas where IdInventario=@idInventario";
                    myCommand = conn.Comando(sql);
                    using (myCommand)
                    {
                        myCommand.Parameters.Add("@idInventario", SqlDbType.Int).Value = item.Split(';')[2];
                    }
                    conn.DbOpen();
                    myCommand.ExecuteNonQuery();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.DbClose();
                }
            }
            MessageBox.Show("Devolucion completada con exito","Hecho",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MessageBox.Show("Imprimiendo Factura", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UserInterface.Ventas.frmFactura fac = new UserInterface.Ventas.frmFactura();
            this.Dispose();
            fac.ShowDialog();
            
            
        }

        private void ActualizarInventario()
        {
            foreach (var item in productosAdevolver)
            {
                try
                {
                    sql = @"update Inventario.Inventario set CantidadProducto=CantidadProducto + @cantidad where IdInventario = @idInventario ";
                    myCommand = conn.Comando(sql);
                    using (myCommand)
                    {
                        myCommand.Parameters.Add("@cantidad", SqlDbType.Int).Value = item.Split(';')[1];
                        myCommand.Parameters.Add("@idInventario", SqlDbType.Int).Value = item.Split(';')[2];
                    }
                    conn.DbOpen();
                    myCommand.ExecuteNonQuery();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.DbClose();
                }
            }
        }

        private void btnAnularFactura_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
            {
                productosAdevolver.Add(Int32.Parse(gvDetalleVenta[0, i].Value.ToString()) + ";" + Int32.Parse(gvDetalleVenta[2,i].Value.ToString()) + ";" + Int32.Parse(gvDetalleVenta[4, i].Value.ToString()));
            }
            ActualizarInventario();

            try
            {
                sql = @"update Venta.Ventas set EstadoFactura=0 where IdVenta = @idVenta ";
                myCommand = conn.Comando(sql);
                using (myCommand)
                {
                    myCommand.Parameters.Add("@idVenta", SqlDbType.Int).Value = txtNumeroFactura.Text;
                }
                
                conn.DbOpen();
                myCommand.ExecuteNonQuery();
                gvDetalleVenta.DataSource = null;
                MessageBox.Show("Factura Anulada", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.DbClose();
            }
        }
    }
}
