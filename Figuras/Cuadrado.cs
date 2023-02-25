using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(Single bas, Single alt)
            :base(bas,alt)
        {
        }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado";
        }
    }
}
