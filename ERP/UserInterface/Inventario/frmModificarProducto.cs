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
    public partial class frmModificarProducto : Form
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        Services.InventarioCRUD Agregar = new Services.InventarioCRUD();
        public frmModificarProducto()
        {
            InitializeComponent();
        }
        //Carga todos los productos en la lista para modificar
        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
            List<DataRepository.Inventario> productos = Services.InventarioCRUD.CargarCodigoProducto();
            try
            {
                if (productos.Any())
                {
                    lstProductos.Items.Add("\n");
                    lstProductos.Items.Add("                  Productos en Inventario:\n");
                    lstProductos.Items.Add("_________________________________________________________________________\n");
                    lstProductos.Items.Add("\n");

                    productos.ForEach(producto => lstProductos.Items.Add(producto.NombreProducto));
                }
                else
                    lstProductos.Items.Add("¡Error al momento de cargar los productos!");
            }
            catch (Exception)
            { }
        }

        //Modifica los campos que el usuario ingreso justificando por qué se modificó, cumpliendo con las especificaciones dadas.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex != -1)
            {
                if (Validar_CajasTexto() == true)
                {
                    if (txtCodigoProducto.Text.Length >= 13 && txtCodigoProducto.Text.Length <= 25)
                    {
                        string sql = @"UPDATE Inventario.Inventario SET NombreProducto = @nombreProducto,CodigoBarra=@codigoBarra,
                                  DescripcionProducto = @descripcionProducto,PrecioCompra=@precioCompra,PrecioVenta=@precioVenta,
                                  PuntoReorden = @puntoReorden,FechaElaboracionProducto = @fechaElaboracionProducto,
                                  FechaVencimientoProducto = @fechaVencimientoProducto,
                                  CantidadProducto = @cantidadProducto,Observaciones = @observaciones,FechaModificacion=@fechaModificacion,ModificadoPor=@modificadoPor
                                  WHERE NombreProducto = @nombreProducto";
                        SqlCommand myCommand = conn.Comando(sql);
                        try
                        {
                            conn.DbOpen();
                            using (myCommand)
                            {
                                myCommand.Parameters.Add("@nombreProducto", SqlDbType.NVarChar, 25).Value = lstProductos.SelectedItem.ToString();
                                myCommand.Parameters.Add("@codigoBarra", SqlDbType.NVarChar, 25).Value = txtCodigoProducto.Text;
                                myCommand.Parameters.Add("@descripcionProducto", SqlDbType.Text).Value = txtDescripcion.Text;
                                myCommand.Parameters.Add("@precioCompra", SqlDbType.Money).Value = txtPrecioCompra.Text;
                                myCommand.Parameters.Add("@precioVenta", SqlDbType.Money).Value = txtPrecioVenta.Text;
                                myCommand.Parameters.Add("@puntoReorden", SqlDbType.Int).Value = txtPuntoReorden.Text;
                                myCommand.Parameters.Add("@fechaElaboracionProducto", SqlDbType.DateTime).Value = dtpFechaElabProducto.Text;
                                myCommand.Parameters.Add("@fechaVencimientoProducto", SqlDbType.DateTime).Value = dtpFechaVencProducto.Text;
                                myCommand.Parameters.Add("@cantidadProducto", SqlDbType.Int).Value = txtCantidad.Text;
                                myCommand.Parameters.Add("@observaciones", SqlDbType.Text).Value = txtObservaciones.Text;
                                myCommand.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;
                                myCommand.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                            }
                            myCommand.ExecuteNonQuery();
                            MessageBox.Show("Producto Modifcado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodigoProducto.Clear();
                            txtCantidad.Clear();
                            txtDescripcion.Clear();
                            txtNombreProducto.Clear();
                            txtPrecioCompra.Clear();
                            txtPrecioVenta.Clear();
                            txtPuntoReorden.Clear();
                            dtpFechaElabProducto.Value = DateTime.Now;
                            dtpFechaVencProducto.Value = DateTime.Now;
                            txtObservaciones.Clear();
                        }
                        catch (FormatException fex)
                        {
                            MessageBox.Show(fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        catch (SqlException ex)
                        {
                            //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Este código de producto ya existe");
                            txtCodigoProducto.Focus();
                        }
                        finally
                        {
                            conn.DbClose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El código de producto debe ser mayor o igua a 13 y menor o igual a 25");
                        txtCodigoProducto.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciones un código de producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Validaciones --------------------------------------------------------------------
        //Validar que al presionar la tecla enter pase al siguiente campo
        bool Validar_TabulacionEnter(Boolean s, char t)
        {
            if (s)
            {
                if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                }
                return true;
            }
        }
        //Valores numericos decimales
        //Validar que al escribir letras en campos decimales no le permita al usuario.
        bool validar_NumerosDecimales(Boolean s, char t)
        {
            if (s)
            {
                if (char.IsLetter(t))
                {
                    return false;
                }
                else if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                }
                return true;
            }
        }

        //Valores numericos enteros
        //Permite al usuario no escribir letras ni caracteres en campos enteros
        bool validar_NumerosEnteros(Boolean s, char t)
        {
            //grafo 3
            if (s)
            {
                if (char.IsLetter(t))
                {
                    return false;
                }
                else if (char.IsPunctuation(t))
                {
                    return false;
                }
                else if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                }
                return true;
            }
        }
        //Validar que no se permitan cajas de texto vacias
        Boolean Validar_CajasTexto()
        {
            if (txtCodigoProducto.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtCodigoProducto, "Ingrese un código de producto");
                txtCodigoProducto.Focus();
                return false;
            }

            else if (txtNombreProducto.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtNombreProducto, "Ingrese un nombre de producto");
                txtNombreProducto.Focus();
                return false;
            }

            else if (txtDescripcion.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtDescripcion, "Ingrese una descripción de producto");
                txtDescripcion.Focus();
                return false;
            }

            else if (txtPrecioCompra.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtPrecioCompra, "Ingrese un precio de compra");
                txtPrecioCompra.Focus();
                return false;
            }
            else if (txtPrecioVenta.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtPrecioVenta, "Ingrese un precio de venta");
                txtPrecioVenta.Focus();
                return false;
            }

            else if (txtPuntoReorden.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtPuntoReorden, "Ingrese un punto de reorden del producto");
                txtPuntoReorden.Focus();
                return false;
            }

            else if (txtCantidad.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtCantidad, "Ingrese una cantidad de producto");
                txtCantidad.Focus();
                return false;
            }
            else if (txtObservaciones.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtObservaciones, "Justifique por qué se modificó");
                txtObservaciones.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //Cargar los datos del producto a los textBox según el producto seleccionado para ser modificados.
        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT IdInventario, CodigoBarra, NombreProducto, DescripcionProducto, FechaElaboracionProducto, FechaVencimientoProducto, PrecioCompra, PrecioVenta, CantidadProducto,PuntoReorden,Observaciones FROM Inventario.Inventario WHERE NombreProducto = @nombreProducto";
            try
            {
                SqlCommand myCommand = conn.Comando(sql);
                try
                {
                    conn.DbOpen();
                    using (myCommand)
                    {
                        myCommand.Parameters.Add("@nombreProducto", SqlDbType.NVarChar,25).Value = lstProductos.SelectedItem.ToString();
                    }
                    SqlDataReader dtr = myCommand.ExecuteReader();
                    while (dtr.Read())
                    {
                        lstProductos.Text = dtr.GetString(1).Trim() + dtr.GetString(3).Trim() + " ";
                        txtCodigoProducto.Text = dtr.GetString(1).Trim();
                        txtNombreProducto.Text = dtr.GetString(2).Trim();
                        txtDescripcion.Text = dtr.GetString(3).Trim();
                        dtpFechaElabProducto.Text = dtr.GetDateTime(4).ToString();
                        dtpFechaVencProducto.Text = dtr.GetDateTime(5).ToString();
                        txtPrecioCompra.Text = dtr.GetDecimal(6).ToString().Trim();
                        txtPrecioVenta.Text = dtr.GetDecimal(7).ToString().Trim();
                        txtCantidad.Text = dtr.GetInt32(8).ToString();
                        txtPuntoReorden.Text = dtr.GetInt32(9).ToString();
                        //txtObservaciones.Text = dtr.GetString(10).Trim();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.DbClose();
                }
            }
            catch (Exception) { }
        }
        
        
        //Tecla enter
        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar_TabulacionEnter(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Sólo permitir números decimales
        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validar_NumerosDecimales(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Sólo permitir números decimales
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validar_NumerosDecimales(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Sólo permitir números enteros
        private void txtPuntoReorden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validar_NumerosEnteros(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Sólo permitir números enteros
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validar_NumerosEnteros(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Cuando el usuario ingrese una observación que el error se limpie.
        private void txtObservaciones_Leave(object sender, EventArgs e)
        {
            if (txtObservaciones.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }
        //Tecla enter
        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar_TabulacionEnter(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Tecla enter
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar_TabulacionEnter(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Tecla enter
        private void dtpFechaElabProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar_TabulacionEnter(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Tecla enter
        private void dtpFechaVencProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar_TabulacionEnter(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Botón cerrar ventana acual
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
