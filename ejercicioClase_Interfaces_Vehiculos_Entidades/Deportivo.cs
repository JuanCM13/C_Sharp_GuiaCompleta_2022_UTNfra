using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase_Interfaces_Vehiculos_Entidades
{
    public class Deportivo : Auto , IAfip
    {
        protected Int32 _caballosFuerza;

        public Deportivo(Double precio , String patente , Int32 caballos)
            :base(precio , patente)
        {
            this._caballosFuerza = caballos;
        }

        Double IAfip.CalcularImpuesto()
        {
            return (base._precio * 28) / 100;
        }

        public override void MostrarPrecio()
        {
            Double auxPrecio = base._precio + ((IAfip)this).CalcularImpuesto();
            Console.WriteLine($"Precio auto deportivo con impuesto: {auxPrecio} , Impuesto del 33%: {(((IAfip)this).CalcularImpuesto())}");
        }
    }
}
