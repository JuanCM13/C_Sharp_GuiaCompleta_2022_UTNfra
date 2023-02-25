using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita2
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;


        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja , llamada.Duracion, llamada.NroDestino)
        {}

        public Provincial(String numOrigen, Franja miFranja, Single duracion, String numDestino)
            : base(duracion , numDestino , numOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public override Single CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private Single CalcularCosto()
        {
            Int32 franja = (Int32)this.franjaHoraria;
            Single costo = 0;

            switch (franja)
            {
                case 0:
                    costo = 0.99F;
                    break;
                case 1:
                    costo = 1.25F;
                    break;
                case 3:
                    costo = 0.66F;
                    break;
            }

            return this.duracion * costo;
        }

        protected override String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Llamada: {this.GetType().Name}\n{base.Mostrar()}\n" +
                $"Franja Horaria: {this.franjaHoraria}");

            return str.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
