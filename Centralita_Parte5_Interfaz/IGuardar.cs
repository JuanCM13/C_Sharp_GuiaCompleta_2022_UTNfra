using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Parte5_Interfaz
{
    public interface IGuardar<T>
    {
        String RutaDeArchivo { get; set; }

        bool Guardar();

        T Leer();
    }
}
