using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Rectangulo : Figura
    {
        private Single baase;
        private Single alto;

        public Rectangulo(Single bas , Single alt)
        {
            this.baase = bas;
            this.alto = alt;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo..";
        }

        public override double CalcularSuperficie()
        {
            return this.baase * alto;
        }

        public override double CalcularPerimetro()
        {
            return (this.baase * 2) + (this.alto * 2);
        }

    }
}
