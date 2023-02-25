using System;

namespace ejercicioClase_Interfaces_Vehiculos_Entidades
{
    public abstract class Vehiculo
    {
        protected Double _precio;

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }

        public abstract void MostrarPrecio();

    }
}
