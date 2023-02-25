using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Generics_Parte1_Entidades
{
    public class DepositoDeAutos
    {
        private Int32 _capacidad;
        private List<Auto> _autos;

        public DepositoDeAutos(Int32 capacidad)
        {
            this._autos = new();
            this._capacidad = capacidad;
        }

        public static bool operator +(DepositoDeAutos d , Auto a)
        {
            bool ret = false;
            if(!(d is null) && !(a is null))
            {
                if(d._autos.Count < d._capacidad)
                {
                    d._autos.Add(a);
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator -(DepositoDeAutos d , Auto a)
        {
            bool ret = false;
            Int32 index;
            if(!(d is null) && !(a is null))
            {
                index = d.GetIndice(a);
                if (index > -1)
                {
                    d._autos.RemoveAt(index);
                    ret = true;
                }
            }
            return ret;
        }

        private Int32 GetIndice(Auto a)
        {
            Int32 ret = -1;
            Int32 counter;
            if(!(a is null))
            {
                counter = 0;
                foreach(Auto item in this._autos)
                {
                    if(item.Equals(a))
                    {
                        ret = counter;
                        break;
                    }
                    counter++;
                }
            }
            return ret;
        }

        public bool Agregar(Auto a1)
        {
            return this + a1;
        }

        public bool Remover(Auto a1)
        {
            return this - a1;
        }

        public override string ToString()
        {
            StringBuilder str = new();
            str.AppendLine($"La capacidad del deposito es de: {this._capacidad}");
            str.AppendLine("-------------------------------------------------------");
            str.AppendLine("                        AUTOS");  
            str.AppendLine("-------------------------------------------------------\n");
            
            if (this._autos.Count > 0)
            {
                foreach(Auto a in this._autos)
                {
                    str.Append($"-{a.ToString()}");
                }
            }
            else
            {
                str.AppendLine("Sin autos al momento..");
            }
            return str.ToString();
        }
    }
}
