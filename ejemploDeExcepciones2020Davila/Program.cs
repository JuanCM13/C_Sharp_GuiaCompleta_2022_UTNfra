using System;

namespace ejemploDeExcepciones2020Davila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EjemploDavilaExcepciones";

            /*Ejemplo con excepcion de dividir por cero*/

            try
            {
                Console.WriteLine("Empezp el programaaa");
                Double ret = Program.Prueba(10, 0);
                Console.WriteLine("Ya dividi");
            }                          
            catch(Exception ex)
            {
                Console.WriteLine("Maneje la excepcion aca tambien" , ex.Message);
            }

        }

        public static double Prueba(Int32 dato1 , Int32 dato2)
        {
            double ret = 0;
            try
            {
                ret = dato1 / dato2;
            }
            catch(DivideByZeroException ex)  //son objetos, heredan de exception, puedo guardarla con un nombre
            {                               //en una var auxiliar, y luego acceder a sus atributos y metodos con el .

                Console.WriteLine(ex.Message); //.messege, devuelve el mensaje de error de la excepcion, el predeterminado
                                               //de fabrica            
                //throw;  
            }
            return ret;
            //vuelve a tirar la excepcion, onda primero en este catch la manejo y despues la relanzo osea crearia otra
            //por si necesito que se haga otra cosa con esta, va a arrancar a desapilar el stacktrace hasta encontrar
        }               //un catch adecuado, sino llega hasta el main y ahi ya rompe..
    }
}
