using System;

namespace SobreescritoEjemploEjer48
{
    public abstract class SobreEscrito
    {
        protected String miAtributo;
        /*Agregar a la clase Sobrescrito un atributo miAtributo del tipo string, con visibilidad protected.
        Generar un constructor de instancia que inicialice miAtributo con el valor "Probar abstractos".
        Agregará propiedad abstracta MiPropiedad de sólo lectura. Una vez implementada, retornará el valor de miAtributo.
        Crear un método abstracto MiMetodo que retorne un string. Una vez implementada, retornará el valor de MiPropiedad.
        Agregar una clase llamada SobreSobrescrito que herede de Sobrescrito. Implementar el código necesario para que todo funcione correctamente.
        Modificar el método Main para probar las modificaciones.*/

        public SobreEscrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract String MiPropiedad
        {
            get;
        }

        public abstract String MiMetodo();

        public override string ToString()
        {
            return this.MiPropiedad;
        }

        public override bool Equals(object obj)
        {
            return (obj is SobreEscrito);
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

    }
}
