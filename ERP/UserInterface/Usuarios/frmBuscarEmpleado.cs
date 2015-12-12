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

namespace ERP.UserInterface.Usuarios
{
    public partial class frmBuscarEmpleado : Form
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public static string identidad;
        public static string nombres;
        public static string apellidos;
        public static string direccion;
        public static bool genero;
        public static int cargo;
        public static bool estadoCivil;
        public static bool mostrar;

        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }
        public void ActualizarEstado()
        {
            Services.OperacionesEmpleado Nuevofrm = new Services.OperacionesEmpleado();
            for (int i = 0; i < gvDatosEmpleado.Rows.Count; i++)
            {
                Nuevofrm.DarDeBaja(bool.Parse(gvDatosEmpleado.Rows[i].Cells[7].Value.ToString()), gvDatosEmpleado.Rows[i].Cells[0].Value.ToString());
            }
        }
        public void Filtrado()
        {
            try
            {
                conn.DbOpen();
                DataTable dt = new DataTable();



                string ConsultaProductos = @"Select Identidad, Nombres, Apellidos, Id_PuestoEmpleado, Direccion, Genero, EstadoCivil, EstadoEmpleado From Usuario.Empleado where Nombres like '" + txtNombreEmpleado.Text + "%' and EstadoEmpleado = '" + chkActivo.Checked + "'";
                SqlCommand cmd = conn.Comando(ConsultaProductos);
                SqlDataReader rdr = cmd.ExecuteReader();
                int filas = 0;
                using (cmd)
                {

                    if (gvDatosEmpleado.Columns.Count > 7)
                    {
                        gvDatosEmpleado.Columns.Remove("Estado");

                    }
                    while (rdr.Read())
                    {

                        gvDatosEmpleado.Rows.Add(1);
                        gvDatosEmpleado.Rows[filas].Cells[0].Value = rdr.GetString(0);
                        gvDatosEmpleado.Rows[filas].Cells[1].Value = rdr.GetString(1);
                        gvDatosEmpleado.Rows[filas].Cells[2].Value = rdr.GetString(2);
                        gvDatosEmpleado.Rows[filas].Cells[3].Value = rdr.GetInt32(3);
                        gvDatosEmpleado.Rows[filas].Cells[4].Value = rdr.GetString(4);
                        gvDatosEmpleado.Rows[filas].Cells[5].Value = rdr.GetBoolean(5);
                        gvDatosEmpleado.Rows[filas].Cells[6].Value = rdr.GetBoolean(6);
                        EstadoUsuarios(filas, rdr.GetBoolean(7));
                        filas++;
                    }

                }


            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
            finally
            {
                conn.DbClose();
            }

        }
        private void gvDatosEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mostrar == true)
            {
                Services.OperacionesEmpleado OE = new Services.OperacionesEmpleado();
                int x = e.RowIndex;
                // Obtener el valor de la columnas en el DataTable.
                identidad = gvDatosEmpleado.Rows[x].Cells[0].Value.ToString();
                nombres = gvDatosEmpleado.Rows[x].Cells[1].Value.ToString();
                apellidos = gvDatosEmpleado.Rows[x].Cells[2].Value.ToString();
                cargo = int.Parse(gvDatosEmpleado.Rows[x].Cells[3].Value.ToString());
                direccion = gvDatosEmpleado.Rows[x].Cells[4].Value.ToString();
                if (gvDatosEmpleado.Rows[x].Cells[5].Value.ToString() == "Masculino")
                {
                    genero = true;
                }
                else
                {
                    genero = false;
                }
                if (gvDatosEmpleado.Rows[x].Cells[6].Value.ToString() == "Casado")
                {

                    estadoCivil = true;
                }
                else
                {
                    estadoCivil = false;
                }
                OE.ConsultarNombreCargo(cargo);
                this.Hide();
                frmModificarEmpleado Nuevofrm = new frmModificarEmpleado();
                Nuevofrm.ShowDialog();
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void PopularDatos()
        {
            for (int i = 0; i < gvDatosEmpleado.Rows.Count; i++)
            {
                if (gvDatosEmpleado.Rows[i].Cells[5].Value.ToString() == "True")
                {
                    gvDatosEmpleado.Rows[i].Cells[5].Value = "Masculino";
                }
                else
                {
                    gvDatosEmpleado.Rows[i].Cells[5].Value = "Femenino";
                }

                if (gvDatosEmpleado.Rows[i].Cells[6].Value.ToString() == "True")
                {
                    gvDatosEmpleado.Rows[i].Cells[6].Value = "Casado(a)";
                }
                else
                    gvDatosEmpleado.Rows[i].Cells[6].Value = "Soltero(a)";
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gvDatosEmpleado.Rows.Clear();
                Filtrado();
                PopularDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void EstadoUsuarios(int fila, bool estado)
        {
            if (fila == 0)
            {
                DataGridViewCheckBoxColumn DCB = new DataGridViewCheckBoxColumn();
                gvDatosEmpleado.Columns.Add(DCB);
                DCB.Name = "Estado";
                DCB.HeaderText = "Estado empleado";
                DCB.Width = 190;

            }

            gvDatosEmpleado.Rows[fila].Cells[7].Value = estado;
        }
        private void CargarEmpleados(int filas)
        {
            try
            {
                conn.DbOpen();
                DataTable dt = new DataTable();

                string ConsultaProductos = @"Select Identidad, Nombres, Apellidos, Id_PuestoEmpleado, Direccion, Genero, EstadoCivil, EstadoEmpleado From Usuario.Empleado Where EstadoEmpleado = '"+ chkActivo.Checked +"'";
                SqlCommand cmd = conn.Comando(ConsultaProductos);
                SqlDataReader rdr = cmd.ExecuteReader();

                using (cmd)
                {
                    if (gvDatosEmpleado.Columns.Count > 7)
                    {
                        gvDatosEmpleado.Columns.Remove("Estado");
                    }
                    while (rdr.Read())
                    {
                        gvDatosEmpleado.Rows.Add(1);
                        gvDatosEmpleado.Rows[filas].Cells[0].Value = rdr.GetString(0);
                        gvDatosEmpleado.Rows[filas].Cells[1].Value = rdr.GetString(1);
                        gvDatosEmpleado.Rows[filas].Cells[2].Value = rdr.GetString(2);
                        gvDatosEmpleado.Rows[filas].Cells[3].Value = rdr.GetInt32(3);
                        gvDatosEmpleado.Rows[filas].Cells[4].Value = rdr.GetString(4);
                        gvDatosEmpleado.Rows[filas].Cells[5].Value = rdr.GetBoolean(5);
                        gvDatosEmpleado.Rows[filas].Cells[6].Value = rdr.GetBoolean(6);
                        EstadoUsuarios(filas, rdr.GetBoolean(7));
                        filas++;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.DbClose();
            }
        }

        private void frmBuscarEmpleado_Load(object sender, EventArgs e)
        {
            if (mostrar == true)
            {
                btnActualizar.Visible = false;
            }
            CargarEmpleados(0);
            PopularDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEstado();
            MessageBox.Show("Se han actualizado los estados de los empleados exitosamente");
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if(chkActivo.Checked)
            {
                chkActivo.Text = "Activo";
            }
            else
            {
                chkActivo.Text = "Inactivo";
            }
        }
    }
}
