using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer52_TestDriven
{
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException()
            :this("Error, no se aceptan negativos..")
        { }
        public NegativoNoPermitidoException(String mensaje)
            :base(mensaje)
        { }
    }
}
