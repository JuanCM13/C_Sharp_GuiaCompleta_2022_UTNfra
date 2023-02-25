using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlAduana_Entidades;
using System.Threading.Tasks;

namespace ControlDeAduana_UnityTests
{
    [TestClass]
    public class PaqueteFragilTest
    {        

        [TestMethod]

        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //arrange
            PaqueteFragil paq;
            decimal esperado = 270;
            decimal resultado;

            //act
            paq = new("A54FA", 200, "Peru", "Argentina", 145.53F);
            resultado = paq.AplicarImpuestos();

            //assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //arrange
            PaqueteFragil paq;
            decimal esperado = 70;
            decimal resultado;

            //act
            paq = new("A54FA", 200, "Peru", "Argentina", 145.53F);
            resultado = paq.Impuestos;

            //assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //arrange
            bool ret;
            ControlAduana_Entidades.PaqueteFragil paq;

            //act
            paq = new("A54FA", 350, "Peru", "Argentina", 145.53F);
            ret = paq.TienePrioridad;

            //assert
            Assert.IsTrue(ret);
        }
    }
}
