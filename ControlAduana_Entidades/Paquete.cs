using System;
using System.Text;

namespace ControlAduana_Entidades
{
    public abstract class Paquete : IAduana
    {
        private String codigoSeguimiento;
        protected Decimal costoEnvio;
        private String destino;
        private String origen;
        private Double pesoKg;

        public abstract bool TienePrioridad { get; }

        protected Paquete(String codigoSeg , Decimal costoEnv , String destino , String origen , Double pesoKg)
        {
            this.codigoSeguimiento = codigoSeg;
            this.costoEnvio = costoEnv;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public String ObtenerInformacionDePaquete()
        {
            StringBuilder str = new StringBuilder();

            String aux = this.TienePrioridad ? "El Paquete Tiene Prioridad.." : "El Paquete No Tiene Prioridad..";
            
            str.AppendLine($"Codigo de Seguimiento: {this.codigoSeguimiento}\nCosto de Envio: {this.costoEnvio}\n" +
                $"Destino: {this.destino}\nOrigen: {this.origen}\nPeso en KiloGramos: {this.pesoKg}\n{aux}");

            return str.ToString();
        }

        public Decimal Impuestos
        {
            get
            {
                return (this.costoEnvio * ((Decimal)35)) / 100;
            }
        }

        public virtual Decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos;
        }


    }
}
