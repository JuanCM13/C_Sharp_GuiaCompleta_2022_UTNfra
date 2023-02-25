using System;

namespace EstoNoEsSteam_Entidades
{
    public class Juego
    {
        private Int32 codigoJuego;  
        private Int32 codigoUsuario;
        private string genero;
        private string nombre;
        private double precio;

        public Juego(String nombre, Double precio, String genero, Int32 codigoUsuario)
        {
            this.genero = genero;
            this.precio = precio;
            this.nombre = nombre;
            this.codigoUsuario = codigoUsuario;
        }

        public Juego(String nombre , Double precio , String genero , Int32 codigoJuego , Int32 codigoUsuario)
            :this(nombre,precio,genero,codigoUsuario)
        {
            this.codigoJuego = codigoJuego; 
        }

        public Int32 CodigoJuego
        {
            get { return this.codigoJuego; }
        }

        public Int32 CodigoUsuario
        {
            get { return this.codigoUsuario; }
        }

        public String Genero
        {
            get { return this.genero; }
        }

        public String Nombre
        {
            get { return this.nombre; }
        }

        public Double Precio
        {
            get { return this.precio; }
        }
                
    }
}
