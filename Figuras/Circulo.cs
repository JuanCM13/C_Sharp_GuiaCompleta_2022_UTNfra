using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public sealed class Circulo : Figura
    {
        private Single radio;

        public Circulo(Single radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando Circulo..";
        }

        public override double CalcularSuperficie()
        {
            return Math.Pow((Math.PI * this.radio), 2);
        }

        public override double CalcularPerimetro()
        {
            return (2 * Math.PI * this.radio); 
        }

    }
}
