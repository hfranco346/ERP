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
    public partial class frmTelefonos : Form
    {
        public frmTelefonos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (lstFijos.Items.Count > 0 && lstMovil.Items.Count > 0)
            {
                this.Close();
            }
                
            else
            {
                MessageBox.Show("Es obligatorio ingresar los números de teléfonos");
                mskFijo.Focus();
            }
                
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Services.OperacionesTelefonos telefonos = new Services.OperacionesTelefonos();
            if (mskFijo.Text != "    -" && mskMovil.Text != "    -")
            {
                telefonos.AgregarNumeros(false, Services.OperacionesEmpleado.idEmpleadoTelefono, mskFijo.Text.ToString(), mskMovil.Text.ToString(), 0);
                PopularListar();
                mskFijo.Clear();
                mskMovil.Clear();
                MessageBox.Show("Se han agregado exitosamente los números telefónicos");
            }
            else
            {
                MessageBox.Show("Es obligatorio ingresar los números de teléfonos");
                mskFijo.Focus();
            }
            
        }

        private void frmTelefonos_Load(object sender, EventArgs e)
        {
            PopularListar();
        }

        private void frmTelefonos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
