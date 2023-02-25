using System;
using Centralita2;

namespace Centralita_2_0
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer50";

            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local ll1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial ll2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Local l13 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial ll4 = new Provincial(Franja.Franja_3, ll2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas cuando se llame al metodo ordenar.

            c += ll1;
            c += ll2;
            c += l13;
            c += ll4;

            c.OrdenarLlamadas();
            Console.WriteLine(c); //llama automaticamente al .tostring del objeto por default el Console writeline

            Console.ReadKey();
        }
    }
}
