using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_JuanCruz
{
    public interface ISerializadoraXml<T , U>
    {
        bool Serializar(String dato);

        bool Deserializar(String dato, out ClaseGenerica<T, U> generico);
    }
}
