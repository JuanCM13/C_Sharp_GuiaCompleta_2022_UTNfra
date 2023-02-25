using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase_Interfaces_Vehiculos_Entidades
{
    public class Familiar : Auto
    {
        protected Int32 _cantidadAsientos;

        public Familiar(Double precio, String patente , Int32 cantAsientos)
            :base(precio , patente)
        {
            this._cantidadAsientos = cantAsientos;
        }
    }
}
