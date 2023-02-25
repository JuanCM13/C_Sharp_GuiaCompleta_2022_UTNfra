using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesEjer1
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                new MiClasee();
            }
            catch(UnaExcepcion ex)
            {
                throw new MiExcepcion("Excepcion de tipo MiExcepcion!", ex);
            }
        }
    }
}
