using System;
using EnciendanSusMotores_4._0;

namespace ejer61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer54 Competencia Vehiculos con excepciones";

            Console.Title = "Ejer40";
            Competencia<AutoF1> c1 = new Competencia<AutoF1>(5, 10, TipoCompetencia.F1);
            Competencia<MotoCross> c2 = new Competencia<MotoCross>(5, 10, TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(1, "Ferrari", 600);
            AutoF1 a2 = new AutoF1(2, "Aston", 800);
            AutoF1 a3 = new AutoF1(3, "Renault");
            AutoF1 a4 = new AutoF1(1, "Ferrari", 600);
            AutoF1 a5 = new AutoF1(4, "Red Bull", 450);
            MotoCross m1 = new MotoCross(1, "Yamaha", 500);
            MotoCross m2 = new MotoCross(2, "Honda");
            MotoCross m3 = new MotoCross(3, "Husquevarna", 200);

            //el try catch ya estaria al dope por que solucione con el generic el tema de 
            //agregar un vehiculo distinto a una lista pero bue, lo dejo por si tira alguna
            //otra excep.
            try
            {
                bool aux = c1 + a1;
                aux = c1 + null;
                aux = c1 + a2;
                aux = c1 + a2;
                aux = c1 + a3;
                aux = c1 + a4;
                aux = c1 + a5;
                aux = c2 + m1;
                aux = c2 + m2;
                aux = c2 + m3;
                aux = c2 + m1;

                //aux = c2 + a1;
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("\n\n");
                Console.WriteLine("Se logro cargar la siguiente info: \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion no controlada: \n");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(c1.MostrarDatos());
            Console.WriteLine(c2.MostrarDatos());

            Console.ReadKey();
        }
    }
}
