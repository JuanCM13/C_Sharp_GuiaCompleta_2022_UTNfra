using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simulador_AtencionCliente
{
    public class Caja             
    {
        private static Random rand;
        private Queue<String> clientesALaEspera;
        private String nombreCaja;
        private Action<Caja, String> delegadoClienteAtendido;

        public String NombreCaja
        {
            get { return this.nombreCaja; }
        }

        public Int32 CantidadDeClientesALaEspera
        {
            get { return clientesALaEspera.Count; }
        }

        static Caja()
        {
            Caja.rand = new Random();
        }

        public Caja(String nombre , Action<Caja , String> delegado)
        {
            this.nombreCaja = nombre;
            this.delegadoClienteAtendido = delegado;
            this.clientesALaEspera = new Queue<string>();
        }

        internal void AgregarCliente(String clien)
        {
            if(!String.IsNullOrWhiteSpace(clien))
            {
                this.clientesALaEspera.Enqueue(clien);
            }            
        }

        internal Task IniciarAtencion()
        {
        }

    }
}
