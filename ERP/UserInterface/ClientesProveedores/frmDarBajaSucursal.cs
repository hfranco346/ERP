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
    public partial class frmDarBajaSucursal : Form
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public frmDarBajaSucursal()
        {
            InitializeComponent();
        }

        private void gbInventario_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void frmDarBajaClienteProveedor_Load(object sender, EventArgs e)
        {
            
            List<DataRepository.PropiedadesClienteProveedorsucursales> Sucursal = Services.SucursalCRUD.CargarNombreSucursal();

            if (Sucursal.Any())
            {

                Sucursal.ForEach(sucursal => lstSucursal.Items.Add(sucursal.NombreSucursal));
            }
            else
                lstSucursal.Items.Add("¡Error al momento de cargar las sucursales!");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lstSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT  NombreSucursal,EstadoSucursal, Observaciones FROM ClienteProveedor.Sucursal WHERE NombreSucursal= @nombresucursal";

            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                conn.DbOpen();
                using (myCommand)
                {

                    myCommand.Parameters.Add("@nombresucursal", SqlDbType.NVarChar,30).Value = lstSucursal.SelectedItem.ToString();

                }
                SqlDataReader dtr = myCommand.ExecuteReader();
                while (dtr.Read())
                {
                    lstSucursal.Text = dtr.GetString(0).Trim() + dtr.GetString(2).Trim() + " ";
                    lbnombre.Text = dtr.GetString(0).Trim();
                    //lblEstado.Text = dtr.GetString(1).Trim();
                    //lblEstado.Text = dtr.GetBoolean(2).ToString();
                    txtObservaciones.Text = dtr.GetString(2).ToString();

                    if (dtr.GetBoolean(1))
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

                epValidarTextos.SetError(txtObservaciones, "escriba el nombre");
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
            if (lstSucursal.SelectedIndex != -1)
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
                    string sql = "UPDATE ClienteProveedor.Sucursal SET  EstadoSucursal=@estadoSucursal,Observaciones=@observaciones WHERE NombreSucursal=@nombresucursal";
                    SqlCommand myCommand = conn.Comando(sql);

                    try
                    {
                        conn.DbOpen();
                        using (myCommand)
                        {
                            myCommand.Parameters.Add("@estadoSucursal", SqlDbType.Bit, 1).Value = estado;
                            myCommand.Parameters.Add("@observaciones", SqlDbType.Text).Value = txtObservaciones.Text;
                            myCommand.Parameters.Add("@NombreSucursal", SqlDbType.NVarChar, 255).Value = lstSucursal.SelectedItem.ToString();
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
                MessageBox.Show("Selecciones un Nombre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
    
