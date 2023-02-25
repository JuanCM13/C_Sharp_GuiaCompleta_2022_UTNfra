using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlAduana_Entidades;

namespace ControlDeAduana_UnityTests
{
    [TestClass]
    public class PaquetePasadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            //anda de 10, preguntar por que rompe si paso por parametros los valores de resultado
            //y de valores con [datarows(valor1 , valor2)];

            //arrange
            decimal esperado = 240; //320
            // seria: 200 costo envio + 35% aduana(70) + 25% afip(50) == $320
            // seria 150 costo envio + 35% aduana(52.5) + 25% afip(37.5) == $240
            decimal resultado;
            PaquetePesado paq;

            //act                   //200  52.5 + 37.5
            paq = new("AD25416DFF", 150 , "Chile", "Bolivia", 33.25F);
            resultado = paq.AplicarImpuestos();

            //assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            //arrange
            decimal esperado = 50;
            decimal resultado;
            PaquetePesado paq;

            //act
            paq = new("AD25416DFF", 200, "Chile", "Bolivia", 33.25F);
            resultado = ((IAfip)paq).Impuestos;

            //assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //arrange
            PaquetePesado paq;
            decimal esperado = 105;
            decimal resultado;

            //act
            paq = new("A54FA", 300, "Peru", "Argentina", 145.53F);
            resultado = paq.Impuestos;

            //assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //arrange
            bool ret;
            PaquetePesado paq;

            //act
            paq = new("A54FA", 350, "Peru", "Argentina", 145.53F);
            ret = paq.TienePrioridad;

            //assert
            Assert.IsFalse(ret);
        }
    }
}
