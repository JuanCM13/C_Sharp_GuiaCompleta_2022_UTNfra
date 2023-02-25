using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnciendanSusMotores_4._0
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private String nombreClase;
        private String nombreMetodo;

        public CompetenciaNoDisponibleException(String mensaje, String clase, String metodo)
            : this(mensaje, clase, metodo, null)
        { }

        public CompetenciaNoDisponibleException(String mensaje, String clase, String metodo, Exception innerException)
            : base(mensaje, innerException)
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

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            Exception aux = this;

            str.AppendLine($"Excepcion del metodo: {this.NombreMetodo} de la clase: {this.NombreClase}");
            str.AppendLine($"Mensaje: {this.Message}\n");

            if (this.InnerException != null)
            {
                str.AppendLine("InnerExceptions: ");
                while (aux.InnerException != null)
                {
                    str.AppendLine("---------------------------------------------------------\n");
                    str.Append(aux.InnerException.ToString());
                    aux = aux.InnerException;
                    str.AppendLine("---------------------------------------------------------");
                }
            }

            return str.ToString();
        }
    }
}
