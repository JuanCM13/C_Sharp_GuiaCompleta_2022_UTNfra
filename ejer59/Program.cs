using System;
using GenericsTorneoBiblioteca;

namespace ejer59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer59Generics";

            Torneo<EquipoFutbol> champions = new("Champions League Football League");
            Torneo<EquipoBasquet> nbaProms = new("Torneo NBA 2022");

            EquipoFutbol boquita = new("Boca" , new DateTime(2014, 06, 12));
            EquipoFutbol river = new("River", new DateTime(2019, 11, 02));
            EquipoFutbol almagro = new("Almagro", new DateTime(2001, 03, 26));

            EquipoBasquet bulls = new("Chicago Bulls", new DateTime(1997, 08, 13));
            EquipoBasquet spurs = new("Minessota Spurs", new DateTime(1983, 01, 29));
            EquipoBasquet celtics = new("Boston Celtics", new DateTime(1993, 11, 02));

            champions += boquita;
            champions += river;
            champions += almagro;

            nbaProms += bulls;
            nbaProms += spurs;
            nbaProms += celtics;

            //Prueba basquet carga valores ok
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Prueba basquet carga valores ok");
            Console.WriteLine("------------------------------------------\n\n");
            Console.WriteLine(nbaProms.Mostrar());
            
            Console.ReadKey();

            //Prueba futbol carga valores ok
            Console.WriteLine("\n\n------------------------------------------");        
            Console.WriteLine("Prueba football carga valores ok");
            Console.WriteLine("------------------------------------------\n\n");
            Console.WriteLine(champions.Mostrar());

            Console.ReadKey();
            Console.Clear();

            //---------------------------------------------------------------------------
            champions += boquita;
            champions += river;
            champions += new EquipoFutbol("Boca", new DateTime(2014, 06, 12));
            //---------------------------------------------------------------------------

            //Prueba futbol carga valores falsos
            Console.WriteLine("\n\n------------------------------------------");
            Console.WriteLine("Prueba football carga valores falsos, tendria que tirar lo mismo que antes");
            Console.WriteLine("------------------------------------------\n\n");
            Console.WriteLine(champions.Mostrar());

            Console.ReadKey();

            //---------------------------------------------------------------------------
            nbaProms += spurs;
            nbaProms += celtics;
            nbaProms += new EquipoBasquet("Boston Celtics", new DateTime(1993, 11, 02));
            //---------------------------------------------------------------------------

            //Prueba futbol carga valores falsos
            Console.WriteLine("\n\n------------------------------------------");
            Console.WriteLine("Prueba basquet carga valores falsos, tendria que tirar lo mismo que antes");
            Console.WriteLine("------------------------------------------\n\n");
            Console.WriteLine(nbaProms.Mostrar());

            Console.ReadKey();
            Console.Clear();

            //pruebas partidos resultados futbol
            Console.WriteLine("\n\n------------------------------------------");
            Console.WriteLine("Partidos de futbol, no tenddria que figurar ningun equipo jugando contra el mismo..");
            Console.WriteLine("------------------------------------------\n\n");
            Console.WriteLine(champions.Jugar);
            Console.WriteLine(champions.Jugar);
            Console.WriteLine(champions.Jugar);

            Console.ReadKey();
            Console.Clear();

            //pruebas partidos resultados basquet
            Console.WriteLine("\n\n------------------------------------------");
            Console.WriteLine("Partidos de basquet, no tenddria que figurar ningun equipo jugando contra el mismo..");
            Console.WriteLine("------------------------------------------\n\n");
            Console.WriteLine(nbaProms.Jugar);
            Console.WriteLine(nbaProms.Jugar);
            Console.WriteLine(nbaProms.Jugar);


            Console.WriteLine($"\n\nFin del programa!!");
            Console.ReadKey();
        }
    }
}
