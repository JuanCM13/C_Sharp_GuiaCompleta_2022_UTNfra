using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCartuchera_ManejoInterfaces
{
    public class EscrituraWrapper
    {
        public String texto;
        public ConsoleColor color;

        public EscrituraWrapper(String texto , ConsoleColor color)
        {
            this.texto = texto;
            this.color = color;
        }
    }
}
