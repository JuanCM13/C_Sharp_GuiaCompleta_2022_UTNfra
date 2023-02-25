using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoNoEsSteam_Entidades
{
    public class Biblioteca
    {
        private Int32 codigoJuego;
        private String genero;
        private String juego;
        private String usuario;

        public Int32 CodigoJuego
        {
            get { return this.codigoJuego; }
        }

        public String Genero
        {
            get { return this.genero; }
        }

        public String Juego
        {
            get { return this.juego; }
        }

        public String Usuario
        {
            get { return this.usuario; }
        }

        public Biblioteca(String usuario,String genero,String juego,Int32 codigoJuego)
        {
            this.codigoJuego = codigoJuego;
            this.juego = juego;
            this.genero = genero;
            this.usuario = usuario;
        }
    }
}
