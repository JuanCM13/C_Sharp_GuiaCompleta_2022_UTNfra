using System;

using SobreescritoEjemploEjer48;

namespace Ejer48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            SobreSobreEscrito objetoSobrescrito = new SobreSobreEscrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.ReadKey();
        }
    }
}
