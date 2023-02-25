using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescritoEjemploEjer48
{
    public class SobreSobreEscrito : SobreEscrito
    {
        public SobreSobreEscrito()
            :base()
        { }

        public override string MiPropiedad
        {
            get { return this.miAtributo; }
        }

        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }
    }
}
