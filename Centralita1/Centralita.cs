using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita1
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
            :this()
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
            Int32 tip = (Int32)tipo;

            foreach(Llamada item in this.Llamadas)
            {

                if(item is Local && (tip == 0 || tip == 2) )
                {
                    recaudado += ((Local)item).CostoLlamada;
                }
                else
                {
                    if(item is Provincial && (tip == 1 || tip == 2) )
                    {
                        recaudado += ((Provincial)item).CostoLlamada;
                    }
                }
            }
            return recaudado;
        }

        public String Mostrar()
        {
            StringBuilder str = new StringBuilder();
            ///razón social, la ganancia total, ganancia por llamados locales 
            ///y provinciales y el detalle de las llamadas realizadas

            str.AppendLine($"Razon Social: {this.razonSocial}\nGanancia Total: {this.GananciaPorTotal}\n" +
                $"Ganancia Llamadas Locales: {this.GananciaPorLocal}\n" +
                $"Ganancia Llamadas Provinciales: {this.GananciaPorProvincial}");

            str.AppendLine("-----------------------------------------------------------");
            str.AppendLine("                        LLAMADAS");
            str.AppendLine("-----------------------------------------------------------");

            if(this.Llamadas.Count > 0)
            {
                foreach(Llamada item in this.Llamadas)
                {
                    if(item is Local)
                    {
                        str.AppendLine(((Local)item).Mostrar());
                    }
                    else
                    {
                        if(item is Provincial)
                        {
                            str.AppendLine(((Provincial)item).Mostrar());
                        }
                        else
                        {
                            str.AppendLine(item.Mostrar());
                        }
                    }
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
    }
}
