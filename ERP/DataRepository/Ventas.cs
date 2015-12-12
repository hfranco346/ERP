using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataRepository
{
    class Ventas
    {
        public static int idVenta { get; set; }
        public static DateTime fechaVenta { get; set; }
        public static string observaciones { get; set; }
        public static DateTime fechaCreacion { get; set; }
        public static int creadoPor { get; set; }
        public static DateTime fechaModificacion { get; set; }
        public static string modificadoPor { get; set; }
        public static int idClientesProveedores { get; set; }

    }
}
