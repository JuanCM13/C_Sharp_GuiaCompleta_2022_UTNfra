using System;
using GenericsContabilidad_Biblioteca;

namespace ejer60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer60";

            Contabilidad<Factura, Recibo> cont = new();
            cont += new Factura(150);
            cont += new Factura(151);
            cont += new Factura(152);
            cont += new Recibo(153);
            cont += new Recibo(154);
            cont += new Recibo(155);

            Console.WriteLine(cont);

            Console.ReadKey();
        }
    }
}
