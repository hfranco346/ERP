using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.UserInterface.Ventas
{
    public partial class frmFactura : Form
    {
        
        
        public frmFactura()
        {
            InitializeComponent();
        }
        private void frmFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eRPDataSet.Detalle'
            this.detalleTableAdapter.Fill(this.eRPDataSet.Detalle, DataRepository.Ventas.idVenta);
            // TODO: esta línea de código carga datos en la tabla 'eRPDataSet.Encabezado'
            this.encabezadoTableAdapter.Fill(this.eRPDataSet.Encabezado, DataRepository.Ventas.idVenta);
            this.rpv.RefreshReport();
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
