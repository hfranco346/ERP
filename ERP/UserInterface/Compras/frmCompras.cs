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

namespace ERP.UserInterface.Compras
{
    public partial class frmCompras : Form
    {
        // Instanciando la clase conectar para la comunicación con la base de datos
        DataRepository.Conectar conn = new DataRepository.Conectar();
        // Declaracion de la variable que contendra las sentencias sql necesarias
        string sql = "";
        // Declarando el comando encargado de ejecutar las sentencias
        SqlCommand myCommand = new SqlCommand();
        // Variable que almacenara temporalmente el id del proveedore
        int idProveedor;
        // Instanciando las clases que reflejan las tablas de compras y detalle de compras
        DataRepository.Compra compra = new DataRepository.Compra();
        DataRepository.DetalleCompra detalleCompra = new DataRepository.DetalleCompra();
        // Variable que tendra el total de la compra
        double totalCompra;
        // Variable que obtendra el IdCompra para asignarlo al detalle de la compra
        int idCompra;
        // instanciando la clase Proveedor
        Services.Proveedor proveedor = new Services.Proveedor();
        public frmCompras()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            if (proveedor.GetNombreProveedoresCliente(1).IndexOf("0")!=-1)
            {
                MessageBox.Show("Error en la comunicación a la base de datos","Compras",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                foreach (var nombre in proveedor.GetNombreProveedoresCliente(1))
                {
                    cmbProveedores.Items.Add(nombre);
                }
            }
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvDetalleCompra.Rows.Clear();
            
            idProveedor= proveedor.getIdProveedor(cmbProveedores.Text);

            try
            {
                sql = @"select 
                    CodigoBarra,NombreProducto,DescripcionProducto,CantidadProducto,PrecioCompra,
                    PrecioVenta,PuntoReorden,FechaElaboracionProducto,FechaVencimientoProducto, IdInventario
                    From Inventario.Inventario Where IdProveedor = @idProveedor";
                myCommand = conn.Comando(sql);
                conn.DbOpen();
                using (myCommand)
                {
                    myCommand.Parameters.Add("@idProveedor", SqlDbType.Int).Value = idProveedor;
                }
                SqlDataReader dtr = myCommand.ExecuteReader();
                while (dtr.Read())
                {
                    gvDetalleCompra.Rows.Add(dtr.GetString(0), 
                    dtr.GetString(1), dtr.GetString(2), 
                    dtr.GetInt32(3).ToString(), dtr.GetDecimal(4).ToString(), 
                    dtr.GetDecimal(5).ToString(), dtr.GetInt32(6).ToString(), 
                    dtr.GetDateTime(7).ToString(), dtr.GetDateTime(8).ToString(),
                    dtr.GetInt32(9).ToString());
                }

            }
            catch (Helpers.CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.DbClose();
            }

        }

        private void gvDetalleCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvDetalleCompra.Rows.Count > 0)
            {
                gvOrdenProducto.Rows.Add(gvDetalleCompra.CurrentRow.Cells[0].Value, gvDetalleCompra.CurrentRow.Cells[1].Value, gvDetalleCompra.CurrentRow.Cells[2].Value,
                                     gvDetalleCompra.CurrentRow.Cells[3].Value, gvDetalleCompra.CurrentRow.Cells[4].Value, gvDetalleCompra.CurrentRow.Cells[5].Value,
                                     gvDetalleCompra.CurrentRow.Cells[6].Value, gvDetalleCompra.CurrentRow.Cells[7].Value, gvDetalleCompra.CurrentRow.Cells[8].Value,
                                     gvDetalleCompra.CurrentRow.Cells[9].Value, Convert.ToString( decimal.Parse( gvDetalleCompra.CurrentRow.Cells[3].Value.ToString()) * decimal.Parse( gvDetalleCompra.CurrentRow.Cells[4].Value.ToString())));
                gvDetalleCompra.Rows.RemoveAt(gvDetalleCompra.CurrentRow.Index); 
                SumarTotalGrid();

            }
            
        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gvOrdenProducto.Rows.Count > 0)
            {
                gvDetalleCompra.Rows.Add(gvOrdenProducto.CurrentRow.Cells[0].Value, gvOrdenProducto.CurrentRow.Cells[1].Value, gvOrdenProducto.CurrentRow.Cells[2].Value,
                                     gvOrdenProducto.CurrentRow.Cells[3].Value, gvOrdenProducto.CurrentRow.Cells[4].Value, gvOrdenProducto.CurrentRow.Cells[5].Value,
                                     gvOrdenProducto.CurrentRow.Cells[6].Value, gvOrdenProducto.CurrentRow.Cells[7].Value, gvOrdenProducto.CurrentRow.Cells[8].Value,
                                     gvOrdenProducto.CurrentRow.Cells[9].Value);
                gvOrdenProducto.Rows.RemoveAt(gvOrdenProducto.CurrentRow.Index);
                SumarTotalGrid();

            }
            
        }

        private void btnEmitirOrden_Click(object sender, EventArgs e)
        {
            // En  esta seccion se haran los respectivos INSERT en las tablas compras y detalle de compras
            if (cmbProveedores.Text != " " && gvOrdenProducto.Rows.Count > 0)
            {
                try
                {
                    sql = @"Insert into Compra.Compras values(@fechaCompra,@numeroFactura,@total,@observaciones,@fechaCreacion,
                                                          @creadoPor,@fechaModificacion,@modificadoPor,@idClientesProveedor,
                                                          @estado)";
                    myCommand = conn.Comando(sql);
                    using (myCommand)
                    {
                        myCommand.Parameters.Add("@fechaCompra", SqlDbType.DateTime).Value = dtpFechaCompra.Value;
                        myCommand.Parameters.Add("@numeroFactura", SqlDbType.VarChar).Value = "";
                        myCommand.Parameters.Add("@total", SqlDbType.Decimal).Value = decimal.Parse(totalCompra.ToString());
                        myCommand.Parameters.Add("@observaciones", SqlDbType.Text).Value = txtObservaciones.Text;
                        myCommand.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = dtpFechaCompra.Value;
                        myCommand.Parameters.Add("@creadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                        myCommand.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = dtpFechaCompra.Value;
                        myCommand.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                        myCommand.Parameters.Add("@idClientesProveedor", SqlDbType.Int).Value = idProveedor;
                        myCommand.Parameters.Add("@estado", SqlDbType.Char).Value = '0';
                    }
                    conn.DbOpen();
                    myCommand.ExecuteNonQuery();
                    // Se recupera el id Autonumerico generado por el insert 
                    myCommand = conn.Comando(@"SELECT IDENT_CURRENT('Compra.Compras')");
                    idCompra = Int32.Parse(myCommand.ExecuteScalar().ToString());


                    for (int i = 0; i < gvOrdenProducto.Rows.Count; i++)
                    {
                        sql = @"Insert into Compra.Detalle_Compras values (@numeroProducto,@cantidadProducto,@precioUnitario,@descripcion,@fechaCreacion, @creadoPor, @fechaModificacion, @modificadoPor, @idInventario,@idCompra)";
                        myCommand = conn.Comando(sql);
                        using (myCommand)
                        {
                            myCommand.Parameters.Add("@numeroProducto", SqlDbType.Int).Value = i + 1;
                            myCommand.Parameters.Add("@cantidadProducto", SqlDbType.Int).Value = Int32.Parse(gvOrdenProducto[3, i].Value.ToString());
                            myCommand.Parameters.Add("@precioUnitario", SqlDbType.Money).Value = Decimal.Parse(gvOrdenProducto[5, i].Value.ToString());
                            myCommand.Parameters.Add("@descripcion", SqlDbType.Text).Value = gvOrdenProducto[2, i].Value.ToString();
                            myCommand.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = dtpFechaCompra.Value;
                            myCommand.Parameters.Add("@creadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                            myCommand.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = dtpFechaCompra.Value;
                            myCommand.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                            myCommand.Parameters.Add("@idInventario", SqlDbType.Int).Value = Int32.Parse(gvOrdenProducto[9, i].Value.ToString());
                            myCommand.Parameters.Add("@idCompra", SqlDbType.Int).Value = idCompra;

                        }
                        myCommand.ExecuteNonQuery();
                    }
                    gvDetalleCompra.Rows.Clear();
                    gvOrdenProducto.Rows.Clear();
                    cmbProveedores.Text = "";
                    txtObservaciones.Text = "";
                    lblValorTotalCompra.Text = "0";
                    cmbProveedores.Focus();
                    MessageBox.Show("Orden guardada con éxito", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Helpers.CustomException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.DbClose();
                }
            }
            else
            {
                MessageBox.Show("Error debe seleccionar un proveedor y productos que desea comprar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProveedores.Focus();
            }
        }

        private void SumarTotalGrid()
        {
            totalCompra = 0;
            for (int i = 0; i < gvOrdenProducto.Rows.Count; i++)
            {
                totalCompra += double.Parse(gvOrdenProducto[10, i].Value.ToString());
                lblValorTotalCompra.Text = string.Format("{0:C}", totalCompra.ToString());
            }
            if (gvOrdenProducto.Rows.Count == 0)
            {
                totalCompra = 0;
                lblValorTotalCompra.Text = totalCompra.ToString();
            }
        }

        private void gvOrdenProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void gvOrdenProducto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            gvOrdenProducto.CurrentRow.Cells[10].Value =Convert.ToString(decimal.Parse(gvOrdenProducto.CurrentRow.Cells[3].Value.ToString()) * decimal.Parse(gvOrdenProducto.CurrentRow.Cells[4].Value.ToString()));
            SumarTotalGrid();
        }
    }
}
