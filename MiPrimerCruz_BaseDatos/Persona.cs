using System;

namespace MiPrimerCruz_BaseDatos
{
    public class Persona
    {
        public Int32 id;
        public String nombre;
        public String apellido;

        public Int32 ID
        {
            get { return this.id; }
        }

        public String Nombre
        {
            get { return this.nombre; }
        }

        public String Apellido
        {
            get { return this.apellido; }
        }

        public Persona(String nombre , String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(String nombre, String apellido, Int32 id)
            :this(nombre,apellido)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\nId: " + this.id;
        }
    }
}
