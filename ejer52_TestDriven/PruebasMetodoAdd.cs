using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ejer52_TestDriven
{
    [TestClass]
    public class PruebasMetodoAdd
    {
        //nombres de metodos formados con formato GIVE WHEN THEN --- El otro formato es el SHOOT
        [TestMethod]
        public void Add_ProbarValorStringVacio_RetornarCero()
        {
            //arrange
            string num = string.Empty;
            int esperado = 0;
            int resultadoTest;
            //act
            resultadoTest = Calculadora.Add(num);

            //Assert
            Assert.AreEqual(resultadoTest, esperado);
        }

        [TestMethod]
        public void Add_ProbarValorStringNumeroSolo_RetornarMismoNumero()
        {
            //arrange
            string num = "1";
            int esperado = 1;
            int resultadoTest;
            //act
            resultadoTest = Calculadora.Add(num);

            //Assert
            Assert.AreEqual(resultadoTest, esperado);
        }

        [TestMethod]
        public void Add_ProbarValorStringNcantidadNumerosSeparadosPorComa_RetornarSumaNumeros()
        {
            //arrange
            string num = "1 , 25 , 1 , 2";
            int esperado = 29;
            int resultadoTest;
            //act
            resultadoTest = Calculadora.Add(num);

            //Assert
            Assert.AreEqual(resultadoTest, esperado);
        }

        [TestMethod]
        public void Add_ProbarValorStringNcantidadNumerosSeparadosPorComaOcontrabarra_RetornarSumaNumeros()
        {
            //arrange
            string num = "1 , 25 , 1 \n 2";
            int esperado = 29;
            int resultadoTest;
            //act
            resultadoTest = Calculadora.Add(num);

            //Assert
            Assert.AreEqual(resultadoTest, esperado);
        }

        [TestMethod]
        public void Add_ProbarValorStringNcantidadNumerosSeparadosPorComaOcontrabarraOnuevoDelimitador_RetornarSumaNumeros()
        {
            //arrange
            string num = "//;1 , 25 , 1 \n 2";
            int esperado = 29;
            int resultadoTest;
            //act
            resultadoTest = Calculadora.Add(num);

            //Assert
            Assert.AreEqual(resultadoTest, esperado);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_ProbarValorStringNcantidadNumeroNegativo_RetornarExcepcion()
        {
            //arrange
            string num = "-6";            
            int resultadoTest;
            //act
            resultadoTest = Calculadora.Add(num);
        }
    }
}
