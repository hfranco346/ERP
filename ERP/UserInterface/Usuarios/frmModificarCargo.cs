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
    public partial class frmModificarCargo : Form
    {
        DataRepository.PropiedadesCargos PC = new DataRepository.PropiedadesCargos();
        Services.OperacionesCargos OC = new Services.OperacionesCargos();
        public static string NombreCargo;
        public frmModificarCargo()
        {
            InitializeComponent();
        }

        private void frmModificarCargo_Load(object sender, EventArgs e)
        {
            CargarCargos();
        }

        public void CargarCargos()
        {
            foreach (var item in OC.ConsultarCargos())
            {
                lstCargos.Items.Add(item);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = lstCargos.SelectedItem.ToString();
            NombreCargo = lstCargos.SelectedItem.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Any())
                {
                    if (txtNombre.Text != lstCargos.SelectedItem.ToString())
                    {
                        OC.ConsultarIdCargo();
                        PC.Nombre_Puesto = txtNombre.Text;
                        OC.ModificarCargos(PC, Services.OperacionesCargos.IdCargo);
                        MessageBox.Show("El nombre se ha actualizado exitosamente.");
                        lstCargos.Items.Clear();
                        CargarCargos();
                    }
                    else
                    {
                        MessageBox.Show("No se puede actualizar ya que no ha realizado cambios.");
                        txtNombre.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cargo primero para modificar");
                    txtNombre.Clear();
                    lstCargos.Focus();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Debe seleccionar un cargo primero para modificar");
                txtNombre.Clear();
                lstCargos.Focus();
            }
        }

        private void gbActualizarCargos_Enter(object sender, EventArgs e)
        {

        }
    }
}
