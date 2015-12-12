using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataRepository
{
    class PropiedadesEmpleado
    {
        public int IdEmpleado { get; set; }
        public string Identidad { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public bool Genero { get; set; }
        public bool EstadoCivil { get; set; }
        public string EstadoEmpleado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CreadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int ModificadoPor { get; set; }
        public int Id_PuestoEmpleado { get; set; }
    }
}
