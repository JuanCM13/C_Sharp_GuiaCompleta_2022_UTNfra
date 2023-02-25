using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Parte5_Interfaz
{
    public class CentralitaException : Exception
    {
        private String nombreClase;
        private String nombreMetodo;

        public CentralitaException(String mensaje, String clase, String metodo)
            : this(mensaje, clase, metodo, null)
        { }

        public CentralitaException(String mensaje, String clase, String metodo, Exception innerEx)
            : base(mensaje, innerEx)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public String NombreClase
        {
            get { return this.nombreClase; }
        }

        public String NombreMetodo
        {
            get { return this.nombreMetodo; }
        }

    }
}
