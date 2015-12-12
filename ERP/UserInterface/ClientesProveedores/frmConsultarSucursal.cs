using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace ERP.UserInterface.ClientesProveedores
{
    public partial class frmConsultarSucursal : Form
    {
        Services.ClientesProveedoresCRUD clienteProveedor = new Services.ClientesProveedoresCRUD();
        DataRepository.Conectar conn = new DataRepository.Conectar();
        public frmConsultarSucursal()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        private void frmClienteProveedor_Load_1(object sender, EventArgs e)
        {
            clienteProveedor.PopularDataGridSucursal(gvClienteProveedor);
        }


    }
}