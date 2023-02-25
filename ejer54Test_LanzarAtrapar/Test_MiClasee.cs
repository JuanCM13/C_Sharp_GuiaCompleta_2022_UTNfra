using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExcepcionesEjer1;
using System;

namespace ejer54Test_LanzarAtrapar
{
    [TestClass]
    public class Test_MiClasee
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiClasee_LanzarExcepcion_Positivo()
        {
            MiClasee.LanzarExcepcion();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClaseeConstructorConParametro_LanzarExcepcion_Positivo()
        {
            //arrange
            MiClasee clase;

            //act
            clase = new MiClasee(new DivideByZeroException());
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClaseeConstructorSinParametro_LanzarExcepcion_Positivo()
        {
            //arrange
            MiClasee clase;

            //act
            clase = new MiClasee();
        }
    }
}
