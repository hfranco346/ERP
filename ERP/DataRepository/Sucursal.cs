using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataRepository
{
    // Estableciendo las propiedades de la sucursal
    class Sucursal
    {
        public int IdSucursal { get; set; }

        public string NombreSucursal { get; set; }

        public string DireccionSucursal { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int CreadoPor { get; set; }

        public DateTime FechaModificacion { get; set; }

        public int ModificadoPor { get; set; }

        public int IdClientesProveedores { get; set; }
    }
}
