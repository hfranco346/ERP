using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataRepository
{
    class Usuarios
    {
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public int IdSeguridad { get; set; }
        public string Alias { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CreadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int ModificadoPor { get; set; }
    }
}
