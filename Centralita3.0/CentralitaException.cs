using System;
using System.Collections.Generic;
using System.Text;

namespace Centralita3._0
{
    public class CentralitaException : Exception
    {
        private String nombreClase;
        private String nombreMetodo;
        
        public CentralitaException(String mensaje , String clase , String metodo)
            :this(mensaje , clase , metodo , null)
        {}

        public CentralitaException(String mensaje, String clase, String metodo , Exception innerEx)
            :base(mensaje , innerEx)
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
