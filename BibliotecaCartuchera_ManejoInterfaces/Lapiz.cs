using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCartuchera_ManejoInterfaces
{
    public class Lapiz : UtilesEscolares , IAcciones
    {
        private Single tamanioMina;

        public Lapiz(Int32 unidades)
        {
            this.UnidadesDeEscritura = unidades;
        }
        public ConsoleColor Color 
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Single UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            String mensajeRetorno = "No se pudo escribir, tinta insuficiente..";

            if(!String.IsNullOrEmpty(texto))
            {
                this.UnidadesDeEscritura -= texto.Length * 0.1F;
            }
            
            if(this.tamanioMina > -1)
            {
                mensajeRetorno = texto;
            }

            return new EscrituraWrapper(mensajeRetorno, this.Color);
        }

        public bool Recargar(Int32 cant)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder str = new();

            str.AppendLine($"Lapiz: Cantidad Mina: {this.UnidadesDeEscritura} -- Color: {this.Color}");
            return str.ToString();
        }
    }
}
