using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERP.DataRepository
{
    class PropiedadesClienteProveedor
    {
        public int id_Cliente_Proveedores { get; set; }
        public string RTN { get; set; }
        public string Nombres { get; set; }
        public string Observaciones { get; set; }
        public string Apellido { get; set; }
        public string Correo_Electronico { get; set; }
        public string Direccion { get; set; }
        public bool Estado_Cliente_Proveedor { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public int Creado_Por { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        public int Modificado_Por { get; set; }
    
    }
}
