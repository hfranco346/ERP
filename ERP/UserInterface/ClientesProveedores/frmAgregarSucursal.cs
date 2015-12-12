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
    public partial class frmAgregarSucursal : Form
    {
        public frmAgregarSucursal()
        {
            InitializeComponent();
        }

        // Creando un nuevo objeto para acceder a las propiedades
        DataRepository.Sucursal Srl = new DataRepository.Sucursal();
        Services.SucursalCRUD SrlCRUD = new Services.SucursalCRUD();

        private void gbInsertarSucursal_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalirAgregarSucursal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Agregar los datos de la sucursal a la base de datos
        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            if (ValidarTexto() == true)
            {
                Srl.NombreSucursal = txtNombre.Text.ToString();
                Srl.DireccionSucursal = txtDireccion.Text.ToString();
                Srl.FechaCreacion = DateTime.Now;
                Srl.CreadoPor = 1;
                Srl.FechaModificacion = DateTime.Now;
                Srl.ModificadoPor = 1;
                Srl.IdClientesProveedores = int.Parse(cbIdProveedor.SelectedValue.ToString());
                if (SrlCRUD.sqlAgregar(Srl))
                {
                    MessageBox.Show("Se ha agregado exitosamente", "Agregando sucursal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Uno o más campos no se han agregado correctamente, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAgregarSucursal_Load(object sender, EventArgs e)
        {

        }

        private void cbIdProveedor_Click(object sender, EventArgs e)
        {
            PopularIdProveedor();
        }
        // Mostrar en el combobox el nombre de los proveedores según su Id
        private void PopularIdProveedor()
        {
            ComboBox cbP = new ComboBox();
            DataRepository.ClientesProveedores PCE = new DataRepository.ClientesProveedores();
            Services.ClientesProveedoresCRUD CP = new Services.ClientesProveedoresCRUD();
            cbIdProveedor.DataSource = CP.ConsultarIdProveedor();
            cbIdProveedor.DisplayMember = "Nombres";
            cbIdProveedor.ValueMember = "IdClientesProveedores";
        }

        private void cbIdProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        // Validando que los contenedores no se enccueentren vacíos
        Boolean ValidarTexto()
        {
            if (txtNombre.Text.ToString() == "")
            {
                epValidarTexto.SetError(txtNombre, "Ingrese el nombre de la sucursal");
                txtNombre.Focus();
                return false;
            }
            if (txtDireccion.Text.ToString() == "")
            {
                epValidarTexto.SetError(txtDireccion, "Ingrese la dirección de la sucursal ");
                txtDireccion.Focus();
                return false;
            }
            if (cbIdProveedor.Text.ToString() == "")
            {
                epValidarTexto.SetError(cbIdProveedor, "Seleccione el proveedor que será miembro de la sucursal");
                cbIdProveedor.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        // El error provider desaparecerá luego de cumplir ciertos requisitos
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text.ToString() != "")
            {
                epValidarTexto.Clear();
            }
        }
        // El error provider desaparecerá luego de cumplir ciertos requisitos
        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text.ToString() != "")
            {
                epValidarTexto.Clear();
            }
        }
        // El error provider desaparecerá luego de cumplir ciertos requisitos
        private void cbIdProveedor_Leave(object sender, EventArgs e)
        {
            if (cbIdProveedor.Text.ToString() != "")
            {
                epValidarTexto.Clear();
            }
        }
    }
}
