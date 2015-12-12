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
    public partial class frmModificarImpuesto : Form
    {
        DataRepository.Impuesto Impuesto = new DataRepository.Impuesto();
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public frmModificarImpuesto()
        {
            InitializeComponent();
        }

        //Botón Modificar el impuesto con las especificaciones dadas
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstImpuesto.SelectedIndex != -1)
            {
                if (Validar_CajasTexto() == true)
                {
                    //int estado;
                    string sql = @"UPDATE Inventario.Impuesto SET Descripcion=@descripcion,Valor = @valor, Observaciones = @observaciones,
                                 FechaModificacion=@fechaModificacion,ModificadoPor=@modificadoPor WHERE IDImpuesto = @idImpuesto";
                    SqlCommand myCommand = conn.Comando(sql);
                    try
                    {
                        conn.DbOpen();
                        using (myCommand)
                        {
                            myCommand.Parameters.Add("@idImpuesto", SqlDbType.Int).Value = lstImpuesto.SelectedItem;
                            myCommand.Parameters.Add("@descripcion", SqlDbType.Text).Value = txtDescripcion.Text.ToString();
                            myCommand.Parameters.Add("@valor", SqlDbType.Decimal).Value = txtValor.Text;
                            myCommand.Parameters.Add("@observaciones", SqlDbType.Text).Value = txtObservaciones.Text;
                            myCommand.Parameters.Add("@fechaModificacion", SqlDbType.DateTime).Value = DateTime.Now;
                            myCommand.Parameters.Add("@modificadoPor", SqlDbType.Int).Value = DataRepository.PropiedadesInicioSesion.IdUsuario;

                            //Impuesto.IdImpuesto = int.Parse(cbProductos.SelectedValue.ToString());
                        }
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Impuesto Modifcado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (FormatException fex)
                    {
                        MessageBox.Show(fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Este impuesto ya existe");
                        txtValor.Focus();
                    }
                    finally
                    {
                        conn.DbClose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciones un código de impuesto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Carga todos los impuestos a una lista
        private void frmModificarImpuesto_Load(object sender, EventArgs e)
        {
            Services.ImpuestoCRUD Agregar = new Services.ImpuestoCRUD();
            //Agregar.PopularComboboxProducto(cbProductos);
            //cbProductos.Text = "Seleccione un Proveedor";
            List<DataRepository.Impuesto> impuestos = Services.ImpuestoCRUD.CargarImpuestosParaModificar();
            try
            {
                if (impuestos.Any())
                {
                    lstImpuesto.Items.Add("\n");
                    lstImpuesto.Items.Add("                Todos los Impuestos\n");
                    lstImpuesto.Items.Add("_________________________________________________________________________\n");
                    lstImpuesto.Items.Add("\n");


                    impuestos.ForEach(impuesto => lstImpuesto.Items.Add(impuesto.IdImpuesto));
                }
                else
                    lstImpuesto.Items.Add("¡Error al momento de cargar los impuestos!");
            }
            catch (Exception)
            { }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //mostrar la información de cada impuesto según el impuesto seleccionado
        private void lstImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT Impuesto.IDImpuesto,Inventario.IdInventario,Impuesto.Valor,Impuesto.Descripcion,Impuesto.Observaciones,Inventario.NombreProducto, Inventario.CantidadProducto, Inventario.EstadoProducto
                  FROM Inventario.Impuesto INNER JOIN Inventario.Inventario ON Impuesto.IdInventario = Inventario.IdInventario
                   WHERE Impuesto.IDImpuesto=@idImpuesto";
            //string sql = "SELECT IDImpuesto,IdInventario,Valor, Descripcion,Observaciones  FROM Inventario.Impuesto WHERE Descripcion = @descripcion";

            try
            {
                SqlCommand myCommand = conn.Comando(sql);
                try
                {
                    conn.DbOpen();
                    using (myCommand)
                    {
                        myCommand.Parameters.Add("@idImpuesto", SqlDbType.Int).Value = lstImpuesto.SelectedItem;
                    }
                    SqlDataReader dtr = myCommand.ExecuteReader();
                    while (dtr.Read())
                    {
                        lstImpuesto.Text = dtr.GetString(3).Trim() + dtr.GetString(4).Trim() + " ";
                        txtIdInventario.Text = dtr.GetInt32(1).ToString();
                        txtValor.Text = dtr.GetDecimal(2).ToString();
                        txtDescripcion.Text = dtr.GetString(3).Trim();
                        //lblImpuesto.Text=dtr.GetString(4).Trim();
                        lblProducto.Text = dtr.GetString(5).Trim();
                        
                        txtObservaciones.Text = dtr.GetString(4).Trim();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.DbClose();
                }
            }
            catch (Exception) { }
        }
        //Validar la tecla tabulación
        bool Validar_TabulacionEnter(Boolean s, char t)
        {
            if (s)
            {
                if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                }
                return true;
            }
        }

        //Validar sólo permitir números decimales
        bool validar_NumerosDecimales(Boolean s, char t)
        {
            //grafo 3
            if (s)
            {
                if (char.IsLetter(t))
                {
                    return false;
                }
                else if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                }
                return true;
            }
        }
        //validar sólo números enteros
        bool validar_NumerosEnteros(Boolean s, char t)
        {
            if (s)
            {
                if (char.IsLetter(t))
                {
                    return false;
                }
                else if (char.IsPunctuation(t))
                {
                    return false;
                }
                else if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (t == Convert.ToChar(Keys.Enter))
                {
                    SendKeys.Send("{Tab}");
                }
                return true;
            }
        }
        //Validar que los campos no esten vacios
        Boolean Validar_CajasTexto()
        {
            if (txtObservaciones.Text.ToString() == "")
            {

                epValidarTextos.SetError(txtObservaciones, "Justifique por qué se modificó");
                txtObservaciones.Focus();
                return false;
            }

            else if (txtDescripcion.Text.ToString() == "")
            {

                epValidarTextos.SetError(txtDescripcion, "Ingrese una descripción de impuesto");
                txtDescripcion.Focus();
                return false;
            }

            else if (txtValor.Text.ToString() == "")
            {
                epValidarTextos.SetError(txtValor, "Ingrese un valor de impuesto");
                txtValor.Focus();
                return false;
            }
            else if (txtIdInventario.Text.ToString() == "")
            {

                epValidarTextos.SetError(txtIdInventario, "Ingrese un producto al cual se le asignará");
                txtIdInventario.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //Que  limpie el error al escribir una observación
        private void txtObservaciones_Leave(object sender, EventArgs e)
        {
            if (txtObservaciones.Text.ToString() != "")
            {
                epValidarTextos.Clear();
            }
        }
        //Números decimales
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validar_NumerosDecimales(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Números enteros
        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validar_NumerosEnteros(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Tecla enter
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar_TabulacionEnter(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Tecla enter
        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar_TabulacionEnter(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Tecla enter
        private void btnModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar_TabulacionEnter(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Tecla enter
        private void btnCerrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar_TabulacionEnter(true, e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
