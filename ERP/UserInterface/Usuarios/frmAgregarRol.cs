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
    public partial class frmAgregarRol : Form
    {
        public frmAgregarRol()
        {
            InitializeComponent();
        }
        public bool selecion = true;
        private void frmAgregarRol_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' != char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Any() && txtDescripcion.Text.Any() && lstpermisos.Items.Count > 0)
            {
                DataRepository.PropiedadesRol PR = new DataRepository.PropiedadesRol();
                Services.OperacionesRoles OR = new Services.OperacionesRoles();

                PR.Rol = txtNombre.Text.ToString();
                PR.Descripcion = txtDescripcion.Text.ToString();
                OR.InsertarRol(PR);
                int id;
                id = OR.ObtenerIdRol(txtNombre.Text.ToString());
                foreach (var item in lstpermisos.Items)
                {
                    OR.AgregarPermisos(id, item.ToString());  
                }
                chkselecionar.Text = "Seleccionar todo";
                txtNombre.Clear();
                txtDescripcion.Clear();
                chkselecionar.Checked = false;
                lstpermisos.Items.Clear();
                selecionarFalse();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debe de ingresar datos para poder guardar.");
                txtNombre.Focus();
            }
            
              

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregarpermisos_Click(object sender, EventArgs e)
        {
           
        }

        private void chkinventario_Click(object sender, EventArgs e)
        {
       
        }

        private void chkventas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkventas.Checked)
            {
                lstpermisos.Items.Add(chkventas.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chkventas.Text);
            }
        }

        private void chkcargos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcargos.Checked)
            {
                lstpermisos.Items.Add(chkcargos.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chkcargos.Text);
            }
        }

        private void chkclientesProveedores_CheckedChanged(object sender, EventArgs e)
        {
            if (chkclientesProveedores.Checked)
            {
                lstpermisos.Items.Add(chkclientesProveedores.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chkclientesProveedores.Text);
            }
        }

        private void chkcompras_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcompras.Checked)
            {
                lstpermisos.Items.Add(chkcompras.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chkcompras.Text);
            }
        }

        private void chkempleados_CheckedChanged(object sender, EventArgs e)
        {

            if (chkempleados.Checked)
            {
                lstpermisos.Items.Add(chkempleados.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chkempleados.Text);
            }
        }

        private void chkimpuestos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkimpuestos.Checked)
            {
                lstpermisos.Items.Add(chkimpuestos.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chkimpuestos.Text);
            }
        }

        private void chkinventario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkinventario.Checked)
            {
                lstpermisos.Items.Add(chkinventario.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chkinventario.Text);
            }
        }

        private void chkroles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkroles.Checked)
            {
                lstpermisos.Items.Add(chkroles.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chkroles.Text);
            }
        }

        private void chksucursales_CheckedChanged(object sender, EventArgs e)
        {

            if (chksucursales.Checked)
            {
                lstpermisos.Items.Add(chksucursales.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chksucursales.Text);
            }
        }

        private void chkusuario_CheckedChanged(object sender, EventArgs e)
        {

            if (chkusuario.Checked)
            {
                lstpermisos.Items.Add(chkusuario.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chkusuario.Text);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            chkselecionar.Text = "Seleccionar todo";
            chkselecionar.Checked = false;
            lstpermisos.Items.Clear();
            selecionarFalse();
        }

        private void selecionarTrue()
        {
            chkventas.Checked = true;
            chkusuario.Checked = true;
            chkcargos.Checked = true;
            chkclientesProveedores.Checked = true;
            chkcompras.Checked = true;
            chkempleados.Checked = true;
            chkimpuestos.Checked = true;
            chkinventario.Checked = true;
            chkroles.Checked = true;
            chksucursales.Checked = true;
            chkDevoluciones.Checked = true;
            chklistar.Checked = true;
        }

        private void selecionarFalse()
        {
            chkventas.Checked = false;
            chkusuario.Checked = false;
            chkcargos.Checked = false;
            chkclientesProveedores.Checked = false;
            chkcompras.Checked = false;
            chkempleados.Checked = false;
            chkimpuestos.Checked = false;
            chkinventario.Checked = false;
            chkroles.Checked = false;
            chksucursales.Checked = false;
            chkDevoluciones.Checked = false;
            chklistar.Checked = false;
        }

        private void chkselecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (selecion)
            {
                selecionarTrue();
                chkselecionar.Text = "Deseleccionar todo";
                selecion = false;
            }
            else
            {
                chkselecionar.Text = "Seleccionar todo";
                selecionarFalse();
                selecion = true;
            }
        }

        private void chkDevoluciones_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDevoluciones.Checked)
            {
                lstpermisos.Items.Add(chkDevoluciones.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chkDevoluciones.Text);
            }
        }

        private void chklistar_CheckedChanged(object sender, EventArgs e)
        {
            if (chklistar.Checked)
            {
                lstpermisos.Items.Add(chklistar.Text);
            }
            else
            {
                lstpermisos.Items.Remove(chklistar.Text);
            }
        }

    }
}
