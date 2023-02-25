using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase_Interfaces_Vehiculos_Entidades
{
    public abstract class Auto : Vehiculo
    {
        protected String _patente;

        public Auto(Double precio , String patente)
            :base(precio)
        {
            this._patente = patente;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine($"Precio: {this._precio}");
        }
    }
}
