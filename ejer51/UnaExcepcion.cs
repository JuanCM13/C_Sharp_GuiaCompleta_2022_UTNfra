using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesEjer1
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion()
            :base()
        {}

        public UnaExcepcion(string message)
            :base(message)
        {}

        public UnaExcepcion(string message, Exception innerException)
            :base(message , innerException)
        {}

        public override string StackTrace
        {
            get
            {
                return base.StackTrace + "\nError,UnaExcepcion..";
            }
        }
    }
}
