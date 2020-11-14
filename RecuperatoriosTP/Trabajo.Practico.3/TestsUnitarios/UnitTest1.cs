using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instanciables;
using EntidadesAbstractas;
using Archivos;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Comprueba que el atributo de tipo collecion Jornada se haya instanciado.
        /// </summary>
        [TestMethod]
        public void VerificarInstanciaColeccion()
        {
            Universidad universidad = new Universidad();

            Assert.IsNotNull(universidad.Jornadas);
        }

        /// <summary>
        /// Comprueba que la excepcion AlumnoRepetidoException funcione correctamente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void VerificaAlumnoRepetidoException()
        {
            Universidad universidad = new Universidad();

            Alumno a = new Alumno(1, "Juana", "Blanco", "40642933", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            Alumno b = new Alumno(2, "Damian", "Baez", "40642933", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);

            universidad += a;
            universidad += b;
        }

        /// <summary>
        /// Comprueba que la excepcion ArchivosException funcione correctamente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void VerificaArchivosException()
        {

            string path = null;
            string datos;
            Texto lector = new Texto();
            
            lector.Leer(path, out datos);
        }
    }
}
