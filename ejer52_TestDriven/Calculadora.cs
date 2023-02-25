using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer52_TestDriven
{
    public class Calculadora
    {
        public static Int32 Add(String numero)
        {
            Char[] caracteresSeparadores = { ',', '\n' };
            Int32 acum = 0;

            if(Int32.TryParse(numero , out Int32 aux) && aux < 0)
            {
                throw new NegativoNoPermitidoException(aux.ToString());
            }

            if (numero.Length > 1 && numero[0] == '/' && numero[1] == '/')
            {
                numero = numero.Replace('/' , ' ');
                numero = numero.TrimStart();
                numero = numero.Replace(numero[0], ',');
            }            

            foreach(String item in numero.Split(caracteresSeparadores))
            {
                if (int.TryParse(item, out Int32 aux2))
                {
                    acum += aux2;
                }
            }
            return acum;
        }
    }
}
