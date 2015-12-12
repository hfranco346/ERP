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
    public partial class frmAgregarUsuario : Form
    {

        DataRepository.Usuarios U = new DataRepository.Usuarios();
        Services.OperacionesUsuarios OU = new Services.OperacionesUsuarios();

        public static string idSeguridad;
        public int id;
        public static bool estadoU;
        public static bool ingresar;
        public static string identidad;
        public static string identidadDesdeModificarEmpleado;
        public static bool Validacion= true;
        public frmAgregarUsuario()
        {
            InitializeComponent();
        }
        private void btnNuevoRol_Click(object sender, EventArgs e)
        {
            frmAgregarRol Nuevofrm = new frmAgregarRol();
            Nuevofrm.ShowDialog();
        }

        private void chkMostrarCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarCaracteres.Checked)
            {
                txtnueva2.Visible = true;
                txtconfirmar2.Visible = true;
            }
            else
            {
                txtnueva2.Visible = false;
                txtconfirmar2.Visible = false;
            }        
        }

        private void txtNueva_TextChanged(object sender, EventArgs e)
        {
            txtnueva2.Text = txtNueva.Text;
        }

        private void txtconfirmar_TextChanged(object sender, EventArgs e)
        {
            txtconfirmar2.Text = txtconfirmar.Text;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
  
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ingresar == true)
                {
                    if (txtAlias.Text.Any())
                    {
                        U.Alias = txtAlias.Text.ToString();
                        if (txtNueva.Text.Any())
                        {
                            if (txtconfirmar.Text.Any())
                            {
                                if(txtNueva.Text.ToString() == txtconfirmar.Text.ToString())
                                {
                                    U.Clave = txtconfirmar.Text.ToString();
                                    U.Estado = true;
                                    if(cbRoles.Text.Any())
                                    {
                                        
                                        U.IdSeguridad = int.Parse(idSeguridad);
                                        OU.InsertarUsuarioAEmpleado(U);
                                        MessageBox.Show("Se ha agregado exitosamente el usuario");
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el usuario!");
                                        cbRoles.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Las contraseñas no coinciden");
                                    txtNueva.Clear();
                                    txtconfirmar.Clear();
                                    txtNueva.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el usuario!");
                                txtconfirmar.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el usuario!");
                            txtNueva.Focus();
                        } 
                    }
                    else
                    {
                        MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el usuario!");
                        txtAlias.Focus();
                    } 
                } 
                else
                {
                   if (txtAlias.Text.Any())
                    {
                        U.Alias = txtAlias.Text.ToString();
                        if (txtNueva.Text.Any())
                        {
                            if (txtconfirmar.Text.Any())
                            {
                                if(txtNueva.Text.ToString() == txtconfirmar.Text.ToString())
                                {
                                    U.Clave = txtconfirmar.Text.ToString();
                                    U.Estado = true;
                                    if(cbRoles.Text.Any())
                                    {
                                        U.IdSeguridad = int.Parse(idSeguridad);
                                        OU.SqlInsert(U);
                                        MessageBox.Show("Se ha agregado exitosamente el usuario");
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el usuario!");
                                        cbRoles.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Las contraseñas no coinciden");
                                    txtNueva.Clear();
                                    txtconfirmar.Clear();
                                    txtNueva.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el usuario!");
                                txtconfirmar.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el usuario!");
                            txtNueva.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el usuario!");
                        txtAlias.Focus();
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el usuario!");
            }
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbRoles.SelectedIndex >= 0)
                {
                    List<DataRepository.PropiedadesRol> miLista = new List<DataRepository.PropiedadesRol>();
                    idSeguridad = cbRoles.SelectedValue.ToString();
                }
            }
            catch (FormatException ex)
            {
            }
        }
        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            if (ingresar == true)
            {
                mskIdentidad.Enabled = false;
            }
            mskIdentidad.Text = identidad;
            if (UserInterface.Usuarios.frmBuscarEmpleadosSinUsuario.mostrarUsuario2 == true)
            {
                mskIdentidad.Text = UserInterface.Usuarios.frmBuscarEmpleadosSinUsuario.identidad;
                mskIdentidad.Enabled = false;
                Validacion = false;
                ingresar = true;
            }
            if (frmModificarEmpleado.ingresar == true && Validacion == true && identidadDesdeModificarEmpleado != null)
            {
                mskIdentidad.Text = identidadDesdeModificarEmpleado;
                mskIdentidad.Enabled = false;
            }
        }
        public void RecibirIdentidad(string id)
        {
            identidadDesdeModificarEmpleado = id;
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
        public void RecibirValoesAgregarEmpleado(string id, bool e)
        {
            identidad = id;
            estadoU = e;
        }

        private void gbDatosUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}
