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
    public partial class ModificarClienteProveedor : Form
    {
        public ModificarClienteProveedor()
        {
            InitializeComponent();
        }
        DataRepository.Conectar conn = new DataRepository.Conectar();
        DataRepository.ClientesProveedores CP = new DataRepository.ClientesProveedores();
        //Services.QueryConsultarProductos consultarProducto = new Services.QueryConsultarProductos();
        private void ModificarClienteProveedor_Load(object sender, EventArgs e)
        {
            List<DataRepository.ClientesProveedores> proveedores = Services.QueryConsultarClienteProveedor.CargarClienteProveedor();
            try
            {
                if (proveedores.Any())
                {
                    //txtOrdenar.AppendText("Productos en Inventario:\n");
                    lstClienteProveedor.Items.Add("_________________________________________________________________________\n");
                    lstClienteProveedor.Items.Add("                   Clientes Proveedores:\n");
                    lstClienteProveedor.Items.Add("_________________________________________________________________________\n");
                    lstClienteProveedor.Items.Add("\n");
                    lstClienteProveedor.Items.Add("RTN");
                    lstClienteProveedor.Items.Add("_____________\n");

                    proveedores.ForEach(cliente => lstClienteProveedor.Items.Add(cliente.RTN));
                }
                else
                    lstClienteProveedor.Items.Add("¡Error al momento de cargar los clientes proveedores!");
            }
            catch(Exception)
            { }
        }
         
        
        private void lstClienteProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTipoUsuario.Text = "Seleccione Tipo";
            string sql = "SELECT IdClientesProveedores, RTN, Nombres, Apellidos, CorreoElectronico, Direccion, TipoUsuarioCompraVenta, EstadoClienteProveedor, FechaModificacion FROM ClienteProveedor.Clientes_Proveedores WHERE RTN = @rtn";

            try
            {
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
                        lstClienteProveedor.Text = dtr.GetString(1).Trim() + dtr.GetString(3).Trim() + " ";
                        lblID.Text = dtr.GetInt32(0).ToString().Trim();
                        lblRTN.Text = dtr.GetString(1).ToString().Trim();
                        txtNombre.Text = dtr.GetString(2).Trim();
                        txtApellidos.Text = dtr.GetString(3).Trim();
                        txtCorreo.Text = dtr.GetString(4).ToString().Trim();
                        txtDireccion.Text = dtr.GetString(5).ToString();

                        bool x = dtr.GetBoolean(6);

                        if (x)
                            cbTipoUsuario.Text = "Proveedor";
                        else
                            cbTipoUsuario.Text = "Cliente";


                        
                        dtpFechaModificacion.Text = dtr.GetDateTime(10).ToString();

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
            catch (Exception) { }
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();



                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstClienteProveedor.SelectedIndex != -1)
            {

                if (txtNombre.Text != "" && txtApellidos.Text != "" && txtCorreo.Text != "" && txtDireccion.Text != "" && cbTipoUsuario.Text != "")
                {
                   int estado;
                    string sql = @"UPDATE ClienteProveedor.Clientes_Proveedores SET Nombres = @nombres,
                                  Apellidos = @apellidos, Direccion=@direccion, TipoUsuarioCompraVenta=@tipousuariocompraventa,  CorreoElectronico =@correoelectronico, FechaModificacion = @fechamodificacion WHERE RTN = @rtn";
                    SqlCommand myCommand = conn.Comando(sql);
                    try
                    {
                        conn.DbOpen();
                        using (myCommand)
                        {
                            myCommand.Parameters.Add("@rtn", SqlDbType.NChar,14).Value = lstClienteProveedor.SelectedItem.ToString();
                            myCommand.Parameters.Add("@nombres", SqlDbType.Text).Value = txtNombre.Text;
                            myCommand.Parameters.Add("@apellidos", SqlDbType.Text).Value = txtApellidos.Text;
                            myCommand.Parameters.Add("@correoelectronico", SqlDbType.Text).Value = txtCorreo.Text;
                            myCommand.Parameters.Add("@direccion", SqlDbType.Text).Value = txtDireccion.Text;
                            myCommand.Parameters.Add("@tipousuariocompraventa", SqlDbType.Bit).Value =cbTipoUsuario.SelectedIndex;
                           // myCommand.Parameters.Add("@fechacreacion", SqlDbType.DateTime).Value = dtpFechaCreacion.Text;
                           
                            myCommand.Parameters.Add("@fechamodificacion", SqlDbType.DateTime).Value = DateTime.Now;
                            
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
                MessageBox.Show("No se permiten campos en blanco", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
        }
}

