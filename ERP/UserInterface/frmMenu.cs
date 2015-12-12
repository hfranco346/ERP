using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.UserInterface.Usuarios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            Services.OperacionesInicioSesion NUEVO = new Services.OperacionesInicioSesion();
            NUEVO.ValidarInicioSesion();
            UserInterface.Usuarios.frmInicioSesion IS = new UserInterface.Usuarios.frmInicioSesion();
            if (DataRepository.PropiedadesInicioSesion.Login)
            {

                IS.ShowDialog();
                Usuario();
                Deshabilitar();
                ValidacionPermisos(DataRepository.PropiedadesInicioSesion.IdUsuario);

            }
            else
            {
                MessageBox.Show("Para utilizar el sistema debe ingresar obligatoriamente un empleado al cual se le asignará un usuario.\n\nNOTA: Aconsejamos que el primer usuario lleve todos los privilegios para usar todo el sistema.");
                sddbVentas.Enabled = false;
                tsbCompras.Enabled = false;
                tsbEmpleados.Enabled = false;
                tsbInventario.Enabled = false;
                tsbClienteProveedor.Enabled = false;
                frmAgregarEmpleado Nuevofrm = new frmAgregarEmpleado();
                Nuevofrm.ShowDialog();
            }
        }
        public void Deshabilitar()
        {
            nuevaVentaToolStripMenuItem1.Enabled = false;
            devoluciónToolStripMenuItem.Enabled = false;
            nuevaCompraToolStripMenuItem1.Enabled = false;
            listarOrdenesToolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem5.Enabled = false;
            toolStripMenuItem9.Enabled = false;
            toolStripMenuItem12.Enabled = false;
            inventarioToolStripMenuItem.Enabled = false;
            toolStripMenuItem15.Enabled = false;
            balanceGeneralToolStripMenuItem.Enabled = false;
            estadoDeResultadosToolStripMenuItem.Enabled = false;
        }
        public string Mensaje="";
        public  void Popularmensaje()
        {
            Services.InventarioCRUD Productos = new Services.InventarioCRUD();
            int x = 0;
           
            foreach (var item in Productos.ProductoReorden())
	        {
                if(x>0)
                Mensaje = Mensaje + ", " + item;
                else
                Mensaje = Mensaje + item;
                x++;

	        }
            if (Mensaje.Any())
            {
                MessageBox.Show("La existencia de estos productos es baja: " + Mensaje + ".\n\n Por favor hacer un pedido de compra.");

            }
        }
        public void ValidacionPermisos(int id)
        {
            Services.OperacionesRoles OR = new Services.OperacionesRoles();

            
            foreach (var item in OR.ComprobarRoles(id))
            {
                if (item.ToString() == "Inventario")
                {
                    inventarioToolStripMenuItem.Enabled = true;
                }
                if (item.ToString() == "Nueva venta")
                {
                    nuevaVentaToolStripMenuItem1.Enabled = true;
                }
                if (item.ToString() == "Nueva compra")
                {
                    nuevaCompraToolStripMenuItem1.Enabled = true;
                    Popularmensaje();
                    
                    
                }
                if (item.ToString() == "Clientes/Proveedores")
                {
                    balanceGeneralToolStripMenuItem.Enabled = true;
                }
                if (item.ToString() == "Empleados")
                {
                    toolStripMenuItem5.Enabled = true;
                }
                if (item.ToString() == "Usuarios")
                {
                    toolStripMenuItem1.Enabled = true;
                }
                if (item.ToString() == "Cargos")
                {
                    toolStripMenuItem12.Enabled = true;
                }
                if (item.ToString() == "Impuestos")
                {
                    toolStripMenuItem15.Enabled = true;
                }
                if (item.ToString() == "Roles")
                {
                    toolStripMenuItem9.Enabled = true;
                }
                if (item.ToString() == "Sucursales")
                {
                    estadoDeResultadosToolStripMenuItem.Enabled = true;
                }
                if (item.ToString() == "Devolución")
                {
                    devoluciónToolStripMenuItem.Enabled = true;
                }
                if (item.ToString() == "Listar ordenes")
                {
                    listarOrdenesToolStripMenuItem1.Enabled = true;
                }
            }
        }
        public void Usuario()
        {
            this.Text ="Usuario: " +UserInterface.Usuarios.frmInicioSesion.alias;
        }
        
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            UserInterface.Usuarios.frmModificarCargo Nuevofrm = new UserInterface.Usuarios.frmModificarCargo();
            Nuevofrm.ShowDialog();
        }

        private void devoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
             UserInterface.Ventas.frmDevolucionVenta frmdevolucion = new UserInterface.Ventas.frmDevolucionVenta();
            frmdevolucion.ShowDialog(this);
       
        }

        private void listarOrdenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInterface.Compras.frmListarOrdenesDeCompra frmlistarCompras = new UserInterface.Compras.frmListarOrdenesDeCompra();
            frmlistarCompras.ShowDialog(this);
        }

        private void nuevaCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInterface.Compras.frmCompras frmcompras = new UserInterface.Compras.frmCompras();
            frmcompras.ShowDialog(this);
        }

        private void nuevaVentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInterface.Ventas.frmNuevaVenta frmnuevaVenta = new UserInterface.Ventas.frmNuevaVenta();
            frmnuevaVenta.ShowDialog(this);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            UserInterface.Usuarios.frmAgregarCargo Nuevofrm = new UserInterface.Usuarios.frmAgregarCargo();
            Nuevofrm.ShowDialog();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            UserInterface.Usuarios.frmModificarRol Nuevofrm = new UserInterface.Usuarios.frmModificarRol();
            Nuevofrm.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            UserInterface.Usuarios.frmAgregarRol Nuevofrm = new UserInterface.Usuarios.frmAgregarRol();
            Nuevofrm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UserInterface.Usuarios.frmConsultarUsuariosyModificarlos Nuevofrm = new UserInterface.Usuarios.frmConsultarUsuariosyModificarlos();
            UserInterface.Usuarios.frmConsultarUsuariosyModificarlos.mostrar = true;
            Nuevofrm.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            UserInterface.Usuarios.frmBuscarEmpleado Nuevofrm = new UserInterface.Usuarios.frmBuscarEmpleado();
            UserInterface.Usuarios.frmBuscarEmpleado.mostrar = true;
            Nuevofrm.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            UserInterface.Usuarios.frmAgregarEmpleado Nuevofrm = new UserInterface.Usuarios.frmAgregarEmpleado();
            Nuevofrm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterface.Inventario.frmAgregarProducto inventario = new UserInterface.Inventario.frmAgregarProducto();
            inventario.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterface.Inventario.frmConsutarProducto Producto = new UserInterface.Inventario.frmConsutarProducto();
            Producto.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterface.Inventario.frmModificarProducto Actualizar = new UserInterface.Inventario.frmModificarProducto();
            Actualizar.ShowDialog();
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterface.Inventario.frmDarBajaProducto Deshabilitar = new UserInterface.Inventario.frmDarBajaProducto();
            Deshabilitar.ShowDialog();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            UserInterface.Inventario.frmAgregarImpuesto Impuesto = new UserInterface.Inventario.frmAgregarImpuesto();
            Impuesto.ShowDialog();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            UserInterface.Inventario.frmConsultarImpuestos ConsultarImpuesto = new UserInterface.Inventario.frmConsultarImpuestos();
            ConsultarImpuesto.ShowDialog();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            UserInterface.Inventario.frmModificarImpuesto ActualizarImpuesto = new UserInterface.Inventario.frmModificarImpuesto();
                ActualizarImpuesto.ShowDialog();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            UserInterface.Inventario.frmDarBajaImpuesto DarBajaImpuesto = new UserInterface.Inventario.frmDarBajaImpuesto();
            DarBajaImpuesto.ShowDialog();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInterface.ClientesProveedores.frmAgregarClienteProveedor Agregar = new UserInterface.ClientesProveedores.frmAgregarClienteProveedor();
            Agregar.ShowDialog();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInterface.ClientesProveedores.ModificarClienteProveedor ModificarCliePro = new UserInterface.ClientesProveedores.ModificarClienteProveedor();
            ModificarCliePro.ShowDialog();
        }

        private void darDeBajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInterface.ClientesProveedores.frmDarBajaClienteProveedor Darbaja = new UserInterface.ClientesProveedores.frmDarBajaClienteProveedor();
            Darbaja.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInterface.ClientesProveedores.frmConsultarClienteProveedor ConsultarClientePro = new UserInterface.ClientesProveedores.frmConsultarClienteProveedor();
            ConsultarClientePro.ShowDialog();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterface.ClientesProveedores.frmAgregarSucursal Sucursal = new UserInterface.ClientesProveedores.frmAgregarSucursal();
            Sucursal.ShowDialog();

        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UserInterface.ClientesProveedores.frmModificarSucursales Actualizar = new UserInterface.ClientesProveedores.frmModificarSucursales();
            Actualizar.ShowDialog();
        }

        private void darDeBajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UserInterface.ClientesProveedores.frmDarBajaSucursal Darbaja = new UserInterface.ClientesProveedores.frmDarBajaSucursal();
            Darbaja.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UserInterface.ClientesProveedores.frmConsultarSucursal ConsultarSucursal = new UserInterface.ClientesProveedores.frmConsultarSucursal();
            ConsultarSucursal.ShowDialog();
        }

        private void estadoDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            UserInterface.Usuarios.frmBuscarEmpleado Nuevofrm = new UserInterface.Usuarios.frmBuscarEmpleado();
            UserInterface.Usuarios.frmBuscarEmpleado.mostrar = false;
            Nuevofrm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleadosSinUsuario Nuevofrm = new frmBuscarEmpleadosSinUsuario();
            Nuevofrm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmConsultarUsuariosyModificarlos Nuevofrm = new frmConsultarUsuariosyModificarlos();
            frmConsultarUsuariosyModificarlos.mostrar = false;
            Nuevofrm.ShowDialog();
        }

        private void ghghToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
 
  
            frmInicioSesion Inicio = new frmInicioSesion();
            Inicio.ShowDialog();
       
            
        }

        private void tslAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercade acerca = new frmAcercade();
            acerca.Show();
        }
    }
}
