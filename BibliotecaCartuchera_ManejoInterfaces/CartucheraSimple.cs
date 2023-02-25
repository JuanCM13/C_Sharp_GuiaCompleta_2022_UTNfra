using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCartuchera_ManejoInterfaces
{
    public class CartucheraSimple
    {
        private List<Lapiz> lapices;
        private List<Boligrafo> bolis;

        public CartucheraSimple()
        {
            this.lapices = new();
            this.bolis = new();
        }

        public static CartucheraSimple operator +(CartucheraSimple c , Lapiz l)
        {
            if(!(c is null) && !(l is null))
            {
                c.lapices.Add(l);
            }
            return c;
        }

        public static CartucheraSimple operator +(CartucheraSimple c, Boligrafo b)
        {
            if (!(c is null) && !(b is null))
            {
                c.bolis.Add(b);
            }
            return c;
        }
        public bool Recorrer()
        {
            bool ret = false;
            bool ret2 = false;
            if(!(this.lapices is null))
            {
                ret2 = true;
                foreach (Lapiz item in this.lapices)
                {
                    if(item.UnidadesDeEscritura > 0)
                    {
                        item.Escribir("-");
                    }
                    else
                    {
                        ret2 = false;
                        break;
                    }
                }
            }

            if (ret2 && !(this.bolis is null))
            {
                ret2 = true;
                foreach (Boligrafo item in this.bolis)
                {
                    if (item.UnidadesDeEscritura > 0)
                    {
                        item.Escribir("-");
                    }
                    else
                    {
                        ret2 = false;
                        break;
                    }
                }
            }

            if(ret2)
            {
                ret = true;
            }

            return ret;
        }


    }
}
