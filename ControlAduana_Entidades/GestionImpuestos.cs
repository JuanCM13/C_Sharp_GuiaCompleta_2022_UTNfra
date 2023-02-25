using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAduana_Entidades
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new();
            this.impuestosAfip = new();
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);
            if(paquete is PaquetePesado)
            {
                this.impuestosAfip.Add(((PaquetePesado)paquete));
            }
        }

        public void RegistrarImpuestos(List<Paquete> paquetes)
        {
            if(!(paquetes is null))
            {
                foreach(Paquete paq in paquetes)
                {
                    this.RegistrarImpuestos(paq);
                }
            }
        }

        public Decimal CalcularTotalImpuestosAduana()
        {
            Decimal retorno = 0;

            foreach(Paquete item in this.impuestosAduana)
            {
                retorno += item.Impuestos;
            }

            return retorno;
        }

        public Decimal CalcularTotalImpuestosAfip()
        {
            Decimal retorno = 0;

            foreach (Paquete item in this.impuestosAfip)
            {
                retorno += ((IAfip)item).Impuestos;
            }

            return retorno;
        }
    }
}
