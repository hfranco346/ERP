using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERP.DataRepository
{
    class PropiedadesClienteProveedorsucursales
    {
        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string DireccionSucursa { get; set; }
        public string EstadoSucursal { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Creado_Por { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        public int Modificado_Por { get; set; }
        public int IdClientesProveedores { get; set; }
    
    }
}
