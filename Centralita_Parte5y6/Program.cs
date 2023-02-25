using System;
using Centralita_Parte5_Interfaz;

namespace Centralita_Parte5y6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer53";

            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local ll1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial ll2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Local l13 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial ll4 = new Provincial(Franja.Franja_1, ll2); //repetida, tira excepcion..

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas cuando se llame al metodo ordenar.

            try
            {
                c += ll1;
                c += ll2;
                c += ll4; //repetida, rompe aca..
                c += l13;
            }
            catch (CentralitaException ex)
            {
                Console.WriteLine($"Excepcion de tipo: {ex.Message}\nError de llamada tipo: {ex.NombreClase}\nEn el metodo: {ex.NombreMetodo}");
                Console.WriteLine("\n\nSe logro cargar las siguientes llamadas: \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepcion inesperada!!  \nDe tipo: {ex.Message}");
                Console.WriteLine("\n\nSe logro cargar las siguientes llamadas: \n");
            }


            c.OrdenarLlamadas();
            Console.WriteLine(c); //llama automaticamente al .tostring del objeto por default el Console writeline

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("                 REGISTRO LLAMADAS: ");
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine($"\n{c.Leer()}");

            Console.ReadKey();
        }
    }
}
