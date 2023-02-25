using System;
using BibliotecaCartuchera_ManejoInterfaces;

namespace ejer62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer62Cartuchera";

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            //Falta probar el main, lagregar elementos a las clases cartucheras y mostrar... 
            CartucheraMultiuso cMulti = new CartucheraMultiuso();
            CartucheraSimple cartucheraSimple= new();
            cartucheraSimple += miLapiz;
            cartucheraSimple += miBoligrafo;
            
                
            /*ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);*/

            Console.ReadKey();
        }
    }
}
