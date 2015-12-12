using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataRepository
{
    class PropiedadesInicioSesion
    {
        public static int IdUsuario { get; set; }
        public string Alias { get; set; }
        public string Clave { get; set; }
        public static string nombreUsuario { get; set; }
        public static bool Login =false;
    }
}
