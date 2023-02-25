using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Generics_Parte3_Entidades
{
    public class Cocina
    {
        private Int32 _codigo;
        private bool _esIndustrial;
        private Double _precio;

        public Cocina(Int32 codigo, Double precio, bool esInd)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esInd;
        }

        public Int32 Codigo
        {
            get { return this._codigo; }
        }

        public bool EsIndustrial
        {
            get { return this._esIndustrial; }
        }

        public Double Precio
        {
            get { return this._precio; }
        }

        public static bool operator ==(Cocina c1, Cocina c2)
        {
            bool ret = false;
            if (!(c1 is null) && !(c2 is null))
            {
                if (c1.Codigo == c2.Codigo)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Cocina c1, Cocina c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Cocina)
            {
                ret = this == ((Cocina)obj);
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder str = new();

            String aux = this.EsIndustrial ? "Es industrial" : "No es industrial";

            str.AppendLine($"Cocina Codigo: {this.Codigo} -- {aux} -- Precio Cocina: {this.Precio}");
            return str.ToString();
        }
    }
}
