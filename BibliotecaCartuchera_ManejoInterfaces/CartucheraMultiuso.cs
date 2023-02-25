using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCartuchera_ManejoInterfaces
{
    public class CartucheraMultiuso
    {
        private List<IAcciones> lista;

        public CartucheraMultiuso()
        {
            this.lista = new();
        }

        public bool RecorrerElementos()
        {
            bool ret = false;
            if(!(this.lista is null) && this.lista.Count > 0)
            {
                ret = true;
                foreach (IAcciones item in lista)
                {
                    if (item.UnidadesDeEscritura > 0)
                    {
                        item.Escribir("-");
                    }
                    else
                    {
                        ret = false;
                        break;
                    }
                }
            }            
            return ret;
        }
    }
}
