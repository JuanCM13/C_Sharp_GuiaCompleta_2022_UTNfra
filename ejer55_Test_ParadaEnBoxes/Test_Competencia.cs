using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnciendanSusMotores3._0;

namespace ejer55_Test_ParadaEnBoxes
{
    [TestClass]
    public class Test_Competencia
    {
        [TestMethod]
        public void CrearCompetencia_ListaInstanciada()
        {
            Competencia cmp;

            //act
            cmp = new Competencia(10 , 5 , TipoCompetencia.MotoCross);

            //assert
            Assert.IsNotNull(cmp.Competidores);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void CargarCompetidorErroneo_ExcepcionCompNoDisponible()
        {
            Competencia cmp;
            AutoF1 f1;

            //act
            cmp = new Competencia(10, 5, TipoCompetencia.MotoCross);
            f1 = new AutoF1(1, "Ferrari");

            //act
            _ = cmp + f1;
        }

        [TestMethod]
        public void CargarCompetidorCorrecto_AssertTrue()
        {
            Competencia cmp;
            MotoCross m1;

            //act
            cmp = new Competencia(10, 5, TipoCompetencia.MotoCross);
            m1 = new(2, "Yamaha");

            //assert
            Assert.IsTrue(cmp + m1);
        }

        [TestMethod]
        public void CargarCompetidorYvalidarCarga_AssertTrue()
        {
            Competencia cmp;
            MotoCross m1;

            //act
            cmp = new Competencia(10, 5, TipoCompetencia.MotoCross);
            m1 = new(2, "Yamaha");
            _ = cmp + m1; //_ operador de descarte..
            //assert
            Assert.IsTrue(cmp == m1);
        }

        [TestMethod]
        public void EliminarCompetidorYvalidarEliminacion_AssertTrue()
        {
            Competencia cmp;
            MotoCross m1;
            MotoCross m2;
            MotoCross m3;

            //act
            cmp = new Competencia(10, 5, TipoCompetencia.MotoCross);
            m1 = new(2, "Yamaha");
            m2 = new(3, "Honda");
            m3 = new(4, "Triumph");
            _ = cmp + m1; //_ operador de descarte..
            _ = cmp + m2;
            _ = cmp + m3;

            _ = cmp - m1;
            //assert
            Assert.IsTrue(cmp != m1);
        }

        [TestMethod]
        public void EliminarCompetidorYvalidarEliminacion_AssertFalse()
        {
            Competencia cmp;
            MotoCross m1;
            MotoCross m2;
            MotoCross m3;
            MotoCross m4;

            //act
            cmp = new Competencia(10, 5, TipoCompetencia.MotoCross);
            m1 = new(2, "Yamaha");
            m2 = new(3, "Honda");
            m3 = new(4, "Triumph");
            m4 = new(5, "Beta");
            _ = cmp + m1; //_ operador de descarte..
            _ = cmp + m2;
            _ = cmp + m3;

            _ = cmp - m4;
            //assert
            Assert.IsFalse(cmp != m1);
        }
    }
}
