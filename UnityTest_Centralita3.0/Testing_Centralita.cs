using Microsoft.VisualStudio.TestTools.UnitTesting;
using Centralita3._0;

namespace UnityTest_Centralita3._0
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Instancia_ListaCentralita_RetornaListaInstanciada()
        {
            //arrange
            Centralita central;
            //act
            central = new Centralita("Sarasa");
            //assert
            Assert.IsNotNull(central.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CargaLlamada_Local_RetornaExcepcionCentralitaCasoPositivo()
        {
            //arrange
            Centralita central = new Centralita("Sarasa");
            Local l1 = new Local("11111", 10, "4444", 45);
            Local l2 = new Local("11111", 11, "4444", 46);
            //act
            central += l1;
            central += l2;
        }

        [TestMethod]
        public void CargaLlamada_Local_RetornaExcepcionCentralitaCasoNegativo()
        {
            //arrange
            Centralita central = new Centralita("Sarasa");
            Local l1 = new Local("11111", 10, "4444", 45);
            Local l2 = new Local("11112", 11, "4444", 46);
            int cantLlamadas;
            int result = 2;
            //act
            central += l1;
            central += l2;
            cantLlamadas = central.Llamadas.Count;

            //assert
            Assert.AreEqual(cantLlamadas , result);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CargaLlamada_provincial_RetornaExcepcionCentralitaCasoPositivo()
        {
            //arrange
            Centralita central = new Centralita("Sarasa");
            Provincial p1 = new Provincial("111111", Franja.Franja_2, 10, "44444");
            Provincial p2 = new Provincial("111111", Franja.Franja_2, 10, "44444");
            //act
            central += p1;
            central += p2;
        }

        [TestMethod]
        public void CargaLlamada_Provincial_RetornaExcepcionCentralitaCasoNegativo()
        {
            //arrange
            Centralita central = new Centralita("Sarasa");
            Provincial p1 = new Provincial("111111" , Franja.Franja_2 , 10 , "44444");
            Provincial p2 = new Provincial("111114", Franja.Franja_2, 10, "44441");
            int cantLlamadas;
            int result = 2;
            //act
            central += p1;
            central += p2;
            cantLlamadas = central.Llamadas.Count;

            //assert
            Assert.AreEqual(cantLlamadas, result);
        }
        
        [TestMethod]
        public void CompararLlamadas_Local_Provincial_RetornaIgualdadEntreLocales_Provinciales()
        {
            //assert
            bool ret;
            Provincial p1 = new Provincial("111111", Franja.Franja_2, 10, "44444");
            Provincial p2 = new Provincial("111111", Franja.Franja_2, 10, "44444");
            Local l1 = new Local("11111", 11, "4444", 45);
            Local l2 = new Local("11111", 11, "4444", 45);

            //act
            Assert.IsTrue(p1 == p2);
            Assert.IsFalse(p1 == l1);
            Assert.IsFalse(p1 == l2);

            Assert.IsTrue(l1 == l2);
            Assert.IsFalse(l1 == p1);
            Assert.IsFalse(l1 == p2);
        }
    }
}
