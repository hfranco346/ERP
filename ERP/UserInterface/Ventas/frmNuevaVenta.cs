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
    public partial class frmNuevaVenta : Form
    {
        decimal total = 0; // Variable que acumulara el total de cada registro del gvDetalle
        decimal subTotal = 0;
        bool gridActivo = false; // Variable encargada de saber cuando se desea modificar o eliminar el registro actual del gvDetalle
        // Instanciando la clase encargada de consultar el producto segun el codigo de barra
        Services.QueryConsultarProductos consultarProducto = new Services.QueryConsultarProductos();
        // Instanciando clases que contiene la informacion especifica del producto solicitado
        DataRepository.InventarioVentas inventario = new DataRepository.InventarioVentas();
        // Instanciando la clase conectar para realizar los respectivos querys
        DataRepository.Conectar conn = new DataRepository.Conectar();
        // Creando el comando que se utilizara para ejecutar los CRUD correspondientes
        SqlCommand myCommand = new SqlCommand();
        // Instanciando la clase impuestoCRUD
        Services.ImpuestoCRUD impuesto = new Services.ImpuestoCRUD();
        // Instanciando la clase ClientesProveedores para acceder al nombre y id del cliente al cual se hara la venta
        DataRepository.ClientesProveedores cliente = new DataRepository.ClientesProveedores();
        // Lista 
        public frmNuevaVenta()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Función encargada de sumar los totales unitarios de cada producto en el gvDetalle
        /// y reflejar el resultado en el lblValorTotal
        /// </summary>
        private void SumarTotalGrid()
        {
            total = 0;
            for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
            {
                total += decimal.Parse(gvDetalleVenta[4, i].Value.ToString());
                lblValorTotal.Text = total.ToString();
            }
            if (gvDetalleVenta.Rows.Count == 0)
            {
                total = 0;
                lblValorTotal.Text = total.ToString();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text!="" && txtPrecio.Text !="" && nudCantidad.Value>0 && txtIdCliente.Text!="" && nudCantidad.Value<=inventario.Cantidad)
            {
                // Estructura de control encargada de verificar si el producto a ingresar ya se encuentra
                // en el registro del gvDetalleVenta
                if (gvDetalleVenta.Rows.Count > 0)
                {
                    for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
                    {
                        if (gvDetalleVenta[0, i].Value.ToString() == txtCodigoProducto.Text)
                        {
                            gvDetalleVenta[2, i].Value = Int16.Parse(gvDetalleVenta[2, i].Value.ToString()) + Int16.Parse(nudCantidad.Value.ToString());
                            gvDetalleVenta[4, i].Value = Int16.Parse(gvDetalleVenta[2, i].Value.ToString()) * Decimal.Parse(gvDetalleVenta[3, i].Value.ToString());
                            //gvDetalleVenta[];
                            SumarTotalGrid();
                            calcularImpuesto();
                            calcularSubTotal();
                            Limpiar();
                            gridActivo = false;
                            return;
                        }
                    }
                    gvDetalleVenta.Rows.Add(txtCodigoProducto.Text, inventario.NombreProducto , nudCantidad.Value.ToString(), txtPrecio.Text, decimal.Parse(txtPrecio.Text) * nudCantidad.Value,inventario.ImpuestoAcumulado,inventario.IdInventario);
                }
                else
                {
                    gvDetalleVenta.Rows.Add(txtCodigoProducto.Text, inventario.NombreProducto, nudCantidad.Value.ToString(), txtPrecio.Text, decimal.Parse(txtPrecio.Text) * nudCantidad.Value,inventario.ImpuestoAcumulado,inventario.IdInventario);
                }
                SumarTotalGrid();
                calcularImpuesto();
                calcularSubTotal();
                gridActivo = false;
                Limpiar();

            }
            else
            {
                MessageBox.Show("Hay campos no validos","Ventas",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Función encargada de limpiar los textbox del frmNuevaVenta
        /// </summary>
        private void Limpiar()
        {
            txtCodigoProducto.Focus();
            txtCodigoProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 0;
        }

        private void gvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// estructura de control encargada de asignar ciertos valores del gvDetalle en los textbox correspondientes
            if (gvDetalleVenta.Rows.Count>0)
            {
                txtCodigoProducto.Text = gvDetalleVenta[0, gvDetalleVenta.CurrentRow.Index].Value.ToString();
                nudCantidad.Value = decimal.Parse(gvDetalleVenta[2, gvDetalleVenta.CurrentRow.Index].Value.ToString());
                txtPrecio.Text = gvDetalleVenta[3, gvDetalleVenta.CurrentRow.Index].Value.ToString();
                txtCodigoProducto.Focus();
                gridActivo = true;
            }
            
        }

        private bool ExisteValor()
        {
            for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
            {
                if (txtCodigoProducto.Text == gvDetalleVenta[0,i].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridActivo || ExisteValor())
            {
                for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
                    {
                        if (gvDetalleVenta[0, i].Value.ToString() == txtCodigoProducto.Text)
                        {
                            gvDetalleVenta[2, i].Value = nudCantidad.Value.ToString();
                            gvDetalleVenta[4, i].Value = Int16.Parse(gvDetalleVenta[2, i].Value.ToString()) * Decimal.Parse(txtPrecio.Text);
                            gvDetalleVenta[3, i].Value = txtPrecio.Text;
                            SumarTotalGrid();
                            calcularImpuesto();
                            calcularSubTotal();
                            Limpiar();
                        }
                    }
                gridActivo = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro que desea modificar","Ventas",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gridActivo)
            {
                gvDetalleVenta.Rows.RemoveAt(gvDetalleVenta.CurrentRow.Index);
                SumarTotalGrid();
                calcularImpuesto();
                calcularSubTotal();
                Limpiar();
                gridActivo = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro que desea eliminar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar) | e.KeyChar=='.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            lblNombreVendedor.Text = DataRepository.PropiedadesInicioSesion.nombreUsuario;
        }

        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text!="")
            {
                if (consultarProducto.CodigoProducto(txtCodigoProducto.Text))
                {
                    txtPrecio.Text = inventario.PrecioVenta.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoProducto.Focus();
                }
            }
            
            
        }

        private bool calcularImpuesto()
        {
            decimal totalValorImpuesto=0;
            for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
			{
                impuesto.CodigoProductoImpuesto(Int32.Parse(gvDetalleVenta[6, i].Value.ToString()));
                gvDetalleVenta[5,i].Value=decimal.Parse( gvDetalleVenta[4,i].Value.ToString())* inventario.ImpuestoAcumulado ;
                totalValorImpuesto += decimal.Parse(gvDetalleVenta[5, i].Value.ToString());
                inventario.ImpuestoAcumulado = -inventario.ImpuestoAcumulado;
			}
            lblValorIsv.Text = totalValorImpuesto.ToString();
            inventario.ImpuestoAcumulado = -inventario.ImpuestoAcumulado  ;
            return true;
            
        }

        private void calcularSubTotal()
        {
            lblValorSubTotal.Text = Convert.ToString( decimal.Parse(lblValorTotal.Text) - decimal.Parse(lblValorIsv.Text));
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (lblCliente.Text!="")
            {
                if (gvDetalleVenta.Rows.Count > 0)
                {
                    ActualizarInventario();
                    try
                    {
                        string sql;
                        sql = @"insert into Venta.Ventas (FechaVenta, SubTotal, Total, Observaciones, FechaCreacion, CreadoPor, FechaModificacion, ModificadoPor, IdCLientesProveedores, EstadoFactura, IdUsuario) 
                        values(@fechaVenta,@subTotal,@total,@observaciones,@fechaCreacion,@creadoPor,@fechaModificacion,@modificadoPor,@idClientesProveedores,@estadoFactura,@idUsuario) ";

                        myCommand = conn.Comando(sql);
                        using (myCommand)
                        { /*DataRepository.PropiedadesInicioSesion.IdUsuario*/
                            myCommand.Parameters.Add("@fechaVenta", SqlDbType.DateTime).Value = dtpFechaVenta.Value;
                            myCommand.Parameters.Add("@subTotal", SqlDbType.Money).Value = decimal.Parse(lblValorSubTotal.Text);
                            myCommand.Parameters.Add("@total", SqlDbType.Money).Value = decimal.Parse(lblValorTotal.Text);
                            myCommand.Parameters.Add("@observaciones", SqlDbType.Text).Value = txtObservaciones.Text;
                            myCommand.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = dtpFechaVenta.Value;
                            myCommand.Parameters.Add("@creadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                            myCommand.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = dtpFechaVenta.Value;
                            myCommand.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                            myCommand.Parameters.Add("@idClientesProveedores", SqlDbType.Int).Value = cliente.IdClientesProveedores;
                            myCommand.Parameters.Add("@estadoFactura", SqlDbType.Bit).Value = 1;
                            myCommand.Parameters.Add("@idUsuario", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                        }
                        conn.DbOpen();
                        myCommand.ExecuteNonQuery();
                        myCommand = conn.Comando(@"select IDENT_CURRENT('Venta.Ventas')");
                        DataRepository.Ventas.idVenta = Int32.Parse(myCommand.ExecuteScalar().ToString());

                        for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
                        {
                            sql = @"Insert into Venta.Detalle_Ventas values (@numeroProducto,@cantidadProducto,@precioUnitario,@descripcion,@fechaCreacion,@creadoPor,@fechaModificacion,@modificadoPor,@idInventario,@idVenta)";
                            myCommand = conn.Comando(sql);
                            using (myCommand)
                            {
                                myCommand.Parameters.Add("@numeroProducto", SqlDbType.Int).Value = i;
                                myCommand.Parameters.Add("@cantidadProducto", SqlDbType.Int).Value = Int32.Parse(gvDetalleVenta[2, i].Value.ToString());
                                myCommand.Parameters.Add("@precioUnitario", SqlDbType.Money).Value = Decimal.Parse(gvDetalleVenta[3, i].Value.ToString());
                                myCommand.Parameters.Add("@descripcion", SqlDbType.Text).Value = gvDetalleVenta[1, i].Value.ToString();
                                myCommand.Parameters.Add("@fechaCreacion", SqlDbType.DateTime).Value = dtpFechaVenta.Value;
                                myCommand.Parameters.Add("@creadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                                myCommand.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = dtpFechaVenta.Value;
                                myCommand.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                                myCommand.Parameters.Add("@idInventario", SqlDbType.Int).Value = Int32.Parse(gvDetalleVenta[6, i].Value.ToString());
                                myCommand.Parameters.Add("@idVenta", SqlDbType.Int).Value = DataRepository.Ventas.idVenta;
                            }
                            myCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show("Imprimiendo Factura", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserInterface.Ventas.frmFactura fac = new UserInterface.Ventas.frmFactura();
                        this.Dispose();
                        fac.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.DbClose();
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros para imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un cliente valido","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtIdCliente.Focus();
            }
            
            
            
        }

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            Services.SucursalCRUD obtenerNombreCliente = new Services.SucursalCRUD();
            if (obtenerNombreCliente.ObtenerIdClientesProveedor(txtIdCliente.Text)!=0)
            {
                lblCliente.Text = cliente.Nombres + " "+ cliente.Apellidos;    
            }
            else
            {
                cliente.Nombres = "";
                cliente.Apellidos = "";
                lblCliente.Text = "";
            }
            
            
        }

        private void ActualizarInventario()
        {
            string sql;
            try
            {
                conn.DbOpen();
                for (int i = 0; i < gvDetalleVenta.Rows.Count; i++)
                {
                    sql = @"update Inventario.Inventario set CantidadProducto = CantidadProducto - @cantidadProducto where IdInventario = @idInventario";
                    myCommand = conn.Comando(sql);
                    using (myCommand)
                    {
                        myCommand.Parameters.Add("@cantidadProducto", SqlDbType.Int).Value = Int32.Parse(gvDetalleVenta[2, i].Value.ToString());
                        myCommand.Parameters.Add("@idInventario", SqlDbType.Int).Value = Int32.Parse(gvDetalleVenta[6, i].Value.ToString());
                    }

                    myCommand.ExecuteNonQuery();
                }
                
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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            UserInterface.ClientesProveedores.frmAgregarClienteProveedor frmnuevoCliente = new UserInterface.ClientesProveedores.frmAgregarClienteProveedor();
            frmnuevoCliente.ShowDialog(this);
        }

        private void nudCantidad_Leave(object sender, EventArgs e)
        {
            if (inventario.Cantidad < nudCantidad.Value && txtCodigoProducto.Text!="")
            {
                MessageBox.Show("La cantidad solicitada excede a la cantidad en existencia","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                nudCantidad.Focus();
                nudCantidad.Value = 0;
            }
        }

        
    }
}
