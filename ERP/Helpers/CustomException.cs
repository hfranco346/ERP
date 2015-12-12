using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Helpers
{
    class CustomException : Exception
    {
        //para excepciones que vienen vacias.
        public CustomException() : base() { }
        //para excepciones que solo vienen con un mensaje.
        public CustomException(string message) : base(message) { }
        //para excepciones que vienen con mensaje y traen argumentos como parametros. 
        public CustomException(string format, params object[] args)
            : base(string.Format(format, args)) { }
    }
}
