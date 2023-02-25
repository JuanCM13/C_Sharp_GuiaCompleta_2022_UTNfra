using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Parte5_Interfaz
{
    public class FallaLogException : Exception
    {
        public FallaLogException()
            :this("Fallo el Log")
        {}

        public FallaLogException(String msje)
            :this(msje , null)
        {}

        public FallaLogException(String msje, Exception inner)
            :base(msje , inner)
        {}
    }
}
