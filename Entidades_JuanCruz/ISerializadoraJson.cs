using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_JuanCruz
{
    public interface ISerializadoraJson
    {
        bool SerializarJson(string nombreArchivo);

        bool DeserializarJson(string nombreArchivo, out ClaseNormalita clase);

    }
}
