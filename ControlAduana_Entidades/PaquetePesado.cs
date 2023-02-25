using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAduana_Entidades
{
    public class PaquetePesado : Paquete , IAfip
    {
        public PaquetePesado(String codigoSeguimiento, Decimal costoEnvio, String destino, String origen, Double peso)
            : base(codigoSeguimiento, costoEnvio, destino, origen, peso)
        { }

        public override bool TienePrioridad
        {
            get { return false; }
        }

        Decimal IAfip.Impuestos
        {
            get { return (this.costoEnvio * 25) / 100; }
        }

        public override decimal AplicarImpuestos()
        {
            return base.AplicarImpuestos() + ((IAfip)this).Impuestos; //casteo sino llama a la implicita del base
        }

    }
}
