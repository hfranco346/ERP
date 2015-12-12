using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace ERP.DataRepository
{
    class InventarioVentas
    {
        //Variables
        //Inventario
        private static int idInventario;
        private static string codigoBarra;
        private static string nombreProducto;
        private static string descripcionProducto;
        private static decimal precioCompra;
        private static decimal precioVenta;
        private static string observaciones;
        private static int cantidad;
        private static int puntoReorden;
        private static DateTime fechaElaboracionProducto;
        private static DateTime fechaVencimientoProducto;
        private static DateTime fechaCreacion;
        private static int creadoPor;
        private static DateTime fechaModificacion;
        private static int modificadoPor;
        private static bool estadoProducto;
        //Impuesto
        private static int idImpuesto;
        private static string descripcion;
        private static decimal valor;
        private static bool estadoImpuesto;
        private static decimal impuestoAcumulado=0;


        //Propiedades
        //Inventario
        public int IdInventario
        {
            get { return idInventario; }
            set
            {
                idInventario = value;
            }
        }
        public string CodigoBarra
        {
            get { return codigoBarra; }
            set
            {
                codigoBarra = value;
            }
        }

        public string NombreProducto
        {
            get { return nombreProducto; }
            set
            {
                nombreProducto = value;
            }
        }
        public string DescripcionProducto
        {
            get { return descripcionProducto; }
            set
            {
                descripcionProducto = value;
            }
        }
        public decimal PrecioCompra
        {
            get { return precioCompra; }
            set
            {
                precioCompra = value;
            }
        }
        public decimal PrecioVenta
        {
            get { return precioVenta; }
            set
            {
                precioVenta = value;
            }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set
            {
                observaciones = value;
            }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                cantidad = value;
            }
        }
        public int PuntoReorden
        {
            get { return puntoReorden; }
            set
            {
                puntoReorden = value;
            }
        }
        public DateTime FechaElaboracionProducto
        {
            get { return fechaElaboracionProducto; }
            set
            {
                fechaElaboracionProducto = value;
            }
        }
        public DateTime FechaVencimientoProducto
        {
            get { return fechaVencimientoProducto; }
            set
            {
                fechaVencimientoProducto = value;
            }
        }
        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set
            {
                fechaCreacion = value;
            }
        }
        public int CreadoPor
        {
            get { return creadoPor; }
            set
            {
                creadoPor = value;
            }
        }
        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set
            {
                fechaModificacion = value;
            }
        }
        public int ModificadoPor
        {
            get { return modificadoPor; }
            set
            {
                modificadoPor = value;
            }
        }
        public bool EstadoProducto
        {
            get { return estadoProducto; }
            set
            {
                estadoProducto = value;
            }
        }
        //Impuesto
        public int IDImpuesto
        {
            get { return idImpuesto; }
            set
            {
                idImpuesto = value;
            }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                descripcion = value;
            }
        }
        public decimal Valor
        {
            get { return valor; }
            set
            {
                valor = value;
            }
        }
        public bool EstadoImpuesto
        {
            get { return estadoImpuesto; }
            set
            {
                estadoImpuesto = value;
            }
        }

        public decimal ImpuestoAcumulado
        {
            get {return impuestoAcumulado; }
            set { impuestoAcumulado =impuestoAcumulado+value; }
        }
    }
}
