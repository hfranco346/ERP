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
using System.Data;

namespace ERP.UserInterface.Usuarios
{
    public partial class frmConsultarUsuariosyModificarlos : Form
    {
        DataRepository.Conectar conn = new DataRepository.Conectar();
        frmModificarUsuario MU = new frmModificarUsuario();
        public static int idUsuario;
        public static int idSeguridad;
        public static int idEmpleado;
        public static bool estado;
        public static string alias;
        public static bool mostrar;
        public frmConsultarUsuariosyModificarlos()
        {
            InitializeComponent();
        }

        public void ActualizarEstado()
        {
            Services.OperacionesUsuarios Nuevofrm = new Services.OperacionesUsuarios();
            for (int i = 0; i < gvDatosUsuario.Rows.Count; i++)
            {
                Nuevofrm.DarDeBaja(bool.Parse(gvDatosUsuario.Rows[i].Cells[4].Value.ToString()), gvDatosUsuario.Rows[i].Cells[0].Value.ToString());
            }
        }
        public void Filtrado()
        {
            try
            {
                conn.DbOpen();
                DataTable dt = new DataTable();



                string ConsultaProductos = @"Select u.IdUsuario, u.IdEmpleado, u.IdSeguridad, u.Alias, u.Estado  From Usuario.Usuarios u inner join Usuario.Empleado e on u.IdEmpleado = e.IdEmpleado where u.Alias like '" + txtNombreUsuario.Text + "%' and u.Estado = '" + chkActivo.Checked + "' and e.EstadoEmpleado = 1";
                    SqlCommand cmd = conn.Comando(ConsultaProductos);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    int filas = 0;
                    using (cmd)
                    {

                        if (gvDatosUsuario.Columns.Count > 4)
                        {
                            gvDatosUsuario.Columns.Remove("Estado");
                                                
                        }
                        while (rdr.Read())
                        {
                            
                            gvDatosUsuario.Rows.Add(1);

                            gvDatosUsuario.Rows[filas].Cells[0].Value = rdr.GetInt32(0);
                            gvDatosUsuario.Rows[filas].Cells[1].Value = rdr.GetInt32(1);
                            gvDatosUsuario.Rows[filas].Cells[2].Value = rdr.GetInt32(2);
                            gvDatosUsuario.Rows[filas].Cells[3].Value = rdr.GetString(3);
                            EstadoUsuarios(filas,rdr.GetBoolean(4));
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

        private void gvDatosUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mostrar == true)
            { 
            int x = e.RowIndex;
            
            
            // Obtener el valor de la columnas en el DataTable.
            idUsuario = int.Parse(gvDatosUsuario.Rows[x].Cells[0].Value.ToString());
            idEmpleado = int.Parse(gvDatosUsuario.Rows[x].Cells[1].Value.ToString());
            idSeguridad = int.Parse(gvDatosUsuario.Rows[x].Cells[2].Value.ToString());
            alias = gvDatosUsuario.Rows[x].Cells[3].Value.ToString();
            estado = bool.Parse(gvDatosUsuario.Rows[x].Cells[4].Value.ToString());
            MU.RecibirValores(idUsuario, idSeguridad, idEmpleado, estado, alias);
            Services.OperacionesUsuarios OU = new Services.OperacionesUsuarios();
            OU.ConsultarIdentidad(idEmpleado);
            OU.ConsultarNombreRol(idSeguridad);


            OU.ConsultarClave(idUsuario);
            this.Hide();
           
            frmModificarUsuario Nuevofrm = new frmModificarUsuario();
            Nuevofrm.ShowDialog();
            
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gvDatosUsuario.Rows.Clear();
                Filtrado();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void EstadoUsuarios(int fila, bool estado)
        {
            if (fila == 0)
            {
                DataGridViewCheckBoxColumn DCB = new DataGridViewCheckBoxColumn();
                gvDatosUsuario.Columns.Add(DCB);
                DCB.Name = "Estado";
                DCB.HeaderText = "Estado empleado";
                DCB.Width = 190;

            }

            gvDatosUsuario.Rows[fila].Cells[4].Value = estado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BuscarUsuario()
        {
           
        }
        private void CargarProductosDT(int filas)
        {
            try
            {
                conn.DbOpen();
                DataTable dt = new DataTable();



                string ConsultaProductos = @"Select u.IdUsuario, u.IdEmpleado, u.IdSeguridad, u.Alias, u.Estado From Usuario.Usuarios u  inner join Usuario.Empleado e  on  u.IdEmpleado = e.IdEmpleado where u.Estado = '"+chkActivo.Checked+"' and e.EstadoEmpleado =1";
                    SqlCommand cmd = conn.Comando(ConsultaProductos);
                    SqlDataReader rdr = cmd.ExecuteReader();
                   
                    using (cmd)
                    {

                        if (gvDatosUsuario.Columns.Count > 4)
                        {
                            gvDatosUsuario.Columns.Remove("Estado");
                                                
                        }
                        while (rdr.Read())
                        {
                            
                            gvDatosUsuario.Rows.Add(1);

                            gvDatosUsuario.Rows[filas].Cells[0].Value = rdr.GetInt32(0);
                            gvDatosUsuario.Rows[filas].Cells[1].Value = rdr.GetInt32(1);
                            gvDatosUsuario.Rows[filas].Cells[2].Value = rdr.GetInt32(2);
                            gvDatosUsuario.Rows[filas].Cells[3].Value = rdr.GetString(3);
                            EstadoUsuarios(filas,rdr.GetBoolean(4));
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

        private void frmConsultarUsuariosyModificarlos_Load(object sender, EventArgs e)
        {
            if (mostrar == true)
            {
                btnActualizar.Visible = false; 
                
            }
            CargarProductosDT(0);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEstado();
            MessageBox.Show("Se han actualizado los estados de los usuarios exitosamente");
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivo.Checked)
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
