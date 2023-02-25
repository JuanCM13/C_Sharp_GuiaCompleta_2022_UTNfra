using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAduana_Entidades
{
    public interface IAfip
    {
        public Decimal Impuestos { get; }
        public Decimal AplicarImpuestos();
    }
}
