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
    public partial class frmDarBajaImpuesto : Form
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public frmDarBajaImpuesto()
        {
            InitializeComponent();
        }

        //Botón cambiar estado de impuesto con sus repectivas especificaciones dadas
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
                if (lstImpuestos.SelectedIndex != -1)
                {
                    if (Validar_CajasTexto() == true)
                    {
                        bool estadoImpuesto;
                        if (lblEstadoImpuesto.Text == "Habilitado")
                        {
                            estadoImpuesto = false;
                        }
                        else
                        {
                            estadoImpuesto = true;
                        }
                        string sql = "UPDATE Inventario.Impuesto SET EstadoImpuesto=@estadoImpuesto,Observaciones=@observaciones,ModificadoPor=@modificadoPor WHERE Descripcion=@descripcion";
                        SqlCommand myCommand = conn.Comando(sql);
                        try
                        {
                            conn.DbOpen();
                            using (myCommand)
                            {
                                myCommand.Parameters.Add("@estadoImpuesto", SqlDbType.Bit, 1).Value = estadoImpuesto;
                                myCommand.Parameters.Add("@observaciones", SqlDbType.Text).Value = txtObservaciones.Text;
                                myCommand.Parameters.Add("@descripcion", SqlDbType.NVarChar, 50).Value = lstImpuestos.SelectedItem.ToString();
                                myCommand.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;
                            }
                            myCommand.ExecuteNonQuery();
                            MessageBox.Show("Estado Modifcado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (estadoImpuesto == false)
                            {
                                lblEstadoImpuesto.Text = "Inhabilitado";
                            }
                            else
                            {
                                lblEstadoImpuesto.Text = "Habilitado";
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
                    MessageBox.Show("Seleccione un código de producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        //Cargar todos los impuestos en una lista para dar de baja
        private void frmDarBajaImpuesto_Load(object sender, EventArgs e)
        {
            List<DataRepository.Impuesto> impuestos = Services.ImpuestoCRUD.CargarImpuestos();

            if (impuestos.Any())
            {
                lstImpuestos.Items.Add("\n");
                lstImpuestos.Items.Add("              Todos los Impuestos\n");
                lstImpuestos.Items.Add("_________________________________________________________________________\n");
                lstImpuestos.Items.Add("\n");

                impuestos.ForEach(producto => lstImpuestos.Items.Add(producto.IdImpuesto));
            }
            else
                lstImpuestos.Items.Add("¡No hay impuestos disponibles para dar de baja!");
        }
        //Validar los campos que el usuario no puede dejar en blanco
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
        //Botón cerrar ventana actual
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //Mostrar información de cada impuesto a dar de baja cuando seleccionemos un código de impuesto
        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT Impuesto.Descripcion,Impuesto.EstadoImpuesto,Impuesto.Valor,Inventario.CodigoBarra,Inventario.NombreProducto, Inventario.CantidadProducto,
                  Inventario.EstadoProducto FROM Inventario.Impuesto INNER JOIN Inventario.Inventario ON Impuesto.IdInventario = Inventario.IdInventario
                  WHERE Impuesto.IDImpuesto=@idImpuesto";
            //string sql = "SELECT Descripcion, EstadoImpuesto,Valor,IdInventario FROM Inventario.Impuesto WHERE Descripcion = @descripcion";
            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                conn.DbOpen();
                using (myCommand)
                {
                    myCommand.Parameters.Add("@idImpuesto", SqlDbType.Int).Value = lstImpuestos.SelectedItem;
                }
                SqlDataReader dtr = myCommand.ExecuteReader();
                while (dtr.Read())
                {
                    lstImpuestos.Text = dtr.GetString(0).Trim() + " ";
                    lblNombreImpuesto.Text = dtr.GetString(0).Trim();
                    lblCodigoBarra.Text = dtr.GetString(3).ToString();
                    lblNombre.Text = dtr.GetString(4).ToString();
                    lblCantidadProducto.Text = dtr.GetInt32(5).ToString();
                    lblValor.Text = dtr.GetDecimal(2).ToString();

                    if (dtr.GetBoolean(1))
                    {
                        lblEstadoImpuesto.Text = "Habilitado";
                    }
                    else
                    {
                        lblEstadoImpuesto.Text = "Inhabilitado";
                    }
                }
            }
            catch (FormatException ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.DbClose();
            }
        }
        //Limpiar el error cuando jutifique por que se dio de baja.
        private void txtObservaciones_Leave(object sender, EventArgs e)
        {
            if (txtObservaciones.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }
    }
}
