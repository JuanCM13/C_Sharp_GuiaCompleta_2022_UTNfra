using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase_Interfaces_Vehiculos_Entidades
{
    public class Avion : Vehiculo , IAfip
    {
        protected Double _velocidadMaxima;

        public Avion(Double precio, Double velocidad)
            :base(precio)
        {
            this._velocidadMaxima = velocidad;
        }

        public Double CalcularImpuesto()
        {
            return (base._precio * 33) / 100;
        }

        public override void MostrarPrecio()
        {
            Double precioFinal = base._precio + this.CalcularImpuesto();
            Console.WriteLine($"Precio avion con impuesto: {precioFinal} , Impuesto del 33%: {this.CalcularImpuesto()}");
        }

    }
}
