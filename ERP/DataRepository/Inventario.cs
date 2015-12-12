using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.Data.SqlClient;

namespace ERP.DataRepository
{
    class Inventario
    {
        //Propiedades de la tabla inventario
        public static string Id;
        public string IdInventarios { get { return Id; } set { Id = value; } }
        public string CodigoBarra { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int CantidadProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int PuntoReorden { get; set; }
        public DateTime FechaElaboracionProducto { get; set; }
        public DateTime FechaVencimientoProducto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CreadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int ModificadoPor { get; set; }
        public bool EstadoProducto { get; set; }
        public int IdProveedor { get; set; }
    }
}
