using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase_Interfaces_Vehiculos_Entidades
{
    public class Privado : Avion
    {
        protected Int32 _valorServicioDeAbordo;

        public Privado(Double precio , Double velocidad , Int32 valor)
            :base(precio , velocidad)
        {
            this._valorServicioDeAbordo = valor;
        }
    }
}
