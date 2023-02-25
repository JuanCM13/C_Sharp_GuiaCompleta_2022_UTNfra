using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCartuchera_ManejoInterfaces
{
    public interface IAcciones
    {
        public ConsoleColor Color { get;set; }
        public Single UnidadesDeEscritura { get; set; }
        public EscrituraWrapper Escribir(String texto);
        public bool Recargar(Int32 unidades);

    }
}
