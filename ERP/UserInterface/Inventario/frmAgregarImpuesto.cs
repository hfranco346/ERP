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
    public partial class frmAgregarImpuesto : Form
    {
        //Creando nuevo objeto para acceder a las propiedades
        DataRepository.Impuesto ISV = new DataRepository.Impuesto();
        //Creando nuevo objeto para insertar
        Services.InventarioCRUD Agregar = new Services.InventarioCRUD();
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public frmAgregarImpuesto()
        {
            InitializeComponent();
        }

        //Validar con errorProvider que el usuario no deje campos vacíos.
        Boolean Validar_CajasTexto()
        {

            if (cbProducto.Text.ToString() == "Seleccione un Producto")
            {

                epValidarTextos.SetError(cbProducto, "Seleccione un producto");
                cbProducto.Focus();
                return false;
            }

            else if (txtValorImpuesto.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtValorImpuesto, "Ingrese un valor de impuesto al producto");
                txtValorImpuesto.Focus();
                return false;
            }
            else if (txtDescripcion.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtDescripcion, "Ingrese una descripción de producto");
                txtDescripcion.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private void frmAgregarImpuesto_Load(object sender, EventArgs e)
        {
            //Carga los producto al combobox para asignarles un impuesto.
            Agregar.PopularComboboxProducto(cbProducto);
            cbProducto.Text = "Seleccione un Producto";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierra el formulario actual(agregar impuestos) y muestra el de agregar producto
            this.Hide();

        }
        //Valida que al presionar la tecla enter se salte a otro campo
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

        //Agregar el producto y que cumpla con las especificaciones dadas.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProducto.Text.ToString() == "Seleccione un Producto")
                {
                    MessageBox.Show("Debe seleccionar un producto");
                }
                else
                {
                    //Validar si el producto(codigoBarra) ya existe.
                    if (Agregar.VerificarValorImpuesto(txtValorImpuesto, cbProducto))
                    {
                        MessageBox.Show("Este producto ya tiene este impuesto!!!");
                        txtValorImpuesto.Clear();
                        txtValorImpuesto.Focus();
                    }
                    else
                    {
                        ISV.Valor = decimal.Parse(txtValorImpuesto.Text);
                        ISV.DescripcionImpuesto = txtDescripcion.Text.ToString();
                        ISV.FechaCreacion = DateTime.Now;
                        ISV.CreadoPor = DataRepository.PropiedadesInicioSesion.IdUsuario;
                        ISV.FechaModificacion = DateTime.Now;
                        ISV.ModificadoPor = DataRepository.PropiedadesInicioSesion.IdUsuario;
                        ISV.IdInventario = Convert.ToInt32(cbProducto.SelectedValue.ToString());
                        ISV.EstadoImpuesto = Convert.ToBoolean(1);
                        if (Agregar.SqlInsertarImpuesto(ISV))
                        {
                            MessageBox.Show("Agregado Exitosamente");
                        }
                    }
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.DbClose();
            }
        }

        //Valida que los campos decimales no acepten letras.
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
        //Validar que los campos enteros no permitas letras ni caracteres especiales.
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

        //Valida que no se pueda ingresar letras en el campo Valor Impuesto
        private void txtValorImpuesto_KeyPress(object sender, KeyPressEventArgs e)
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
        //Valida que después de elegir un producto se inhabilite el errorProvider
        private void cbProducto_Leave(object sender, EventArgs e)
        {
            if (cbProducto.Text.ToString() != "Seleccione un Proveedor")
            {
                epValidarTextos.Clear();
            }
        }
        //Valida que después escribir un ValorImpuesto
        private void txtValorImpuesto_Leave(object sender, EventArgs e)
        {
            if (txtValorImpuesto.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }
        //Valida que después escribir una descripción de impuesto
        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }

        //Tabulación enter
        private void cbProducto_KeyPress(object sender, KeyPressEventArgs e)
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
        //Tabulación enter
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
        //Tabulación enter
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
        //Tabulación enter
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
    }
}
