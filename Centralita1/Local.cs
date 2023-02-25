using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita1
{
    public class Local :Llamada
    {
        protected Single costoLlamada;

        public Single CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Local(Llamada llamada , Single costo)
            :base(llamada.Duracion , llamada.NroDestino , llamada.NroOrigen)
        {
            this.costoLlamada = costo;
        }

        public Local(String numOri , Single duracion, String numDes,  Single costo)
            :this(new Llamada(duracion , numDes , numOri) , costo)
        {}

        private Single CalcularCosto()
        {
            return this.Duracion * this.costoLlamada;
        }

        public override String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Llamada: {this.GetType().Name}\n{base.Mostrar()}\n" +
                $"Costo Llamada: {this.CostoLlamada}");
            
            return str.ToString();
        }

    }
}
