using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer52
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException()
           : this("Excepcion no controlada de tipo: ParametrosVacios")
        {}

        public ParametrosVaciosException(String mensaje)
            :base(mensaje)
        {}

        public ParametrosVaciosException(String mensaje , Exception ex)
            : base(mensaje , ex)
        { }

        public override string ToString()
        {
            return this.Message;
        }

    }
}
