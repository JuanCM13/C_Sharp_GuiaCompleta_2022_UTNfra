using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAduana_Entidades
{
    public class PaqueteFragil : Paquete
    {
        public PaqueteFragil(String codigoSeguimiento , Decimal costoEnvio , String destino , String origen , Double peso)
            :base(codigoSeguimiento , costoEnvio , destino , origen , peso)
        {}

        public override bool TienePrioridad
        {
            get { return true; }
        }
    }
}
