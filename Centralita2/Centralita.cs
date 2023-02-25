using System;
using System.Collections.Generic;
using System.Text;

namespace Centralita2
{
    public class Centralita
    {
        private List<Llamada> listaLlamadas;
        protected String razonSocial;

        private Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(String nombre)
            : this()
        {
            this.razonSocial = nombre;
        }

        public Single GananciaPorLocal
        {
            get { return this.CalcularGanancias(TipoLlamada.Local); }
        }

        public Single GananciaPorProvincial
        {
            get { return this.CalcularGanancias(TipoLlamada.Provincial); }
        }

        public Single GananciaPorTotal
        {
            get { return this.CalcularGanancias(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaLlamadas; }
        }

        private Single CalcularGanancias(TipoLlamada tipo)
        {
            Single recaudado = 0;
            String auxTipo = Enum.GetName(tipo);
            String auxLlamada;

            foreach (Llamada item in this.Llamadas)
            {
                auxLlamada = (item.GetType().Name).ToString();
                if (auxTipo == "Todas" || auxTipo == auxLlamada)
                {
                    recaudado += item.CostoLlamada;
                }
            }
            return recaudado;
        }

        private String Mostrar()
        {
            StringBuilder str = new StringBuilder();
            Int32 index = 0;

            str.AppendLine($"Razon Social: {this.razonSocial}\nGanancia Total: ${this.GananciaPorTotal.ToString("#.#,00")}\n" +
                $"Ganancia Llamadas Locales: ${this.GananciaPorLocal.ToString("#.#,00")}\n" +
                $"Ganancia Llamadas Provinciales: ${this.GananciaPorProvincial.ToString("#.#,00")}");

            str.AppendLine("-----------------------------------------------------------");
            str.AppendLine("                        LLAMADAS");
            str.AppendLine("-----------------------------------------------------------");

            if (this.Llamadas.Count > 0)
            {
                foreach(Llamada item in this.Llamadas)
                {
                    index++;
                    str.AppendLine("-----------------------------------------------------------");
                    str.AppendLine($"                        LLAMADA: {index}");
                    str.AppendLine("-----------------------------------------------------------");
                    str.AppendLine(item.ToString());
                }
            }
            else
            {
                str.AppendLine("No hay llamadas por el momento...");
            }
            return str.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool ret = false;
            if(!(c is null) && !(l is null))
            {
                foreach(Llamada item in c.Llamadas)
                {
                    if(item == l)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c , Llamada l)
        {
            if(!(c is null) && !(l is null) && (c != l == true) )
            {
                c.AgregarLlamada(l);
            }
            return c;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);   
        }
    }
}
