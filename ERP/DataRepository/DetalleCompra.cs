using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataRepository
{
    class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int NumeroProducto { get; set; }
        public int CantidadProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CreadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int ModificadoPor { get; set; }
        public int IdInventario { get; set; }
        public int IdCompra { get; set; }
        public char EstadoOrdenCompra { get; set; }
    }
}
