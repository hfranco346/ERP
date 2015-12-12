using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ERP.UserInterface.ClientesProveedores
{
    public partial class frmAgregarClienteProveedor : Form
    {
        public bool Estado= true;
        string RTNG;
        // Inicializando componentes
        public frmAgregarClienteProveedor()
        {
            InitializeComponent();
        }

        // Creando un nuevo objeto para acceder a las propiedades
        DataRepository.ClientesProveedores CP = new DataRepository.ClientesProveedores();
        Services.ClientesProveedoresCRUD CPCRUD = new Services.ClientesProveedoresCRUD();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAgregarTelefonos_Click(object sender, EventArgs e)
        {
            if (ValidarTexto() == true)
            {
                frmTelefonosClientesProveedores Telefonos = new frmTelefonosClientesProveedores();
                //if (mskRTN.Text.Any())
                // {
                InsertarClienteProveedor();
                DataRepository.Telefonos.Id = RTNG;
                Telefonos.ShowDialog();
                //  }
            }
            else
            {
                MessageBox.Show("Uno o más campos no se han agregado correctamente, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAgregarClienteProveedor_Load(object sender, EventArgs e)
        {

        }
        // Agregando los datos del cliente/proveedor a la base de datos
        private void btnAgregarClienteProveedor_Click(object sender, EventArgs e)
        {
            InsertarClienteProveedor();
            if (CPCRUD.SqlAgregar(CP))
            {
                MessageBox.Show("Se ha agregado exitosamente.", "Agregando cliente/proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RTNG = mskRTN.Text.ToString();
                MessageBox.Show("Por favor agrege los teléfonos del cliente/proveedor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTelefonosClientesProveedores Telefonos = new frmTelefonosClientesProveedores();
                DataRepository.Telefonos.Id = RTNG;
                Telefonos.ShowDialog();
                Limpiar();
            }
        }
        // Método que insertará los valores de los contenedores
        private void InsertarClienteProveedor()
        {
            if (ValidarTexto() == true)
            {
                DataRepository.Telefonos.Id = mskRTN.Text;

                CP.RTN = mskRTN.Text.ToString();
                CP.Nombres = txtNombresProveedor.Text.ToString();
                CP.Apellidos = txtApellidosClienteProveedor.Text.ToString();
                CP.CorreoElectronico = txtCorreoElectronico.Text.ToString();
                CP.Direccion = txtDireccionClienteProveedor.Text.ToString();
                if (cbTipoUsuario.Text == "Cliente")
                {
                    CP.TipoUsuarioCompraVenta = Convert.ToBoolean(0);
                }
                else if (cbTipoUsuario.Text == "Proveedor")
                {
                    CP.TipoUsuarioCompraVenta = Convert.ToBoolean(1);
                }
                else
                {
                    MessageBox.Show("El tipo de usuario especificado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epValidarTexto.SetError(cbTipoUsuario, "El tipo de usuario especificado no es válido");
                    cbTipoUsuario.Focus();
                }
                CP.EstadoClienteProveedor = Convert.ToBoolean(1);
                CP.FechaCreacion = DateTime.Now;
                CP.CreadoPor = 1;
                CP.FechaModificacion = DateTime.Now;
                CP.ModificadoPor = 1;
            }
            else
            {
                MessageBox.Show("Uno o más campos no se han agregado correctamente, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método que limpiará los contennedores
        public void Limpiar()
        {
            mskRTN.Clear();
            txtNombresProveedor.Clear();
            txtApellidosClienteProveedor.Clear();
            txtCorreoElectronico.Clear();
            txtDireccionClienteProveedor.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void cbTelefonosClientesProveedores_Click(object sender, EventArgs e)
        {
            //         cbTelefonosClientesProveedores.Items.Clear();
            Services.TelefonosCRUD Telefonos = new Services.TelefonosCRUD();
            Telefonos.ObtenerTelefonos(Telefonos.ObtenerIdClientesProveedor(DataRepository.Telefonos.Id));
            foreach (var item in DataRepository.Telefonos.Telefono)
            {
                //          cbTelefonosClientesProveedores.Items.Add(item);
            }
        }
        // Validar los que solo se puedan insertar letras
        private void txtNombresProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' != char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Validar los que solo se puedan insertar letras
        private void txtApellidosClienteProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' != char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Validar los que solo se puedan insertar números
        private void mskRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void lblTipoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void cbSucursal_Click(object sender, EventArgs e)
        {
    
        }
        // Método booleano que validara que los contenedores no se enuentren vacios o incompletos
        Boolean ValidarTexto()
        {
            if (mskRTN.Text.ToString() == "" || mskRTN.Text.Length != 14)
            {
                epValidarTexto.SetError(mskRTN, "Ingrese un RTN correcto para el cliente/proveedor");
                mskRTN.Focus();
                return false;
            }
            if (txtNombresProveedor.Text.ToString() == "")
            {
                epValidarTexto.SetError(txtNombresProveedor, "Ingrese uno o ambos nombres del cliente/proveedor");
                txtNombresProveedor.Focus();
                return false;
            }
            if (txtApellidosClienteProveedor.Text.ToString() == "")
            {
                epValidarTexto.SetError(txtApellidosClienteProveedor, "Ingrese uno o ambos apellidos del cliente/proveedor");
                txtApellidosClienteProveedor.Focus();
                return false;
            }
            if ((txtCorreoElectronico.Text.ToString() == "") && (email_bien_escrito(txtCorreoElectronico.Text.ToString()) == false))
            {
                epValidarTexto.SetError(txtCorreoElectronico, "Ingrese un correo electrónico válido del cliente/proveedor");
                txtCorreoElectronico.Focus();
                return false;
            }
            if (txtDireccionClienteProveedor.Text.ToString() == "")
            {
                epValidarTexto.SetError(txtDireccionClienteProveedor, "Ingrese la dirección actual del cliente/proveedor");
                txtDireccionClienteProveedor.Focus();
                return false;
            }
            if (cbTipoUsuario.Text.ToString() == "")
            {
                epValidarTexto.SetError(cbTipoUsuario, "Seleccione el tipo de usuario");
                cbTipoUsuario.Focus();
                return false;
            }
            //if (cbTelefonosClientesProveedores.Text.ToString() == "")
            //{
            //    epValidarTexto.SetError(cbTelefonosClientesProveedores, "Por favor agrege uno o más teléfonos al cliente/proveedor");
            //    cbTelefonosClientesProveedores.Focus();
            //    return false;
            //}
            else
            {
                return true;
            }
        }
        // El error provider desaparecerá luego de cumplir los requisitos
        private void mskRTN_Leave(object sender, EventArgs e)
        {
            if (mskRTN.Text.ToString() != "" && mskRTN.Text.Length == 14)
            {
                epValidarTexto.Clear();
            }
        }
        // El error provider desaparecerá luego de cumplir los requisitos
        private void txtNombresProveedor_Leave(object sender, EventArgs e)
        {
            if (txtNombresProveedor.Text.ToString() != "")
            {
                epValidarTexto.Clear();
            }
        }
        // El error provider desaparecerá luego de cumplir los requisitos
        private void txtApellidosClienteProveedor_Leave(object sender, EventArgs e)
        {
            if (txtApellidosClienteProveedor.Text.ToString() != "")
            {
                epValidarTexto.Clear();
            }
        }
        // El error provider desaparecerá luego de cumplir los requisitos
        private void txtCorreoElectronico_Leave(object sender, EventArgs e)
        {
            if ((txtCorreoElectronico.Text.ToString() != "") && (email_bien_escrito(txtCorreoElectronico.Text.ToString()) == true))
            {
                epValidarTexto.Clear();
            }
        }
        // El error provider desaparecerá luego de cumplir los requisitos
        private void txtDireccionClienteProveedor_Leave(object sender, EventArgs e)
        {
            if (txtDireccionClienteProveedor.Text.ToString() != "")
            {
                epValidarTexto.Clear();
            }
        }
        // El error provider desaparecerá luego de cumplir los requisitos
        private void cbTipoUsuario_Leave(object sender, EventArgs e)
        {
            if (cbTipoUsuario.Text.ToString() != "")
            {
                epValidarTexto.Clear();
            }
        }

        private void cbTelefonosClientesProveedores_Leave(object sender, EventArgs e)
        {
            //if (cbTelefonosClientesProveedores.Text.ToString() != "")
            //{
            //    epValidarTexto.Clear();
            //}
        }
        // Verificar que el email se encuentre bien escrito
        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void cbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
