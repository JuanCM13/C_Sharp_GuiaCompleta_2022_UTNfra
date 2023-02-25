using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita1
{
    public class Provincial :Llamada
    {
        protected Franja franjaHoraria;


        public Provincial(Franja miFranja, Llamada llamada)
            :base(llamada.Duracion , llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(String numOrigen , Franja miFranja , Single duracion , String numDestino)
            :this(miFranja , new Llamada(duracion , numDestino , numOrigen))
        {}

        public Single CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private Single CalcularCosto()
        {
            Int32 franja = (Int32)this.franjaHoraria;
            Single costo = 0;

            switch(franja)
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

        public override String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Llamada: {this.GetType().Name}\n{base.Mostrar()}\n" +
                $"Franja Horaria: {this.franjaHoraria}\nCosto Llamada: {this.CostoLlamada}");

            return str.ToString();
        }
    }
}
