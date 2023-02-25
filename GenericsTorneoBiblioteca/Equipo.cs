using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTorneoBiblioteca
{
    public abstract class Equipo
    {
        private String nombre;
        private DateTime fecha;

        public String Nombre
        {
            get { return this.nombre; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
        }

        public Equipo(String nombre , DateTime fecha)
        {
            this.fecha = fecha;
            this.nombre = nombre;
        }

        public Equipo()
            :this("Sin asignar" , DateTime.Now)
        {}

        public static bool operator ==(Equipo e1 , Equipo e2)
        {
            bool ret = false;
            if(!(e1 is null) && !(e2 is null))
            {
                if(e1.nombre == e2.nombre && e1.fecha == e2.fecha)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public String Ficha()
        {
            StringBuilder str = new();

            str.Append($"[{this.nombre}] fundado el [{this.fecha.ToShortDateString()}]");

            return str.ToString();
        }
    }
}
