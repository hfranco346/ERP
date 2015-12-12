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
    public partial class frmModificarEmpleado : Form
    {
        public int idCargo;
        public static bool ingresar = true;
        public bool mostrarMensaje= false;
        public frmModificarEmpleado()
        {
            InitializeComponent();
        }

        private void chkSi_Click(object sender, EventArgs e)
        {
            chkNo.Checked = false;
            chkSi.Checked = true;
            btnActualizar.Text = "Siguiente";
        }

        private void chkNo_Click(object sender, EventArgs e)
        {
            chkSi.Checked = false;
            chkNo.Checked = true;
            btnActualizar.Text = "Guardar";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarTelefonos_Click(object sender, EventArgs e)
        {
            frmModificarTelefono Nuevofrm =new frmModificarTelefono();
            Nuevofrm.Mimetodo(mskIdentidad.Text);
            Nuevofrm.ShowDialog();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' != char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' != char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PopulaCargos()
        {
            ComboBox cbP = new ComboBox();
            Services.OperacionesEmpleado OE = new Services.OperacionesEmpleado();
            DataRepository.PropiedadesCargosEmpleado PCE = new DataRepository.PropiedadesCargosEmpleado();
            cbCargo.DataSource = OE.ConsultarCargos();
            cbCargo.DisplayMember = "Nombre_Puesto";
            cbCargo.ValueMember = "Id_PuestoEmpleado";
        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {
            Services.OperacionesEmpleado OE = new Services.OperacionesEmpleado();
            mskIdentidad.Text = frmBuscarEmpleado.identidad;
            txtNombre.Text = frmBuscarEmpleado.nombres;
            txtApellido.Text = frmBuscarEmpleado.apellidos;
            txtDireccion.Text = frmBuscarEmpleado.direccion;
            if (frmBuscarEmpleado.genero == true)
            {
                cbGenero.Text = "Masculino";
            }
            else
                cbGenero.Text = "Femenino";
            if (frmBuscarEmpleado.estadoCivil == true)
            {
                cbEstadocivil.Text = "Casado(a)";
            }
            else
                cbEstadocivil.Text = "Soltero(a)";
            PopulaCargos();
            cbCargo.GetItemText(Services.OperacionesEmpleado.cargo.Trim());
            cbCargo.Text = Services.OperacionesEmpleado.cargo.Trim();
            OE.ConsultarSiTieneUsuario(frmBuscarEmpleado.identidad);
            if (Services.OperacionesEmpleado.comprobarIdEmpleado == 0)
            {
                lblDeseaActualizarUsuarioAEmpleado.Text = "¿Desea ingresar un usuario a este empleado?";
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRepository.PropiedadesEmpleado PE = new DataRepository.PropiedadesEmpleado();
                Services.OperacionesEmpleado OE = new Services.OperacionesEmpleado();
                if(mskIdentidad.Text.Any())
                {
                    PE.Identidad = mskIdentidad.Text;
                    if(txtNombre.Text.Any())
                    {
                        PE.Nombres = txtNombre.Text;
                        if(txtApellido.Text.Any())
                        {
                            PE.Apellidos = txtApellido.Text;
                            if(txtDireccion.Text.Any())
                            {
                                PE.Direccion = txtDireccion.Text;
                                if(cbGenero.Text.Any())
                                {
                                    if (cbGenero.Text == "Masculino")
                                    {
                                        PE.Genero = true;
                                    }
                                    else
                                    {
                                        PE.Genero = false;
                                    }
                                    if(cbCargo.Text.Any())
                                    {
                                        idCargo = int.Parse(cbCargo.SelectedValue.ToString());
                                        PE.Id_PuestoEmpleado = idCargo;
                                        if(cbEstadocivil.Text.Any())
                                        {
                                            if (cbEstadocivil.Text == "Soltero(a)")
                                            {
                                                PE.EstadoCivil = false;
                                            }
                                            else
                                            {
                                                PE.EstadoCivil = true;
                                            }

                                            if (chkSi.Checked)
                                            {
                                                if (lblDeseaActualizarUsuarioAEmpleado.Text == "¿Desea ingresar un usuario a este empleado?")
                                                {
                                                    Services.OperacionesUsuarios OU = new Services.OperacionesUsuarios();
                                                    this.Hide();
                                                    mostrarMensaje = true;
                                                    MessageBox.Show("Se ha actualizado exitosamente el empleado");
                                                    OU.ConsultarIdEmpleadoParaModificar(PE.Identidad);
                                                    frmAgregarUsuario Nuevofrm = new frmAgregarUsuario();
                                                    Nuevofrm.RecibirIdentidad(PE.Identidad);
                                                    ingresar = true;
                                                    Nuevofrm.ShowDialog();
                                                }
                                                else
                                                {
                                                    Services.OperacionesUsuarios OU = new Services.OperacionesUsuarios();
                                                    this.Hide();
                                                    OU.ConsultarUsuarioCompleto(PE.Identidad);
                                                    MessageBox.Show("Se ha actualizado exitosamente el empleado");
                                                    frmModificarUsuario Nuevofrm = new frmModificarUsuario();
                                                    ingresar = false;
                                                    Nuevofrm.RecibirValorIdentidad(PE.Identidad);
                                                    Nuevofrm.ShowDialog();
                                                    
                                                }
                                            }

                                            if (mostrarMensaje == false)
                                            {
                                                OE.ModificarEmpleado(PE, PE.Identidad);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("¡Debe llenar todos los campos para poder modificar el empleado!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("¡Debe llenar todos los campos para poder modificar el empleado!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("¡Debe llenar todos los campos para poder modificar el empleado!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("¡Debe llenar todos los campos para poder modificar el empleado!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("¡Debe llenar todos los campos para poder modificar el empleado!");
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("¡Debe llenar todos los campos para poder modificar el empleado!");
                    }
                }
                else
                {
                    MessageBox.Show("¡Debe llenar todos los campos para poder modificar el empleado!");
                    
                }
                if (txtNombre.Text.Any() && txtApellido.Text.Any() && txtDireccion.Text.Any() && cbCargo.Text.Any() && cbEstadocivil.Text.Any() && cbGenero.Text.Any() && chkSi.Checked == false)
                {
                    MessageBox.Show("Se ha actualizado exitosamente el empleado");
                }
                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("¡Debe llenar todos los campos para poder modificar el empleado!");
            }
            
        }
    }
}
