using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Generics_Parte3_Entidades
{
    public class Deposito<T>
    {
        private Int32 _capacidadMaxima;
        private List<T> _lista;

        public Deposito(Int32 capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new();
        }

        public static bool operator +(Deposito<T> d , T item)
        {
            bool ret = false;
            if(!(d is null) && !(item is null))
            {
                if(d._lista.Count < d._capacidadMaxima)
                {
                    d._lista.Add(item);
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator -(Deposito<T> d, T item)
        {
            bool ret = false;
            Int32 indice;

            if (!(d is null) && !(item is null))
            {
                indice = d.GetIndice(item);
                if(indice > -1)
                {
                    d._lista.RemoveAt(indice);
                    ret = true;
                }
            }
            return ret;
        }

        private Int32 GetIndice(T item)
        {
            Int32 ret = -1;
            Int32 counter;

            if(!(item is null))
            {
                counter = 0;
                foreach(T cosa in this._lista)
                {
                    if(cosa.Equals(item))
                    {
                        ret = counter;
                        break;
                    }
                    counter++;
                }
            }
            return ret;
        }

        public bool Agregar(T item)
        {
            return this + item;
        }

        public bool Remover(T item)
        {
            return this - item;
        }

        public override string ToString()
        {
            StringBuilder str = new();
            //aca para saber el nombre de la clase de la lista, selecciono algun elemento de la lista
            //y en un string aux guardo el getType.Name de ese objeto, total se que toda la lista
            //esta compuesta por 1 solo tipo..
            T obj = this._lista.FirstOrDefault();
            String nombreClaseItem = obj.GetType().Name;
            str.AppendLine($"La capacidad del deposito es de: {this._capacidadMaxima}");
            str.AppendLine($"Listado de: {nombreClaseItem}s");

            if (this._lista.Count > 0)
            {
                foreach (T item in this._lista)
                {
                    str.Append($"-{item.ToString()}"); //aca va a llamarme por polimorfismo a el to string del tipo que seleccione al asignar
                }                                       //asi que ojaldre..
            }
            else
            {
                str.AppendLine("Sin items al momento..");
            }
            return str.ToString();
        }
    }
}
