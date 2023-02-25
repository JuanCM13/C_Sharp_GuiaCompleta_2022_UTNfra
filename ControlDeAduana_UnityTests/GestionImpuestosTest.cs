using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlAduana_Entidades;

namespace ControlDeAduana_UnityTests
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            /*
             * Preguntar si aca la idea es calcular el total de precio, con ambos impuestos
             *por que como esta planteado el ejercicio no se podria separar el precio de los
             *paquetes pesados, tendria que agregar una propiedad que me explonga el precio del impuesto
             *afip, sino tambien puedo ir sumando el costo + la propiedad de instancia Impuesto asi me devuelve
             *de ese paquetePesado el 35 porciento y ese se lo acumulo al resultado sumandole el precio
             *del envio...
             */
            PaqueteFragil paq1;
            PaqueteFragil paq2;
            PaqueteFragil paq3;
            PaquetePesado paq4;
            PaquetePesado paq5;
            PaquetePesado paq6;
            GestionImpuestos gst;

            Decimal resultado;
            Decimal esperado = (Decimal)2047.5;

            /*
             * Esperado: aduana:
             * 135 + 202.5 , 270 ,400(ambos impuestos, sino nose como calculardo da) , 480 , 560  == 2.047,5
             */

            //act
            gst = new GestionImpuestos();
            paq1 = new PaqueteFragil("ASD4441", 100, "Lanus", "Banfield", 10.5F);
            paq2 = new PaqueteFragil("ASD4442", 150, "Lomas", "Avellaneda", 237.25F);
            paq3 = new PaqueteFragil("ASD4443", 200, "Alsina", "Matanza", 625.5F);

            paq4 = new PaquetePesado("ASD4451", 250, "Brandsen", "Almagro", 340.5F);
            paq5 = new PaquetePesado("ASD4452", 300, "Lobos", "Balvanera", 50.0F);
            paq6 = new PaquetePesado("ASD4453", 350, "Lincoln", "Barracas", 1014.21F);

            List<Paquete> paquetes = new List<Paquete>()
            { paq1 , paq2 , paq3 , paq4 , paq5 , paq6 };

            gst.RegistrarImpuestos(paquetes);
            resultado = gst.CalcularTotalImpuestosAduana();

            //assert

            Assert.AreEqual(resultado , esperado);
        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {

        }
    }
}
