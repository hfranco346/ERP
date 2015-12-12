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
    public partial class frmModificarSucursales : Form
    {
        public frmModificarSucursales()
        {
            InitializeComponent();
        }
       
        DataRepository.Conectar conn = new DataRepository.Conectar();
        SqlCommand myCommand = new SqlCommand();

        private void frmModificarSucursales_Load(object sender, EventArgs e)
        {
            List<DataRepository.Sucursal> proveedores = Services.QueryConsultarSucursal.CargarSucursales();
            try
            {
                if (proveedores.Any())
                {
                    //txtOrdenar.AppendText("Productos en Inventario:\n");
                    lstSucursal.Items.Add("_________________________________________________________________________\n");
                    lstSucursal.Items.Add("                   Sucursales:\n");
                    lstSucursal.Items.Add("_________________________________________________________________________\n");
                    lstSucursal.Items.Add("\n");
                    lstSucursal.Items.Add("Id Sucursal");
                    lstSucursal.Items.Add("_____________\n");

                    proveedores.ForEach(cliente => lstSucursal.Items.Add(cliente.IdSucursal));
                }
                else
                    lstSucursal.Items.Add("¡Error al momento de cargar los clientes proveedores!");
            }
            catch (Exception)
            { }
        }

        private void lblLinea_Click(object sender, EventArgs e)
        {

        }

        private void lstSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT IdSucursal, NombreSucursal, DireccionSucursal, FechaCreacion, CreadoPor,  FechaModificacion, ModificadoPor FROM ClienteProveedor.Sucursal WHERE IdSucursal = @IdSucursal";

            try
            {
                myCommand = conn.Comando(sql);
                try
                {
                    conn.DbOpen();
                    using (myCommand)
                    {
                        myCommand.Parameters.Add("@IdSucursal", SqlDbType.Int).Value = Int32.Parse(lstSucursal.SelectedItem.ToString());
                    }
                    SqlDataReader dtr = myCommand.ExecuteReader();
                    while (dtr.Read())
                    {
                        //lstSucursal.Text = dtr.GetInt32g(0).Trim() + dtr.GetString(3).Trim() + " ";
                        lblID.Text = dtr.GetInt32(0).ToString().Trim();
                        txtNombreSucursal.Text = dtr.GetString(1).ToString();
                        txtDire.Text = dtr.GetString(2).Trim();
                        //dtpFechaCreacion.Text = dtr.GetDateTime(4).ToString();
                        dtpFechaModificacion.Text = dtr.GetDateTime(5).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    conn.DbClose();
                }
            }
            catch (Exception) { }
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstSucursal.SelectedIndex != -1)
            {
                if (txtNombreSucursal.Text!= "" && txtDire.Text != "")
                {
                int estado;
                string sql = @"UPDATE ClienteProveedor.Sucursal SET NombreSucursal = @nombresucursal,
                                 DireccionSucursal = @direccionSucursal,  FechaModificacion = @FechaModificacion WHERE IdSucursal = @IdSucursal";
                SqlCommand myCommand = conn.Comando(sql);
                try
                {
                    conn.DbOpen();
                    using (myCommand)
                    {
                        myCommand.Parameters.Add("@IdSucursal", SqlDbType.Int).Value = Int32.Parse( lstSucursal.SelectedItem.ToString());
                        myCommand.Parameters.Add("@nombresucursal", SqlDbType.Text).Value = txtNombreSucursal.Text;
                        myCommand.Parameters.Add("@direccionSucursal", SqlDbType.Text).Value = txtDire.Text;
                        myCommand.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;

                    }
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Producto Modifcado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("No se permiten campos en blanco", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciones un código de producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
