using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.UserInterface.Usuarios
{
    
    public partial class frmModificarTelefono : Form
    {
        public static string Idempleado;
        public frmModificarTelefono()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Services.OperacionesTelefonos Nuevofrm = new Services.OperacionesTelefonos();

            if ((lstFijos.SelectedIndex > -1 && mskFijo.Text != "    -") || (lstMovil.SelectedIndex > -1 && mskMovil.Text != "    -"))
            {

             if (mskFijo.Text.Length < 9 && mskMovil.Text.Length<9 || mskMovil.Text.Length < 9 && mskFijo.Text.Length<9)
            {
                MessageBox.Show("El teléfono no se pudo actulizar debido a que esta incompleto.");
                mskFijo.Clear();
            } 

            if (mskFijo.Text != "    -" && mskFijo.Text.Length==9)
            {
                if (mskFijo.Text != lstFijos.SelectedItem.ToString())
                {
                    Nuevofrm.ActulizarTelefono(Nuevofrm.ObtenerIdtelefono(Services.OperacionesEmpleado.idEmpleadoTelefono, lstFijos.SelectedItem.ToString(), "NumeroFijo"), "NumeroFijo", mskFijo.Text);
                }
            }
            if (mskMovil.Text != "    -" && mskMovil.Text.Length == 9)
            {
                if (mskFijo.Text != lstFijos.SelectedItem)
                {
                    Nuevofrm.ActulizarTelefono(Nuevofrm.ObtenerIdtelefono(Services.OperacionesEmpleado.idEmpleadoTelefono, lstMovil.SelectedItem.ToString(), "NumeroMovil"), "NumeroMovil", mskMovil.Text);
                }
            }

            if (lstFijos.SelectedIndex > -1 || lstMovil.SelectedIndex > -1)
            {
                if(lstFijos.SelectedIndex > -1)
                {
                    if (mskFijo.Text == lstFijos.SelectedItem.ToString())
                    {
                        MessageBox.Show("No es necesario actualizar ya que no ha hecho cambios.");
                    }
                }
                if (lstMovil.SelectedIndex > -1 && lstFijos.SelectedIndex == -1)
                {
                    if (mskMovil.Text == lstMovil.SelectedItem.ToString())
                    {
                        MessageBox.Show("No es necesario actualizar ya que no ha hecho cambios.");
                    }
                }
                
            }
        }
            else
            {
                MessageBox.Show("Por favor seleccione el teléfono que desea modificar y luego ingrese el nuevo teléfono.");
            }

            if (Services.OperacionesTelefonos.validacionTelefonos == false)
            {
                if ((lstFijos.SelectedIndex > -1 && mskFijo.Text != "    -" && mskFijo.Text.Length == 9 && lstFijos.SelectedItem.ToString() != mskFijo.Text) || (lstMovil.SelectedIndex > -1 && mskMovil.Text != "    -" && mskMovil.Text.Length == 9 && lstMovil.SelectedItem.ToString() != mskMovil.Text))
                {
                    MessageBox.Show("Sus teléfonos se actualizaron correctamente.");
                }
            }
            

            lstFijos.Items.Clear();
            lstMovil.Items.Clear();
            mskFijo.Clear();
            mskMovil.Clear();
            Nuevofrm.ObtenerTelefonos(Services.OperacionesEmpleado.idEmpleadoTelefono);
            PopularListar();
        }
        public void Mimetodo(string id) 
        {
            Idempleado = id;
        }
        private void frmModificarTelefono_Load(object sender, EventArgs e)
        {
            Services.OperacionesTelefonos Nuevofrm = new Services.OperacionesTelefonos();
            Services.OperacionesEmpleado mi = new Services.OperacionesEmpleado();
            mi.ConsultarId(Idempleado);
            Nuevofrm.ObtenerTelefonos(Services.OperacionesEmpleado.idEmpleadoTelefono);

            PopularListar();
        }

        public void PopularListar()
        {
            Services.OperacionesTelefonos telefonos = new Services.OperacionesTelefonos();
            telefonos.ObtenerTelefonos(Services.OperacionesEmpleado.idEmpleadoTelefono);

            foreach (var item in telefonos.Nuevofrm.TelefonosFijos)
            {
                lstFijos.Items.Add(item);
            }
            foreach (var item in telefonos.Nuevofrm.TelefonosMoviles)
            {
                lstMovil.Items.Add(item);
            }
        }

        private void lstFijos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstFijos.SelectedItem!=null)
            mskFijo.Text = lstFijos.SelectedItem.ToString();
        }

        private void lstMovil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMovil.SelectedItem != null)
            mskMovil.Text = lstMovil.SelectedItem.ToString();
        }

        private void mskMovil_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gbNumeroTelefonos_Enter(object sender, EventArgs e)
        {

        }
    }
}
