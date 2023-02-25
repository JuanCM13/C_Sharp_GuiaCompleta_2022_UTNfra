using System;
using System.Text;
using ExcepcionesEjer1;

namespace ejerci51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer51";

            try
            {
                OtraClase otrC = new OtraClase();
                otrC.MetodoInstancia();
            }
            catch(MiExcepcion ex)
            {
                Exception aux = ex;
                StringBuilder msje = new StringBuilder();
                
                while( !(aux.InnerException is null) )
                {
                    msje.AppendLine(aux.InnerException.Message);
                    aux = aux.InnerException;
                }
                msje.AppendLine(aux.Message);
                Console.WriteLine(msje.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Excepcion no controlada!!");
                Console.WriteLine($"\n{ex.Message}");
            }
            finally
            {
                Console.WriteLine("Entre al bloque finally");
            }

            Console.WriteLine("Termino la app...");
            
            Console.ReadKey();
        }
    }
}
