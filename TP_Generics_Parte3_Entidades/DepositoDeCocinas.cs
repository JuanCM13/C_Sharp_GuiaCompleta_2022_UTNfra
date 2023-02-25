using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Generics_Parte3_Entidades
{
    public class DepositoDeCocinas
    {
        private Int32 _capacidad;
        private List<Cocina> _cocinas;

        public DepositoDeCocinas(Int32 capacidad)
        {
            this._cocinas = new();
            this._capacidad = capacidad;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool ret = false;
            if (!(d is null) && !(c is null))
            {
                if (d._cocinas.Count < d._capacidad)
                {
                    d._cocinas.Add(c);
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool ret = false;
            Int32 indice;

            if (!(d is null) && !(c is null))
            {
                indice = d.GetIndice(c);
                if (indice > -1)
                {
                    d._cocinas.RemoveAt(indice);
                    ret = true;
                }
            }
            return ret;
        }

        private Int32 GetIndice(Cocina c)
        {
            Int32 ret = -1;
            Int32 counter;

            if (!(c is null))
            {
                counter = 0;
                foreach (Cocina item in this._cocinas)
                {
                    if (item.Equals(c))
                    {
                        ret = counter;
                        break;
                    }
                    counter++;
                }
            }
            return ret;
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            StringBuilder str = new();
            str.AppendLine($"La capacidad del deposito es de: {this._capacidad}");
            str.AppendLine("-------------------------------------------------------");
            str.AppendLine("                        Cocinas");
            str.AppendLine("-------------------------------------------------------\n");

            if (this._cocinas.Count > 0)
            {
                foreach (Cocina c in this._cocinas)
                {
                    str.Append($"-{c.ToString()}");
                }
            }
            else
            {
                str.AppendLine("Sin Cocinas al momento..");
            }
            return str.ToString();
        }
    }
}
