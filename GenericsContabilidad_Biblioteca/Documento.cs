using System;

namespace GenericsContabilidad_Biblioteca
{
    public abstract class Documento
    {
        private Int32 numero;

        public Documento(Int32 num)
        {
            this.numero = num;
        }

        public Int32 NumeroDoc
        {
            get { return this.numero; }
        }
    }
}
