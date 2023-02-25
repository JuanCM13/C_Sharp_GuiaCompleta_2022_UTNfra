using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase_Interfaces_Vehiculos_Entidades
{
    public class Carreta : Vehiculo
    {
        public Carreta(Double precio)
            :base(precio)
        {}

        public override void MostrarPrecio()
        {
            Console.WriteLine($"Precio: {base._precio}");
        }
    }
}
