using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_JuanCruz
{
    public class ClaseConEvento
    {
        public static event Action<String> Evento;

        public override string ToString()
        {
            Evento.Invoke("Invocado");
            return "";
        }
    }
}
