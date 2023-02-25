using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsContabilidad_Biblioteca
{
    public class Contabilidad<T,U>
        where T : Documento
        where U : Documento,new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new();
            this.ingresos = new();
        }
        
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> coun , T egreso)
        {
            if(!(coun is null) && !(egreso is null))
            {
                coun.egresos.Add(egreso);
            }
            return coun;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> coun, U ingreso)
        {
            if (!(coun is null) && !(ingreso is null))
            {
                coun.ingresos.Add(ingreso);
            }
            return coun;
        }

        public override string ToString()
        {
            return new StringBuilder().AppendLine($"Listado Egresos: \n{this.GenerateData(1)}\nListado Ingresos: \n{this.GenerateData(2)}").ToString();
        }

        private String GenerateData(Int32 lista)
        {
            StringBuilder str = new StringBuilder();

            if(lista > 0 && lista < 3)
            {
                switch(lista)
                {
                    case 1:
                        if (this.egresos.Count > 0)
                        {
                            foreach(T data in this.egresos)
                            {
                                str.AppendLine($"Numero Documento: {data.NumeroDoc}");
                            }
                        }
                        else
                        {
                            str.AppendLine("Lista vacia..");
                        }
                        break;
                    case 2:
                        if (this.ingresos.Count > 0)
                        {
                            foreach (U data in this.ingresos)
                            {
                                str.AppendLine($"Numero Documento: {data.NumeroDoc}");
                            }
                        }
                        else
                        {
                            str.AppendLine("Lista vacia..");
                        }
                        break;
                }
            }
            return str.ToString();
        }

    }
}
