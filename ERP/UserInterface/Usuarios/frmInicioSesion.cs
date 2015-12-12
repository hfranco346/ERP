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
    public partial class frmInicioSesion : Form
    {
        Services.OperacionesInicioSesion IS = new Services.OperacionesInicioSesion();
        public static string alias;
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Any())
            {
                if (txtContraseña.Text.Any())
                {
                    alias = txtUsuario.Text.ToString();
                    IS.ConsultarAlias();
                    if (Services.OperacionesInicioSesion.estado)
                    {
                        if (txtUsuario.Text == Services.OperacionesInicioSesion.alias.Trim() && txtContraseña.Text == Services.OperacionesInicioSesion.clave.Trim())
                        {
                            this.Hide();

                            
                        }
                        else
                        {
                            MessageBox.Show("El usuario o contraseña no son correctos!");
                            txtUsuario.Clear();
                            txtContraseña.Clear();
                            txtUsuario.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este usuario esta deshabilitado, por favor consulte al administrador");
                        txtUsuario.Clear();
                        txtContraseña.Clear();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe escribir la contraseña para iniciar sesión");
                    txtContraseña.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Debe escribir el usuario para iniciar sesión");
                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
    
        }

        private void lblLinea_Click(object sender, EventArgs e)
        {

        }
    }
}
