using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ERP.UserInterface.ClientesProveedores
{
    public partial class frmDarBajaClienteProveedor : Form
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public frmDarBajaClienteProveedor()
        {
            InitializeComponent();
        }

        private void frmDarBajaClienteProveedor_Load(object sender, EventArgs e)
        {
            List<DataRepository.PropiedadesClienteProveedor> clienteProveedor = Services.ClientesProveedoresCRUD.CargarRTN();

            if (clienteProveedor.Any())
            {

                clienteProveedor.ForEach(proveedorCliente => lstClienteProveedor.Items.Add(proveedorCliente.RTN));
            }
            else
                lstClienteProveedor.Items.Add("¡Error al momento de cargar los ClienteProveedor!");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lstClienteProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT RTN, Nombres, Apellidos, EstadoClienteProveedor, TipoUsuarioCompraVenta, Observaciones FROM ClienteProveedor.Clientes_Proveedores WHERE RTN = @rtn";

            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                conn.DbOpen();
                using (myCommand)
                {

                    myCommand.Parameters.Add("@rtn", SqlDbType.NChar).Value = lstClienteProveedor.SelectedItem.ToString();

                }
                SqlDataReader dtr = myCommand.ExecuteReader();
                while (dtr.Read())
                {
                    lstClienteProveedor.Text = dtr.GetString(0).Trim() + dtr.GetString(2).Trim() + " ";
                    lblRTN.Text = dtr.GetString(0).Trim();
                    lblNombre.Text = dtr.GetString(1).Trim();
                    lblApellido.Text = dtr.GetString(2).Trim();
                    lblTipo.Text = dtr.GetBoolean(4).ToString();
                    lblEstado.Text = dtr.GetBoolean(3).ToString();
                    txtObservaciones.Text = dtr.GetString(5).ToString();

                    if (dtr.GetBoolean(4))
                    {
                        lblTipo.Text = "Cliente/Proveedor";
                    }
                    else
                    {
                        lblTipo.Text = "Cliente";
                    }
                    if (dtr.GetBoolean(3))
                    {
                        lblEstado.Text = "Habilitado";
                    }
                    else
                    {
                        lblEstado.Text = "Inhabilitado";
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.DbClose();
            }
        }
        public bool ValidarTextoObservaciones()
        {

            if (txtObservaciones.Text == "")
            {

                epValidarTextos.SetError(txtObservaciones, "Escriba el numero de identidad");
                txtObservaciones.Focus();
                return false;
            }
            else
            {
                epValidarTextos.Clear();
                return true;
            }
        }
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (lstClienteProveedor.SelectedIndex != -1)
            {
                if (ValidarTextoObservaciones() == true)
                {
                    //int estado;
                    bool estado;
                    if (lblEstado.Text == "Habilitado")
                    {
                        estado = false;
                    }
                    else
                    {
                        estado = true;
                    }
                    string sql = "UPDATE ClienteProveedor.Clientes_Proveedores SET EstadoClienteProveedor=@estadoClienteProveedor, Observaciones=@observaciones WHERE RTN=@rtn";
                    SqlCommand myCommand = conn.Comando(sql);

                    try
                    {
                        conn.DbOpen();
                        using (myCommand)
                        {
                            myCommand.Parameters.Add("@estadoClienteProveedor", SqlDbType.Bit, 1).Value = estado;
                            myCommand.Parameters.Add("@observaciones", SqlDbType.Text).Value = txtObservaciones.Text;
                            myCommand.Parameters.Add("@rtn", SqlDbType.NChar, 16).Value = lstClienteProveedor.SelectedItem.ToString();
                        }
                        myCommand.ExecuteNonQuery();

                        if (estado == false)
                        {
                            lblEstado.Text = "Inhabilitado";
                        }
                        else
                        {
                            lblEstado.Text = "Habilitado";
                        }
                        MessageBox.Show("Estado Modifcado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (FormatException fex)
                    {
                        MessageBox.Show(fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.DbClose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciones un número de RTN", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
    
