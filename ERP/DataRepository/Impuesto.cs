using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataRepository
{
    class Impuesto
    {
        //Propiedades de la tabla impuesto
        public int IdImpuesto { get; set; }
        public string DescripcionImpuesto { get; set; }
        public decimal Valor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CreadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int ModificadoPor { get; set; }
        public bool EstadoImpuesto { get; set; }
        public int IdInventario { get; set; }
    }
}
