using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos
        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Enumerado
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado,
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Alumno() : base()
        {

        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, Persona.ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, Persona.ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Imprime la clase que toma el alumno
        /// </summary>
        /// <returns>String con las clases</returns>
        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE: " + this.claseQueToma.ToString();
        }
        /// <summary>
        /// Imprime todos los datos del alumno (protected)
        /// </summary>
        /// <returns>String con los datos</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("ESTADO CUENTA: " + this.estadoCuenta.ToString());
            sb.AppendLine(ParticiparEnClase());

            return sb.ToString();
        }
        /// <summary>
        /// Imprime todos los datos del alumno (public)
        /// </summary>
        /// <returns>String con los datos</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Sobrecarga de operadores 
        /// <summary>
        /// Un alumno sera igual a una clase si este la tiene en su campo claseQueToma y ademas su estado no es deudor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns>True si el alumno toma la clase y su campo estadoCuenta es distinto a deudor, false caso contrario.</returns>
        public static bool operator ==(Alumno a, EClases clase)
        {
            bool sonIguales = false;

            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                sonIguales = true;
            }

            return sonIguales;
        }
        /// <summary>
        /// Un alumno sera distinto a una clase solo si no la toma.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clases"></param>
        /// <returns>True si el alumno no toma la clase, false caso contrario</returns>
        public static bool operator !=(Alumno a, EClases clases)
        {
            bool sonDistintos = false;

            if (a.claseQueToma != clases)
            {
                sonDistintos = true;
            }

            return sonDistintos;
        }
        #endregion
    }
}
