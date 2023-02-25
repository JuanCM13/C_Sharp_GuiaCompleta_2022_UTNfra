using System;
using Figuras;
using System.Collections.Generic;
using System.Text;

namespace ejer49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer49";
            List<Figura> figuras = new List<Figura>();
            Cuadrado cua = new Cuadrado(10, 10);
            Rectangulo rec = new Rectangulo(10, 15);
            Circulo cir = new Circulo(7.6F);
            Int32 counter = 0;
            StringBuilder str = new StringBuilder();

            figuras.Add(cua);
            figuras.Add(rec);
            figuras.Add(cir);

            foreach (Figura item in figuras)
            {
                counter++;
                str.AppendLine($"=============== FIGURA {counter} ==================");
                str.AppendLine($"TIPO: {item.GetType()}");
                str.AppendLine($"{item.Dibujar()}");
                str.AppendLine($"Area: {item.CalcularSuperficie()}");
                str.AppendLine($"Perimetro: {item.CalcularPerimetro()}");
                str.AppendLine($"============================================");
            }

            Console.WriteLine(str); //automaticamente llama al toString de ese objeto...
            Console.ReadKey();
            /*Respuestas preguntas:
             *  ¿Por qué la clase Cuadrado no está obligada a implementar el método Dibujar? ¿Las otras clases están obligadas a hacerlo?
                ¿Por qué la clase Cuadrado no está obligada a implementar el método CalcularSuperficie? ¿Las otras clases están obligadas a hacerlo?
                ¿A qué implementación del método CalcularPerimetro llaman los objetos de tipo Cuadrado?
             * 
             * -La clase cuadrado no esta obligada a implementar el metodo dibujar, ya que no es la primer clase que deriva de una abstracta
             * osea, como ya rectangulo sobreescribio el metodo declarado abstracto de la clase figura, y rectangulo no es abstracta
             * por lo tanto no define ningun metodo como abstracto, cuadrado no esta obligada a declarar esos metodos abstractos 
             * definidos en la clase figura, ya que la primer clase no abstracta es la primera que esta obligada a implementar
             * el metodo abstracto. Las demas pueden pero no estan obligadas..
             
             -No esta obligada por lo anteriormente dicho, aparte, al tener las mismas formulas que la clase rectangulo,
            es redundante hacerlo, repetiria codigo al pedo que puedo adaptar desde la clase rectangulo... Las demas
            como heredan directamente de una clase abstracta y estas no fueron declaradas como tal, estan obligadas a
            declarar los metodos y propiedades abstractos.

            -Llaman a la implementacion de su clase padre, en este caso a los metodos de rectangulo, ya que es su clase
            padre o base.
             */
        }
    }
}
