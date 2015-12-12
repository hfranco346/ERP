using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataRepository
{
    class Compra
    {

        public int IdCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public string NumeroFactura { get; set; }
        public decimal Total { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CreadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int ModificadoPor { get; set; }
        public int IdClientesProveedores { get; set; }
        public int IdUsuario { get; set; }
        public string EstadoOrden { get; set; }

    }
}
