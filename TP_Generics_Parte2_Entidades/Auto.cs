using System;
using System.Text;

namespace TP_Generics_Parte2_Entidades
{
    public class Auto
    {
        private String _color;
        private String _marca;

        public String Color
        {
            get { return this._color; }
        }

        public String Marca
        {
            get { return this._marca; }
        }

        public Auto(String color, String marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Auto)
            {
                ret = this == ((Auto)obj);
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder str = new();
            str.AppendLine($"Color Auto: {this.Color} -- Marca Auto: {this.Marca}");
            return str.ToString();
        }

        public static bool operator ==(Auto a1, Auto a2)
        {
            bool ret = false;
            if (!(a1 is null) && !(a2 is null))
            {
                if (a1.Marca == a2.Marca && a1.Color == a2.Color)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Auto a1, Auto a2)
        {
            return !(a1 == a2);
        }
    }
}
