using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClaseGenerics
{
    public static class Caja<T>
    {
        public static List<T> lista;

        static Caja()
        {
            lista = new List<T>();
        }

        public static List<T> Agregar<G>(G param) where G:T
        {
            lista.Add(param);
            return lista;
        }

        public static String Mostrar<X>() where X:T
        {
            StringBuilder str = new StringBuilder();
            foreach (T item in lista)
            {
                str.AppendLine(item.ToString());
            }
            return str.ToString();
        }
         
    }
}
