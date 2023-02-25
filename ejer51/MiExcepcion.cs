using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesEjer1
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion()
            : base("Excepcion de tipo, MiExcepcion")
        { }

        public MiExcepcion(string message)
            : base(message)
        { }

        public MiExcepcion(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
