using System;
using System.Text;
using System.Collections.Generic;

namespace GenericsTorneoBiblioteca
{
    public class Torneo<T> where T:Equipo
    {
        private List<T> equipos;
        private String nombre;
        private static Random rand;


        public String Jugar
        {
            get 
            {
                Int32 limite = this.equipos.Count;
                Int32 indexUno;
                Int32 indexDos;
                String ret = "Al menos debe haber 2 equipos cargados!!\n";

                if(limite > 1)
                {
                    indexUno = Torneo<T>.rand.Next(0, limite);
                    do
                    {
                        indexDos = Torneo<T>.rand.Next(0, limite);
                    } while (indexDos == indexUno);

                    ret = this.CalcularPartido(this.equipos[indexUno], this.equipos[indexDos]);
                }

                return ret;
            }
        }

        static Torneo()
        {
            Torneo<T>.rand = new Random();
        }

        private Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(String nomb) : this()
        {
            this.nombre = nomb;
        }

        public static bool operator ==(Torneo<T> torn , T item)
        {
            bool ret = false;
            if(!(torn is null) && !(item is null))
            {
                foreach(T dato in torn.equipos)
                {
                    if(dato == item)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Torneo<T> torn, T item)
        {
            return !(torn == item);
        }

        public static Torneo<T> operator +(Torneo<T> torn , T item)
        {
            if (!(torn is null) && !(item is null))
            {
                if(torn != item)
                {
                    torn.equipos.Add(item);
                }
            }
            return torn;
        }

        public String Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Nombre del torneo: {this.nombre}");
            if(this.equipos.Count > 0)
            {
                foreach(T dato in this.equipos)
                {
                    str.AppendLine(dato.Ficha());
                }
            }
            else
            {
                str.AppendLine("--Sin equipos al momento--");
            }
            return str.ToString();
        }

        //private String CalcularPartido<U>(U el1 , U el2) where U : T //asi lo podria declarar pero es medio al dope
        private String CalcularPartido(T e1 , T e2)
        {
            StringBuilder str = new();
            if(!(e1 is null) && !(e2 is null))
            {
                str.Append($"[{e1.Nombre}][Resultado: {Torneo<T>.rand.Next(1, 50)}]");
                str.AppendLine($" - [{e2.Nombre}][Resultado: {Torneo<T>.rand.Next(1, 50)}]");
            }
            else
            {
                str.AppendLine("Uno de los equipos o ambos vinieron nulls!!");
            }
            return str.ToString();
        }
    }
}
