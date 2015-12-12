using ERP.UserInterface.Usuarios;
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
    public partial class frmAgregarEmpleado : Form
    {
        public string idCargo;
        public bool guardar = true;
        public frmAgregarEmpleado()
        {
          
            InitializeComponent();
         
        }

        private void btnAgregarTelefonos_Click(object sender, EventArgs e)
        {
        }

        private void chkNo_Click(object sender, EventArgs e)
        {
            chkSi.Checked = false;
            chkNo.Checked = true;
            btnGuardar.Text = "Guardar";
        }

        private void chkSi_Click(object sender, EventArgs e)
        {
            if (guardar == false)
            {
                chkNo.Checked = false;
                chkSi.Checked = true;
                btnGuardar.Text = "Siguiente";

                
            }
            else
            {
                MessageBox.Show("Debe de guardar el empleado antes de asignarle un empleado");
                chkSi.Checked = false;
            }
             
        }

        private void chkhablitado_Click(object sender, EventArgs e)
        {
            chkhablitado.Checked = true;
            chkdesabilitado.Checked = false;
        }

        private void chkdesabilitado_Click(object sender, EventArgs e)
        {
            chkhablitado.Checked = false;
            chkdesabilitado.Checked = true;
        }

        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            mskIdentidad.Focus();
            chkhablitado.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ingresar();  
        }
        public void Ingresar()
        {
            try
            {
                DataRepository.PropiedadesEmpleado PE = new DataRepository.PropiedadesEmpleado();
                Services.OperacionesEmpleado OE = new Services.OperacionesEmpleado();
                if (mskIdentidad.Text != "    -    -")
                {
                    PE.Identidad = mskIdentidad.Text;
                    if (txtNombre.Text.Any())
                    {
                        PE.Nombres = txtNombre.Text;
                        if (txtApellido.Text.Any())
                        {
                            PE.Apellidos = txtApellido.Text;
                            if (txtDireccion.Text.Any())
                            {
                                PE.Direccion = txtDireccion.Text;
                                if (cbGenero.Text.Any())
                                {
                                    if (cbGenero.Text == "Masculino")
                                    {
                                        PE.Genero = true;
                                    }
                                    else
                                    {
                                        PE.Genero = false;
                                    }
                                    if (cbCargo.Text.Any())
                                    {
                                        idCargo = cbCargo.SelectedValue.ToString();
                                        PE.Id_PuestoEmpleado = int.Parse(idCargo);
                                        if (cbEstadocivil.Text.Any())
                                        {
                                            if (cbEstadocivil.Text == "Soltero(a)")
                                            {
                                                PE.EstadoCivil = false;
                                            }
                                            else
                                            {
                                                PE.EstadoCivil = true;
                                            }
                                            if (cbEstadocivil.Text.Any())
                                            {
                                                if (chkhablitado.Checked)
                                                {
                                                    PE.EstadoEmpleado = true.ToString();
                                                }
                                                else
                                                {
                                                    PE.EstadoEmpleado = false.ToString();
                                                }
                                                if (chkSi.Checked)
                                                {
                                                    if (Services.OperacionesEmpleado.validacionIdentidad == true)
                                                    {
                                                        this.Hide();
                                                        frmAgregarUsuario Nuevofrm = new frmAgregarUsuario();
                                                        frmAgregarUsuario.ingresar = true;
                                                        Nuevofrm.RecibirValoesAgregarEmpleado(PE.Identidad, bool.Parse(PE.EstadoEmpleado));

                                                        Nuevofrm.ShowDialog();
                                                    }
                                                    else
                                                    {
                                                        mskIdentidad.Focus();
                                                    }
                                                }
                                                else
                                                {

                                                    Services.OperacionesEmpleado OU = new Services.OperacionesEmpleado();
                                                    frmAgregarUsuario.ingresar = false;
                                                    guardar = false;
                                                    OE.InsertarEmpleado(PE);
                                                    OU.ConsultarId(mskIdentidad.Text);
                                                    if(Services.OperacionesEmpleado.validacionIdentidad == true) 
                                                    {
                                                        MessageBox.Show("Sus datos han sido agregados exitosamente. Por favor agregue números teléfonos a este empleado");
                                                        frmTelefonos Nuevofrm = new frmTelefonos();
                                                        Nuevofrm.ShowDialog();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Por favor verifique la identidad.");
                                                        mskIdentidad.Clear();
                                                        mskIdentidad.Focus();
                                                    }
                                                    

                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el empleado!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el empleado!");
                                            cbEstadocivil.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el empleado!");
                                        cbCargo.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el empleado!");
                                    cbGenero.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el empleado!");
                                txtDireccion.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el empleado!");
                            txtApellido.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el empleado!");
                        txtNombre.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el empleado!");
                    mskIdentidad.Focus();
                }

            }
            catch (NullReferenceException ex)
            {

                MessageBox.Show("¡Debe llenar todos los campos para poder ingresar el empleado!");
            }
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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void cbCargo_Click(object sender, EventArgs e)
        {
            PopulaCargos();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            UserInterface.Usuarios.frmAgregarCargo Nuevofrm = new UserInterface.Usuarios.frmAgregarCargo();
            Nuevofrm.ShowDialog();
        }

        private void chkSi_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
