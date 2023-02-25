using System;
using System.Text;

namespace BibliotecaCartuchera_ManejoInterfaces
{
    public class Boligrafo : UtilesEscolares , IAcciones
    {
        private ConsoleColor colorTinta;
        private Single tinta;

        public Boligrafo(Single tinta , ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = tinta;
        }
        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public Single UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            String mensajeRetorno = "No se pudo escribir, tinta insuficiente..";

            if (!String.IsNullOrEmpty(texto))
            {
                this.UnidadesDeEscritura -= texto.Length * 0.3F;
            }

            if (this.tinta > -1)
            {
                mensajeRetorno = texto;
            }

            return new EscrituraWrapper(mensajeRetorno, this.Color);
        }

        public bool Recargar(Int32 cant)
        {
            this.UnidadesDeEscritura = cant;
            return true;
        }

        public override string ToString()
        {
            StringBuilder str = new();

            str.AppendLine($"Boligrafo: Cantidad Tinta: {this.UnidadesDeEscritura} -- Color: {this.Color}");
            return str.ToString();
        }
    }
}
