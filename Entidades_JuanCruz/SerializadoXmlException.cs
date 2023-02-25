using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_JuanCruz
{
    public class SerializadoXmlException : Exception
    {
        public SerializadoXmlException()
            : this("Error al Serializar/Deserializar en .xml")
        {}

        public SerializadoXmlException(String mensaje)
            : this(mensaje , null)
        {}

        public SerializadoXmlException(String mensaje , Exception inner)
            : base(mensaje, inner)
        { }
    }
}
