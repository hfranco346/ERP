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
    public partial class frmModificarRol : Form
    {
        public frmModificarRol()
        {
            InitializeComponent();
        }

        public string idSeguridad;
        public int id;
        public bool selecion = true; 
        private void btnCerrar_Click(object sender, EventArgs e)
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
        private void chkDevoluciones_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDevoluciones.Checked && lstpermisos.Items.Contains(chkDevoluciones.Text) == false)
            {
                lstpermisos.Items.Add(chkDevoluciones.Text);
            }
            else
            {
                if (chkDevoluciones.Checked == false)
                lstpermisos.Items.Remove(chkDevoluciones.Text);
            }
        }

        private void chklistar_CheckedChanged(object sender, EventArgs e)
        {
            if (chklistar.Checked && lstpermisos.Items.Contains(chklistar.Text) == false)
            {
                lstpermisos.Items.Add(chklistar.Text);
            }
            else
            {
                if (chklistar.Checked == false)
                lstpermisos.Items.Remove(chklistar.Text);
            }
        }
        private void frmModificarRol_Load(object sender, EventArgs e)
        {
            ExtraerPropiedadesRoles();
        }

        private void gbRoles1_Enter(object sender, EventArgs e)
        {

        }
        public void DeshabilitarCbRoles(string nombreRol)
        {
            PopularRol();
            cbRoles.GetItemText(nombreRol);
            cbRoles.Text = Services.OperacionesUsuarios.rol.Trim();
            cbRoles.Enabled = false;
        }
        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkselecionar.Text = "Seleccionar todo";
            chkselecionar.Checked = false;
            selecionarFalse();
            selecion = true;
            lstpermisos.Items.Clear();
            ExtraerPropiedadesRoles();
        }

        public void SelecionarCheck()
        {

            Services.OperacionesRoles m = new Services.OperacionesRoles ();
            
  
            if (lstpermisos.Items.Count > 0)
            {
                    foreach (var item2 in m.PopularLista(int.Parse(cbRoles.SelectedValue.ToString())))
                    {
              
                    if (item2.ToString() == chkcargos.Text)
                    {
                        chkcargos.Checked = true;
                    }
                    if (item2.ToString() == chkclientesProveedores.Text)
                    {
                        chkclientesProveedores.Checked = true;
                    }
                    if (item2.ToString() == chkcompras.Text)
                    {
                        chkcompras.Checked = true;
                    }
                    if (item2.ToString() == chkempleados.Text)
                    {
                        chkempleados.Checked = true;
                    }
                    if (item2.ToString() == chkimpuestos.Text)
                    {
                        chkimpuestos.Checked = true;
                    }
                    if (item2.ToString() == chkinventario.Text)
                    {
                        chkinventario.Checked = true;
                    }
                    if (item2.ToString() == chkroles.Text)
                    {
                        chkroles.Checked = true;
                    }
                    if (item2.ToString() == chksucursales.Text)
                    {
                        chksucursales.Checked = true;
                    }
                    if (item2.ToString() == chkusuario.Text)
                    {
                        chkusuario.Checked = true;
                    }
                    if (item2.ToString() == chkventas.Text)
                    {
                        chkventas.Checked = true;
                    }
                    if (item2.ToString() == chkDevoluciones.Text)
                    {
                        chkDevoluciones.Checked = true;
                    }
                    if (item2.ToString() == chklistar.Text)
                    {
                        chklistar.Checked = true;
                    }
                }
            }
        }
        private void ExtraerPropiedadesRoles()
        {
            Services.OperacionesRoles OR = new Services.OperacionesRoles();
            try
            { 
             
                if (cbRoles.SelectedIndex >= 0)
                {
                    List<DataRepository.PropiedadesRol> miLista = new List<DataRepository.PropiedadesRol>();
                    idSeguridad = cbRoles.SelectedValue.ToString();
                    foreach (var item in OR.PopularLista(int.Parse(idSeguridad)))
                    {
                        lstpermisos.Items.Add(item);   
                    }
                    SelecionarCheck();
                    miLista = OR.ConsultarRol(int.Parse(idSeguridad));
                    txtNombre.Text = miLista[0].Rol;
                    txtDescripcion.Text = miLista[1].Descripcion;
                }
                else
                {
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                }
            }
            catch (FormatException ex)
            {
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Any() && txtDescripcion.Text.Any() && lstpermisos.Items.Count > 0)
            {
                id = int.Parse(idSeguridad);
                DataRepository.PropiedadesRol PR = new DataRepository.PropiedadesRol();
                Services.OperacionesRoles OR = new Services.OperacionesRoles();
                PR.Rol = txtNombre.Text.ToString();
                PR.Descripcion = txtDescripcion.Text.ToString();
                OR.ModificarRol(PR, id);
                int id2;
                id2 = OR.ObtenerIdRol(txtNombre.Text.ToString());

                foreach (var item in OR.PopularLista(id2))
                {
                    OR.QuitarPermisos(id2, item.ToString());
                }
                foreach (var item in lstpermisos.Items)
                {
                    OR.AgregarPermisos(id2, item.ToString());
                }
                MessageBox.Show("Se ha actualizado exitosamente el rol.");
                chkselecionar.Text = "Seleccionar todo";
                cbRoles.DataSource = new List<string>();
                txtNombre.Clear();
                txtDescripcion.Clear();
                chkselecionar.Checked = false;
                lstpermisos.Items.Clear();
                selecionarFalse();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debe de ingresar datos para poder modificar.");
                txtNombre.Focus();
            }
            
        }

        private void cbRoles_Click(object sender, EventArgs e)
        {
            PopularRol();
        }

        private void PopularRol()
        {
            ComboBox cbP = new ComboBox();
            Services.OperacionesRoles OR = new Services.OperacionesRoles();
            DataRepository.PropiedadesRol PR = new DataRepository.PropiedadesRol();
            cbRoles.DataSource = OR.ConsultarRoles();
            cbRoles.DisplayMember = "Rol";
            cbRoles.ValueMember = "IdSeguridad";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkventas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkventas.Checked && lstpermisos.Items.Contains(chkventas.Text)==false)
            {
                lstpermisos.Items.Add(chkventas.Text);
            }
            else
            {
                if(chkventas.Checked==false)
                lstpermisos.Items.Remove(chkventas.Text);
            }
        }

        private void chkcargos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcargos.Checked && lstpermisos.Items.Contains(chkcargos.Text) == false)
            {
                lstpermisos.Items.Add(chkcargos.Text);
            }
            else
            {
                if (chkcargos.Checked == false)
                lstpermisos.Items.Remove(chkcargos.Text);
            }
        }

        private void chkclientesProveedores_CheckedChanged(object sender, EventArgs e)
        {
            if (chkclientesProveedores.Checked && lstpermisos.Items.Contains(chkclientesProveedores.Text) == false)
            {
                lstpermisos.Items.Add(chkclientesProveedores.Text);
            }
            else
            {
                if (chkclientesProveedores.Checked==false)
                lstpermisos.Items.Remove(chkclientesProveedores.Text);
            }
        }

        private void chkcompras_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcompras.Checked && lstpermisos.Items.Contains(chkcompras.Text) == false)
            {
                lstpermisos.Items.Add(chkcompras.Text);
            }
            else
            {
                if(chkcompras.Checked==false)
                lstpermisos.Items.Remove(chkcompras.Text);
            }
        }

        private void chkempleados_CheckedChanged(object sender, EventArgs e)
        {

            if (chkempleados.Checked && lstpermisos.Items.Contains(chkempleados.Text) == false)
            {
                lstpermisos.Items.Add(chkempleados.Text);
            }
            else
            {
                if(chkempleados.Checked==false)
                lstpermisos.Items.Remove(chkempleados.Text);
            }
        }

        private void chkimpuestos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkimpuestos.Checked && lstpermisos.Items.Contains(chkimpuestos.Text) == false)
            {
                lstpermisos.Items.Add(chkimpuestos.Text);
            }
            else
            {
                if(chkimpuestos.Checked==false) 
                lstpermisos.Items.Remove(chkimpuestos.Text);
            }
        }

        private void chkinventario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkinventario.Checked && lstpermisos.Items.Contains(chkinventario.Text) == false)
            {
                lstpermisos.Items.Add(chkinventario.Text);
            }
            else
            {
                if(chkinventario.Checked==false)
                lstpermisos.Items.Remove(chkinventario.Text);
            }
        }

        private void chkroles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkroles.Checked && lstpermisos.Items.Contains(chkroles.Text) == false)
            {
                lstpermisos.Items.Add(chkroles.Text);
            }
            else
            {
                if(chkroles.Checked==false)
                lstpermisos.Items.Remove(chkroles.Text);
            }
        }

        private void chksucursales_CheckedChanged(object sender, EventArgs e)
        {

            if (chksucursales.Checked && lstpermisos.Items.Contains(chksucursales.Text) == false)
            {
                lstpermisos.Items.Add(chksucursales.Text);
            }
            else
            {
                if(chksucursales.Checked==false) 
                lstpermisos.Items.Remove(chksucursales.Text);
            }
        }

        private void chkusuario_CheckedChanged(object sender, EventArgs e)
        {

            if (chkusuario.Checked && lstpermisos.Items.Contains(chkusuario.Text) == false)
            {
                lstpermisos.Items.Add(chkusuario.Text);
            }
            else
            {
                if(chkusuario.Checked==false)
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

        private void chkinventario_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void chkinventario_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            chkselecionar.Text = "Seleccionar todo";
            chkselecionar.Checked = false;
            lstpermisos.Items.Clear();
            selecionarFalse();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

    }
}
