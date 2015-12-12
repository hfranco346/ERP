using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.UserInterface.ClientesProveedores
{
    public partial class frmActualizarTelefonosClientesProveedores : Form
    {
        // Inicializando componentes
        public frmActualizarTelefonosClientesProveedores()
        {
            InitializeComponent();
        }

        // Actualizando las listas de teléfonos al iniciar el form
        private void frmActualizarTelefonosClientesProveedores_Load(object sender, EventArgs e)
        {
            Services.TelefonosCRUD NuevoTelefono = new Services.TelefonosCRUD();

            NuevoTelefono.ObtenerTelefonos(NuevoTelefono.ObtenerIdClientesProveedor(DataRepository.Telefonos.Id));

            PopularListar();
        }
        // Cerrando el form
        private void btnCerrarActualizarNumeros_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Actualizando las listas de teléfonos
        public void PopularListar()
        {
            Services.TelefonosCRUD Telefonos = new Services.TelefonosCRUD();
            Telefonos.ObtenerTelefonos(Telefonos.ObtenerIdClientesProveedor(DataRepository.Telefonos.Id));

            foreach (var item in Telefonos.NuevoTelefono.TelefonosFijos)
            {
                lstNumerosFijos.Items.Add(item);
            }
            foreach (var item in Telefonos.NuevoTelefono.TelefonosMoviles)
            {
                lstNumerosMovil.Items.Add(item);
            }
        }
        // Actualizar los numeros del cliente/proveedor con los números ingresados
        private void btnActualizarNumeroClienteProveedor_Click(object sender, EventArgs e)
        {
            Services.TelefonosCRUD NuevoTelefono = new Services.TelefonosCRUD();

            if (mskFijoClienteProveedor.Text != "    -")
            {
                if (mskFijoClienteProveedor.Text != lstNumerosFijos.SelectedItem)
                {
                    NuevoTelefono.ActulizarTelefono(NuevoTelefono.ObtenerIdtelefono(NuevoTelefono.ObtenerIdClientesProveedor(DataRepository.Telefonos.Id), lstNumerosFijos.SelectedItem.ToString(), "NumeroFijo"), true, mskFijoClienteProveedor.Text);
                    Limpiar();
                }

            }
            else
            {
                MessageBox.Show("El teléfono fijo no se ha ingresado correctamente, por favor, verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (mskMovilClienteProveedor.Text != "    -")
            {
                if (mskMovilClienteProveedor.Text != lstNumerosMovil.SelectedItem)
                {
                    NuevoTelefono.ActulizarTelefono(NuevoTelefono.ObtenerIdtelefono(NuevoTelefono.ObtenerIdClientesProveedor(DataRepository.Telefonos.Id), lstNumerosMovil.SelectedItem.ToString(), "NumeroMovil"), true, mskMovilClienteProveedor.Text);
                    Limpiar();
                }

            }
            else
            {
                MessageBox.Show("El teléfono móvil no se ha ingresado correctamente, por favor, verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lstNumerosFijos.Items.Clear();
            lstNumerosMovil.Items.Clear();
            mskFijoClienteProveedor.Clear();
            mskMovilClienteProveedor.Clear();
            NuevoTelefono.ObtenerTelefonos(NuevoTelefono.ObtenerIdClientesProveedor(DataRepository.Telefonos.Id));
            PopularListar();
        }
        // Utilizar un número seleccionado
        private void lstNumerosFijos_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskFijoClienteProveedor.Text = lstNumerosFijos.SelectedItem.ToString();
        }
        // Utilizar un número seleccionado
        private void lstNumerosMovil_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskMovilClienteProveedor.Text = lstNumerosMovil.SelectedItem.ToString();
        }

        private void gbNumeroTelefonosClientesProveedores_Enter(object sender, EventArgs e)
        {

        }
        // Validar los que sólo se ingresen números
        private void mskFijoClienteProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        // Validar los que sólo se ingresen números
        private void mskMovilClienteProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        // Limpiando los textbox
        private void Limpiar()
        {
            mskFijoClienteProveedor.Text = "    -";
            mskMovilClienteProveedor.Text = "    -";
        }
        // Validar que los campos no se encuentren vacios
        Boolean ValidarNumeros()
        {
            if (mskFijoClienteProveedor.Text.ToString() == "    -")
            {
                epValidarNumeros.SetError(mskFijoClienteProveedor, "Ingrese un teléfono fijo válido del cliente/proveedor");
                mskFijoClienteProveedor.Focus();
                return false;
            }
            if (mskMovilClienteProveedor.Text.ToString() == "    -")
            {
                epValidarNumeros.SetError(mskMovilClienteProveedor, "Ingrese un teléfono móvil válido del cliente/proveedor");
                mskMovilClienteProveedor.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        // Validar que el formato ingresado sea el correcto
        private void mskFijoClienteProveedor_Leave(object sender, EventArgs e)
        {
            if (mskFijoClienteProveedor.Text.ToString() != "    -" && mskFijoClienteProveedor.Text.Length == 9)
            {
                epValidarNumeros.Clear();
            }
        }
        // Validar que el formato ingresado sea el correcto}
        private void mskMovilClienteProveedor_Leave(object sender, EventArgs e)
        {
            if (mskMovilClienteProveedor.Text.ToString() != "    -" && mskMovilClienteProveedor.Text.Length == 9)
            {
                epValidarNumeros.Clear();
            }
        }
    }
}
