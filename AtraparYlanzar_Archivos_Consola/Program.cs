using System;
using ExcepcionesEjer1;
using IO;

namespace AtraparYlanzar_Archivos_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            String dato = String.Empty;
            try
            {
                OtraClase otrC = new OtraClase();
                otrC.MetodoInstancia();
            }
            catch (Exception ex)
            {
                try
                {
                    dato = DateTime.Now.ToString("yyyy/dd/mm");
                    ArchivoDeTextoa.Guardar(dato, ex.Message);
                }                
                catch(Exception ox)
                {
                    Console.WriteLine($"Error critico\n{ox.Message}");
                }
            }

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                         RESULTADOS:");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine(ArchivoDeTextoa.Leer(dato));

            Console.ReadKey();
        }
    }
}
