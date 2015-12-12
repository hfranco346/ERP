using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP.UserInterface.Inventario
{
    public partial class frmConsultarImpuestos : Form
    {
        
        Services.ImpuestoCRUD impuesto = new Services.ImpuestoCRUD();
        DataRepository.Conectar conn = new DataRepository.Conectar();
        DataTable dt;
        public frmConsultarImpuestos()
        {
            InitializeComponent();
        }

        private void frmConsultarImpuestos_Load(object sender, EventArgs e)
        {
            llenargrid();
        }
        //LLenar el dataGrid con todos los datos de los impuestos agregados
        private void llenargrid()
        {
            txtbuscar.Focus();
            // Query
            string sql = @"Select * From Inventario.Impuesto";
            // Crear el comando para consulta
            SqlCommand myCommand = conn.Comando(sql);
            try
            {
                // Crear el Data Adapter
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = myCommand;

                // Crear y popular el Data Set
                DataSet ds = new DataSet();

                da.Fill(ds, "Inventario.Impuesto");
                // Obtener la tabla de referencia

                dt = ds.Tables["Inventario.Impuesto"];
                // Obtener la tabla de referencia

                DataView dv = new DataView(dt, "", "Descripcion", DataViewRowState.Unchanged);
                gvImpuestos.DataSource = dv;
                gvImpuestos.Columns[0].Visible = false;
                gvImpuestos.Columns[1].HeaderText = "Nombre Impuesto";
                gvImpuestos.Columns[2].HeaderText = "Valor";
                gvImpuestos.Columns[3].HeaderText = "Fecha Creación";
                gvImpuestos.Columns[4].HeaderText = "Creado Por";
                gvImpuestos.Columns[5].HeaderText = "Fecha Modificacíon";
                gvImpuestos.Columns[6].HeaderText = "Modificado Por";
                gvImpuestos.Columns[7].HeaderText = "Id Inventario";
                gvImpuestos.Columns[8].HeaderText = "Estado";
                gvImpuestos.Columns[9].HeaderText = "Onservaciones";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
        }

        //Buscar impuesto ya sea por su código o su nombre
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            try
            {
                if (rbNombreProducto.Checked == false && rbIdInventario.Checked == false)
                {
                    MessageBox.Show("Seleccione como desea buscar: por nombre o código del producto");
                }
                else
                {
                    if (rbNombreProducto.Checked)
                    {
                        DV.RowFilter = string.Format("Descripcion LIKE '%{0}%'", txtbuscar.Text);
                    }
                    else if (rbIdInventario.Checked)
                    {
                        DV.RowFilter = ("IdInventario ='" + txtbuscar.Text + "'").ToString();
                        //DV.RowFilter = string.Format("IdInventario LIKE '%{0}%'", txtbuscar.Text);
                    }
                    gvImpuestos.DataSource = DV;
                }

            }
            catch (Exception) { }
        }

        //Cuando seleccione el radioButton NombreProducto que el foco se ubique en el campo buscar.
        private void rbNombreProducto_CheckedChanged(object sender, EventArgs e)
        {
            txtbuscar.Focus();
        }
        //Cuando seleccione el radioButton IdInventario que el foco se ubique en el campo buscar.
        private void rbIdInventario_CheckedChanged(object sender, EventArgs e)
        {
            txtbuscar.Focus();
        }
        //Botón cerrar la ventana actual
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
