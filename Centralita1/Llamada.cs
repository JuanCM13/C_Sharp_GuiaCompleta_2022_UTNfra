using System;
using System.Text;
namespace Centralita1
{
    public class Llamada
    {
        protected Single duracion;
        protected String nroDestino;
        protected String nroOrigen;

        public Llamada(Single duracion , String numDes , String numOri)
        {
            this.duracion = duracion;
            this.nroDestino = numDes;
            this.nroOrigen = numOri;
        }

        public Single Duracion
        {
            get { return this.duracion; }
        }

        public String NroDestino
        {
            get { return this.nroDestino; }
        }

        public String NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public static Int32 OrdenarPorDuracion(Llamada l1 , Llamada l2)
        {
            Int32 ret = 0;
            if(!(l1 is null) && !(l2 is null))
            {
                if(l1.duracion > l2.duracion)
                {
                    ret = 1;
                }
                else
                {
                    if(l1.duracion < l2.duracion)
                    {
                        ret = -1;
                    }
                }
            }
            return ret;
        }

        public virtual String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"Duracion Llamada: {this.Duracion}\nNumero Origen: {this.NroOrigen}\nNumero Destino: {this.NroDestino}");

            return str.ToString();
        }
    }
}
