using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExcepcionesEjer1;

namespace ejer54Test_LanzarAtrapar
{
    [TestClass]
    public class Test_OtraClase
    {
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void MetodoInstancia_Positivo()
        {
            OtraClase otr;

            //act
            otr = new OtraClase();
            otr.MetodoInstancia();
        }
    }
}
