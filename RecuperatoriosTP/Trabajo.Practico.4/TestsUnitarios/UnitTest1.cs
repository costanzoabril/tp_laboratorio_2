
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using Excepciones;
using Entidades;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Valida que lance la excepcion ArchivoException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivoException))]
        public void Test_ArchivoException()
        {
            Texto txt = new Texto();

            txt.Guardar("", "");
        }

        /// <summary>
        /// Valida que las listas de peliculas y estacionamientos estes instanciadas en la clase AutoCine
        /// </summary>
        [TestMethod]
        public void Test_Coleccion()
        {
            Assert.IsNotNull(AutoCine.Peliculas);
            Assert.IsNotNull(AutoCine.Estacionamientos);
        }
    }
}
