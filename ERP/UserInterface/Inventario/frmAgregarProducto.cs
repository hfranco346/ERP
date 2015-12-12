using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.UserInterface.Inventario
{
    public partial class frmAgregarProducto : Form
    {
        //Creando nuevo objeto para acceder a las propiedades
        DataRepository.Inventario Producto = new DataRepository.Inventario();
        //Creando nuevo objeto para insertar
        Services.InventarioCRUD Agregar = new Services.InventarioCRUD();
        public frmAgregarProducto()
        {
            InitializeComponent();
        }
        //Cargar el combobox con el nombre de proveedor
        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            Agregar.PopularComboboxProveedor(cbProveedor);
            cbProveedor.SelectedText="Seleccione un Proveedor";
        }
        //Validar que al usuario no se le permita dejar campos vacíos
        Boolean Validar_CajasTexto()
        {
            if (txtCodigoProducto.Text.ToString() == "")
            {

                epValidarTextos.SetError(txtCodigoProducto, "Ingrese un código de barra al producto");
                txtCodigoProducto.Focus();
                return false;
            }
            else if (txtNombreProducto.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtNombreProducto, "Ingrese un nombre al producto");
                txtNombreProducto.Focus();
                return false;
            }
            else if (txtDescripcion.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtDescripcion, "Ingrese una descripción de producto");
                txtDescripcion.Focus();
                return false;
            }
            else if (txtCantidadProducto.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtCantidadProducto, "Ingrese una cantidad de producto");
                txtCantidadProducto.Focus();
                return false;
            }
            else if (txtPrecioCompra.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtPrecioCompra, "Ingrese un precio de compra al producto");
                txtPrecioCompra.Focus();
                return false;
            }
            else if (txtPrecioVenta.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtPrecioVenta, "Ingrese un precio de venta al producto");
                txtPrecioVenta.Focus();
                return false;
            }
            else if (txtPuntoReorden.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtPuntoReorden, "Ingrese un punto de reorden al producto");
                txtPuntoReorden.Focus();
                return false;
            }
            else if (cbProveedor.Text.ToString() == "Seleccione un Proveedor")
            {
                epValidarTextos.SetError(cbProveedor, "Seleccione un proveedor para este producto");
                cbProveedor.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        //Validar para tener la facilidad de usar la tecla enter
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
        //Validar que sólo se permitan Valores numericos decimales
        bool validar_NumerosDecimales(Boolean s, char t)
        {
            //grafo 3
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
        //Validar valores enteros
        bool validar_NumerosEnteros(Boolean s, char t)
        {
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
        //Validar el código de barra que sólo se permitan letras y números
        bool Validar_CodigoBarra(Boolean s, char t)
        {
            if (s)
            {
                if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                    return true;
                }
                else if (char.IsPunctuation(t))
                {
                    return false;
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
        //Botón agregar con sus respectivos campos y especificaciones dadas
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar_CajasTexto() == true)
            {
                if (txtCodigoProducto.Text.Length >= 13 && txtCodigoProducto.Text.Length <= 25)
                {
                        Producto.CodigoBarra = txtCodigoProducto.Text.ToString();
                        Producto.NombreProducto = txtNombreProducto.Text.ToString();
                        Producto.DescripcionProducto = txtDescripcion.Text.ToString();
                        Producto.CantidadProducto = int.Parse(txtCantidadProducto.Text);
                        Producto.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
                        Producto.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
                        Producto.PuntoReorden = int.Parse(txtPuntoReorden.Text);
                        Producto.FechaElaboracionProducto = dtpFechaElabProducto.Value;
                        Producto.FechaVencimientoProducto = dtpFechaVencProducto.Value;
                        Producto.FechaCreacion = DateTime.Now;
                        Producto.CreadoPor = DataRepository.PropiedadesInicioSesion.IdUsuario;
                        Producto.FechaModificacion = DateTime.Now;
                        Producto.ModificadoPor = DataRepository.PropiedadesInicioSesion.IdUsuario;
                        Producto.EstadoProducto = Convert.ToBoolean(1);
                        Producto.IdProveedor = int.Parse(cbProveedor.SelectedValue.ToString());

                        //Se hace para mandar el codigo de producto y luego
                        //Obtener el idInventario
                        Producto.IdInventarios = txtCodigoProducto.Text.ToString();
                        if (Agregar.SqlInsert(Producto))
                        {
                            MessageBox.Show("Agregado Exitosamente");
                        }
                        txtCodigoProducto.Clear();
                        txtNombreProducto.Clear();
                        txtDescripcion.Clear();
                        txtCantidadProducto.Clear();
                        txtPrecioVenta.Clear();
                        txtPrecioCompra.Clear();
                        txtPuntoReorden.Clear();
                    //Cuando creamos el producto le permite al usuario agregarle el impuesto a ese producto
                        UserInterface.Inventario.frmAgregarImpuesto Impuestos = new UserInterface.Inventario.frmAgregarImpuesto();
                        Impuestos.Show();
                }
                else
                {
                    MessageBox.Show("El código de producto debe ser mayor o igua a 13 y menor o igual a 25");
                    txtCodigoProducto.Focus();
                }
            }
        }

        //Validar el campo cantidadProducto que sólo se permitan enteros
        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
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
        //Validar que en el código de barra sólo se puedan ingresar letras y números, no se permiten caracteres especiales.
        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar_CodigoBarra(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            } 
        }
        //Validar el campo precioCompra que solo permita números enteros y decimales
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
        //Validar el campo precioVenta que sólo se permitan números enteros y decimales
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
        //Validar el campo puntoReorden que sólo se permitan valores enteros
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
        //Validar tecla enter
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
        //Validar tecla enter
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
        //validar tecla enter
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
        //Validar tecla enter
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
        //Validar tecla enter
        private void cbProveedor_KeyPress(object sender, KeyPressEventArgs e)
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
        //Validar tecla enter
        private void btnAgregar_KeyPress(object sender, KeyPressEventArgs e)
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
        //Validar tecla enter
        private void btnSalir_KeyPress(object sender, KeyPressEventArgs e)
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
        //Botón cerrar ventana actual
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            txtCantidadProducto.Clear();
            txtPrecioVenta.Clear();
            txtPrecioCompra.Clear();
            txtPuntoReorden.Clear();
            this.Hide();
        }
        //Verificar si el código de producto ingresado existe
        //En caso de que exista no permitirá guardar de lo contrario se agregará con éxito
        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            if (Agregar.VerificarProducto(txtCodigoProducto))
            {
                MessageBox.Show("Este Producto Ya Existe!!!");
                txtCodigoProducto.Clear();
                txtCodigoProducto.Focus();
            }
            else if (txtCodigoProducto.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }

        //----------------------------------------------------------------------------------------------------------------------
        //Validaciones en los campos donde son obligatorios llenar
        //NOTA: cuando estos se dejan vacíos el errorProvider se activará, cuando el usuario llene el campo este se limpiará
        //Acontinuación cada proceso en los campos obligatorios:
        //----------------------------------------------------------------------------------------------------------------------

        //Limpia el error cuando se escribe un nombre de producto
        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }
        //Limpia el error cuando se escribe una descripción de producto
        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }
        //Limpia el error cuando se escribe una cantidad de producto
        private void txtCantidadProducto_Leave(object sender, EventArgs e)
        {
            if (txtCantidadProducto.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }
        //Limpia el error cuando escribre un precio de compra
        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }

        //Se limpia el error cuando escribe un precio de venta
        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }
        //Se limpia el error en el campo punto de reorden cuando escribe una cantidad
        private void txtPuntoReorden_Leave(object sender, EventArgs e)
        {
            if (txtPuntoReorden.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }
        //Se limpia el combobox cuando se selecciona una opción
        private void cbProveedor_Leave(object sender, EventArgs e)
        {
            if (cbProveedor.Text.ToString() != "Seleccione un Proveedor")
            {
                epValidarTextos.Clear();
            }
        }
    }
}
