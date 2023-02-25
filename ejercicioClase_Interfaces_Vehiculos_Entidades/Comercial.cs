using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase_Interfaces_Vehiculos_Entidades
{
    public class Comercial : Avion
    {
        protected Int32 _capacidadPasajeros;

        public Comercial(Double precio , Double velocidad , Int32 pasajeros)
            :base(precio , velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }
    }
}
