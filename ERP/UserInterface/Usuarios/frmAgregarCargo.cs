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
    public partial class frmAgregarCargo : Form
    {
        DataRepository.PropiedadesCargos PC = new DataRepository.PropiedadesCargos();
        Services.OperacionesCargos OC = new Services.OperacionesCargos();
        public frmAgregarCargo()
        {
            InitializeComponent();
        }

        private void frmAgregarCargo_Load(object sender, EventArgs e)
        {
            CargarCargos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Any())
            {
                PC.Nombre_Puesto = txtNombre.Text;
                OC.InsertarCargo(PC);
                txtNombre.Clear();
                lstCargosExistentes.Items.Clear();
                CargarCargos();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del cargo para poder agregarlo.");
                txtNombre.Focus();
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarCargos()
        {
            foreach (var item in OC.ConsultarCargos())
            {
                lstCargosExistentes.Items.Add(item);
            }
        }

        private void gbCargos_Enter(object sender, EventArgs e)
        {

        }

        private void lstCargosExistentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
