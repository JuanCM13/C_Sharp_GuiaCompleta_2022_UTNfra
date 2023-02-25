using System;
using System.Text;
namespace ejercicioClaseGenerics
{
    public class Juguete
    {
        private String nombre;
        private Double precio;
    
        public Juguete(String nombre, Double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        private String Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Nombre: {this.nombre} -- Precio: {this.precio}");
            return str.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
