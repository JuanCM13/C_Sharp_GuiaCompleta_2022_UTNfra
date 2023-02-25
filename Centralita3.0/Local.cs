using System;
using System.Collections.Generic;
using System.Text;

namespace Centralita3._0
{
    public class Local : Llamada
    {
        protected Single costoLlamada;

        public override Single CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Local(Llamada llamada, Single costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(String numOri, Single duracion, String numDes, Single costo)
            : base(duracion, numDes, numOri)
        {
            this.costoLlamada = costo;
        }

        private Single CalcularCosto()
        {
            return this.Duracion * this.costoLlamada;
        }

        protected override String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Llamada: {this.GetType().Name}\n{base.Mostrar()}");

            return str.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
