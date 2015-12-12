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
    public partial class frmModificarUsuario : Form
    {
        Services.OperacionesUsuarios OU = new Services.OperacionesUsuarios();
        public static int idUsuario;
        public static int idSeguridad;
        public static int idEmpleado;
        public static bool estado;
        public static string alias;
        public string idRol;
        public static string identidadDesdeModificarEmpleado;

        public frmModificarUsuario()
        {
            InitializeComponent();
        }


        private void chkMostrarCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarCaracteres.Checked)
            {
                txtAcutal2.Visible = true;
                txtnueva2.Visible = true;
                txtconfirmar2.Visible = true;
            }
            else
            {
                txtAcutal2.Visible = false;
                txtnueva2.Visible = false;
                txtconfirmar2.Visible = false;
            }
        }

        private void txtActual1_TextChanged(object sender, EventArgs e)
        {
            txtAcutal2.Text = txtActual1.Text;
        }

        private void txtNueva_TextChanged(object sender, EventArgs e)
        {
            txtnueva2.Text = txtNueva.Text;
        }

        private void txtconfirmar_TextChanged(object sender, EventArgs e)
        {
            txtconfirmar2.Text = txtconfirmar.Text;
        }

        private void txtnueva2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            frmModificarRol Nuevofrm = new frmModificarRol();
            Nuevofrm.DeshabilitarCbRoles(Services.OperacionesUsuarios.rol);
            Nuevofrm.ShowDialog();
            
        }
        public void RecibirValorIdentidad(string identidadM)
        {
            identidadDesdeModificarEmpleado = identidadM;
        }

        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
            if (frmModificarEmpleado.ingresar == false)
            {
                mskIdentidad.Text = identidadDesdeModificarEmpleado;
                txtAlias.Text = Services.OperacionesUsuarios.aliasModificarUsuario.Trim();
                PopularRoles();
                cbRoles.GetItemText(Services.OperacionesUsuarios.rolModificarUsuario.Trim());
                cbRoles.Text = Services.OperacionesUsuarios.rolModificarUsuario.Trim();
            }
            else
            {
                mskIdentidad.Text = Services.OperacionesUsuarios.idEmpleado;
                txtAlias.Text = alias.Trim();
                PopularRoles();
                cbRoles.GetItemText(Services.OperacionesUsuarios.rol.Trim());

                cbRoles.Text = Services.OperacionesUsuarios.rol.Trim();
            }
        }

        public bool RecibirValores(int id1, int id2, int id3, bool estado1, string alias1)
        {
            idUsuario = id1;
            idSeguridad = id2;
            idEmpleado = id3;
            estado = estado1;
            alias = alias1;
            return true;
        }

        private void txtAlias_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRoles_Click(object sender, EventArgs e)
        {
            PopularRoles();
        }

        private void PopularRoles()
        {
            ComboBox cbP = new ComboBox();
            Services.OperacionesRoles OR = new Services.OperacionesRoles();
            DataRepository.PropiedadesRol PR = new DataRepository.PropiedadesRol();
            cbRoles.DataSource = OR.ConsultarRoles();
            cbRoles.DisplayMember = "Rol";
            cbRoles.ValueMember = "IdSeguridad";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Services.OperacionesUsuarios OU = new Services.OperacionesUsuarios();
            DataRepository.Usuarios U = new DataRepository.Usuarios();

            if(frmModificarEmpleado.ingresar == false)
            {
                U.Alias = txtAlias.Text;

                if (Services.OperacionesUsuarios.claveModificarUsuario.Trim() == txtActual1.Text)
                {
                    if (txtNueva.Text == txtconfirmar.Text)
                    {
                        U.Clave = txtconfirmar.Text;
                        idRol = cbRoles.SelectedValue.ToString();
                        U.IdSeguridad = int.Parse(idRol);
                        OU.SqlUpdate(U, Services.OperacionesUsuarios.idUsuarioAModificar);
                        MessageBox.Show("El usuario ha sido actualizado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("La nueva contraseña no coincide");
                        txtActual1.Clear();
                        txtNueva.Clear();
                        txtconfirmar.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    txtActual1.Clear();
                    txtNueva.Clear();
                    txtconfirmar.Clear();
                }
            }
            else
            {
                U.Alias = txtAlias.Text;

                if (Services.OperacionesUsuarios.clave.Trim() == txtActual1.Text)
                {
                    if (txtNueva.Text == txtconfirmar.Text)
                    {
                        U.Clave = txtconfirmar.Text;
                        idRol = cbRoles.SelectedValue.ToString();
                        U.IdSeguridad = int.Parse(idRol);
                        OU.SqlUpdate(U, frmConsultarUsuariosyModificarlos.idUsuario);
                        MessageBox.Show("El usuario ha sido actualizado exitosamente");

                    }
                    else
                    {
                        MessageBox.Show("La nueva contraseña no coincide");
                        txtActual1.Clear();
                        txtNueva.Clear();
                        txtconfirmar.Clear();

                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    txtActual1.Clear();
                    txtNueva.Clear();
                    txtconfirmar.Clear();
                }
            }
        }
    }
}
