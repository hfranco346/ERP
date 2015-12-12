using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataRepository
{
    // Estableciendo las propiedades de los clientes/proveedores
    class ClientesProveedores
    {
        private static int idClientesProveedores;
        private static string nombres;
        private static string apellido;
        public int IdClientesProveedores { get { return idClientesProveedores; } set { idClientesProveedores = value; } }

        public string RTN { get; set; }

        public string Nombres { get { return nombres; } set { nombres = value; } }

        public string Apellidos { get { return apellido; } set { apellido = value; } }

        public string CorreoElectronico { get; set; }

        public string Direccion { get; set; }

        public bool TipoUsuarioCompraVenta { get; set; }

        public bool EstadoClienteProveedor { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int CreadoPor { get; set; }

        public DateTime FechaModificacion { get; set; }

        public int ModificadoPor { get; set; }
    }
}
