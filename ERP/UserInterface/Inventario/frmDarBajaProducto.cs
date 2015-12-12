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

namespace ERP.UserInterface.Inventario
{
    public partial class frmDarBajaProducto : Form
    {
        //Conexión
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public frmDarBajaProducto()
        {
            InitializeComponent();
        }
        //Cargar en una lista todos los productos disponibles para dar de baja
        private void frmDarBajaProducto_Load(object sender, EventArgs e)
        {
            List<DataRepository.Inventario> productos = Services.InventarioCRUD.CargarCodigoProducto();
            if (productos.Any())
            {
                lstProducto.Items.Add("\n");
                lstProducto.Items.Add("              Todos los Productos\n");
                lstProducto.Items.Add("_________________________________________________________________________\n");
                lstProducto.Items.Add("\n");

                productos.ForEach(producto => lstProducto.Items.Add(producto.NombreProducto));
            }
            else
                lstProducto.Items.Add("¡Error al momento de cargar los productos!");
        }
        //Botón cerrar ventana actual
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //Mostrar información de cada producto cuando seleccionamos un código de producto
        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT CodigoBarra, EstadoProducto,NombreProducto,CantidadProducto FROM Inventario.Inventario WHERE NombreProducto = @nombreProducto";
            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                conn.DbOpen();
                using (myCommand)
                {
                    myCommand.Parameters.Add("@nombreProducto", SqlDbType.NVarChar, 30).Value = lstProducto.SelectedItem.ToString();
                }
                SqlDataReader dtr = myCommand.ExecuteReader();
                while (dtr.Read())
                {
                    lstProducto.Text = dtr.GetString(0).Trim() + " " + dtr.GetString(2).Trim();
                    lblCodigoBarra.Text = dtr.GetString(0).Trim();
                    lblNombreProducto.Text = dtr.GetString(2).Trim();
                    lblCantidad.Text = dtr.GetInt32(3).ToString();
                    //txtObservaciones.Text = dtr.GetString(4).Trim();

                    if (dtr.GetBoolean(1))
                    {
                        lblEstadoProducto.Text = "Habilitado";
                    }
                    else
                    {
                        lblEstadoProducto.Text = "Inhabilitado";
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //Botón cerrar ventana actual
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //Validar que no se le permita al usuario dejar campos vacíos
        Boolean Validar_CajasTexto()
        {
            if (txtObservaciones.Text.ToString() == "")
            {

                epValidarTextos.SetError(txtObservaciones, "Justifique por qué se esta dando de baja");
                txtObservaciones.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        //Botón cambiar estado de producto con las especificaciones dadas
        private void btnCambiarEstado_Click_1(object sender, EventArgs e)
        {
                if (lstProducto.SelectedIndex != -1)
                {
                    if (lblCantidad.Text == "0")
                    {
                        if (Validar_CajasTexto() == true)
                        {
                            //int estado;
                            bool estadoProducto;
                            if (lblEstadoProducto.Text == "Habilitado")
                            {
                                estadoProducto = false;
                            }
                            else
                            {
                                estadoProducto = true;
                            }
                            string sql = "UPDATE Inventario.Inventario SET EstadoProducto=@estadoProducto,ModificadoPor=@modificadoPor WHERE NombreProducto=@nombreProducto";
                            SqlCommand myCommand = conn.Comando(sql);

                            try
                            {
                                conn.DbOpen();
                                using (myCommand)
                                {
                                    myCommand.Parameters.Add("@estadoProducto", SqlDbType.Bit, 1).Value = estadoProducto;
                                    myCommand.Parameters.Add("@nombreProducto", SqlDbType.NChar, 16).Value = lstProducto.SelectedItem.ToString();
                                    myCommand.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                                }
                                myCommand.ExecuteNonQuery();
                                MessageBox.Show("Estado Modifcado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (estadoProducto == false)
                                {
                                    lblEstadoProducto.Text = "Inhabilitado";
                                }
                                else
                                {
                                    lblEstadoProducto.Text = "Habilitado";
                                }
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
                        MessageBox.Show("Este producto no se puede dar de baja porque tiene existencia", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un código de producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        //Limpiar el error cuando ingresa una observación o justificación de porque se dió de baja
        private void txtObservaciones_Leave(object sender, EventArgs e)
        {
            if (txtObservaciones.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }

        
    }
}
