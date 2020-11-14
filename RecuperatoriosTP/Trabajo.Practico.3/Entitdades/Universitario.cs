using Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos
        private int legajo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universitario()
        {

        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
                                        : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Dos Universitarios serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True si ambas instancias son iguales, false caso contrario.</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool sonIguales = false;

            if (pg1 is null || pg2 is null)
            {
                sonIguales = false;
            }
            else if (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI)
            {             
                sonIguales = true;               
            }
               
            return sonIguales;
        }
        /// <summary>
        /// Dos Universitarios serán distintos si no comparten el mismo legajo ni DNI.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True si ambas instancias son distintas,false caso contrario.</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion

        #region metodos
        /// <summary>
        /// Imprime los datos de un universitario.
        /// </summary>
        /// <returns>String con los datos del universitario.</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("LEGAJO NUMERO: " + this.legajo.ToString());

            return sb.ToString();
        }
        /// <summary>
        ///  Dos Universitarios serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si ambas instancias son iguales, false caso contrario.</returns>
        public override bool Equals(object obj)
        {
            bool sonIguales = false;

            if (obj is Universitario)
            {
                sonIguales = this == (Universitario)obj;
            }

            return sonIguales;

        }
        
        /// <summary>
        /// Metodo que se usara para imprimir las clases que asista el profesor o el alumno.
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        #endregion
    }
}