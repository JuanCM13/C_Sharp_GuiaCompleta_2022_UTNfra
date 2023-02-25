using System;

namespace Figuras
{
    // base altura, cuadrados y rectangulos
    //radio circulos
    public abstract class Figura
    {
        public virtual String Dibujar()
        {
            return "Dibujando forma..";
        }

        public abstract Double CalcularSuperficie();

        public abstract Double CalcularPerimetro();

    }
}
