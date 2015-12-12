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
    public partial class frmTelefonosClientesProveedores : Form
    {
        // Inicializando los componentes
        public frmTelefonosClientesProveedores()
        {
            InitializeComponent();
        }
        // Validar si ya se han agregado teléfonos antes de poder salir
        private void btnSalirAgregarTelefonosClienteProveedor_Click(object sender, EventArgs e)
        {
            if (Fijos.Items.Count > 0 && Fijos.Items.Count > 0)
            {  
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos un número de telefono fijo y un número de teléfono móvil válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTelefonosClientesProveedores_Load(object sender, EventArgs e)
        {
            PopularListar();
        }

        private void Móvil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpTelefonosClientes_Enter(object sender, EventArgs e)
        {

        }

        // Enlistar los teléfonos que han sido agregados en los listbox
        public void PopularListar()
        {
            Services.TelefonosCRUD Telefonos = new Services.TelefonosCRUD();
            Telefonos.ObtenerTelefonos(Telefonos.ObtenerIdClientesProveedor(DataRepository.Telefonos.Id));

            foreach (var item in Telefonos.NuevoTelefono.TelefonosFijos)
            {
                Fijos.Items.Add(item);
            }
            foreach (var item in Telefonos.NuevoTelefono.TelefonosMoviles)
            {
                Móvil.Items.Add(item);
            }
        }

        // Agregando los teléfonos ingresados en la base de datos
        private void btnAgregarTelefonosClienteProveedor_Click(object sender, EventArgs e)
        {
            if (ValidarNumeros() == true)
            {
                Services.TelefonosCRUD Telefonos = new Services.TelefonosCRUD();
                Telefonos.AgregarNumeros(1, 1, mskTelefonoFijoClienteProveedor.Text.ToString(), mskTelefonoMovilClienteProveedor.Text.ToString(), Telefonos.ObtenerIdClientesProveedor(DataRepository.Telefonos.Id));
                Limpiar();
                LimpiarLista();
                PopularListar();
             //   MessageBox.Show("Los teléfonos han sido agregados correctamente", "Teléfonos agregados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Verifique que ha ingresado correctamente ambos números de teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método que limpiará los contenedores de los teléfonos
        private void Limpiar()
        {
            mskTelefonoFijoClienteProveedor.Text = "    -";
            mskTelefonoMovilClienteProveedor.Text = "    -";
        }

        //Método que limpiara las listas que contienen los teléfonos
        private void LimpiarLista()
        {
            Fijos.Items.Clear();
            Móvil.Items.Clear();
        }

        // Validar que solo se pueda insertar números
        private void mskTelefonoFijoClienteProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        // Validar que solo se pueda insertar números
        private void mskTelefonoMovilClienteProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void Fijos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Validar que los contenedores no esten vacíos
        Boolean ValidarNumeros()
        {
            if (mskTelefonoFijoClienteProveedor.MaskFull == false)
            {
                epValidarNumeros.SetError(mskTelefonoFijoClienteProveedor, "Ingrese un teléfono fijo válido del cliente/proveedor");
                mskTelefonoFijoClienteProveedor.Focus();
                return false;
            }
            if (mskTelefonoMovilClienteProveedor.MaskFull == false)
            {
                epValidarNumeros.SetError(mskTelefonoMovilClienteProveedor, "Ingrese un teléfono móvil válido del cliente/proveedor");
                mskTelefonoMovilClienteProveedor.Focus();
                return false;
            }

            else
            {
                return true;
            }
        }

        // El error provider desaparecerá luego de cumplir los requisitos
        private void mskTelefonoFijoClienteProveedor_Leave(object sender, EventArgs e)
        {
            if (mskTelefonoFijoClienteProveedor.Text.ToString() != "    -" && mskTelefonoFijoClienteProveedor.Text.Length == 9)
            {
                epValidarNumeros.Clear();
            }
        }

        // El error provider desaparecerá luego de cumplir los requisitos
        private void mskTelefonoMovilClienteProveedor_Leave(object sender, EventArgs e)
        {
            if (mskTelefonoMovilClienteProveedor.Text.ToString() != "    -" && mskTelefonoMovilClienteProveedor.Text.Length == 9)
            {
                epValidarNumeros.Clear();
            }
        }
    }
}
