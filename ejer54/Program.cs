using System;
using EnciendanSusMotores3._0;

namespace ejer54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer54 Competencia Vehiculos con excepciones";

            Console.Title = "Ejer40";
            Competencia c1 = new Competencia(5, 10, TipoCompetencia.F1);
            Competencia c2 = null;
            AutoF1 a1 = new AutoF1(1, "Ferrari", 600);
            AutoF1 a2 = new AutoF1(2, "Aston", 800);
            AutoF1 a3 = new AutoF1(3, "Renault");
            AutoF1 a4 = new AutoF1(1, "Ferrari", 600);
            AutoF1 a5 = new AutoF1(4, "Red Bull", 450);
            MotoCross m1 = new MotoCross(1, "Yamaha", 500);
            MotoCross m2 = new MotoCross(2, "Honda");
            MotoCross m3 = new MotoCross(3, "Husquevarna", 200);

            try
            {
                bool aux = c1 + a1;
                aux = c1 + null;
                aux = c1 + a2;
                aux = c1 + a2;
                aux = c1 + a3;
                aux = c1 + a4;
                aux = c1 + a5;
                aux = c1 + m1;
                aux = c1 + m2;
                aux = c1 + m3;
                aux = c1 + m1;

                aux = c2 + a1;
            }
            catch(CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("\n\n");
                Console.WriteLine("Se logro cargar la siguiente info: \n");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Excepcion no controlada: \n");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(c1.MostrarDatos());


            Console.ReadKey();
        }
    }
}
