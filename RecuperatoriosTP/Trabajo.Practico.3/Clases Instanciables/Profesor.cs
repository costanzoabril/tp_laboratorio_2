using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<EClases> clasesDelDia;
        static Random random;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }
        /// <summary>
        /// Constructor que permite la serialización.
        /// </summary>
        public Profesor() : base()
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
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<EClases>();
            this._RandomClases();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que se encarga de inicializar la Queue con dos clases aleatorias a traves del atributo estatico random.
        /// </summary>
        private void _RandomClases()
        {
            int cantidadEnum = Enum.GetNames(typeof(Universidad.EClases)).Length;
            int numRandom = Profesor.random.Next(1, cantidadEnum);

            this.clasesDelDia.Enqueue((Universidad.EClases)numRandom);

            numRandom = Profesor.random.Next(1, cantidadEnum);

            this.clasesDelDia.Enqueue((Universidad.EClases)numRandom);
        }
        /// <summary>
        /// Imprime todos los datos de la clase base, ademas de las clases en las que participa. (protected)
        /// </summary>
        /// <returns>String con los datos</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendFormat(this.ParticiparEnClase());

            return sb.ToString();
        }
        /// <summary>
        /// Imprime todas las clases del dia en la Queue. (protected)
        /// </summary>
        /// <returns>Toda la información en formato string</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DIA:");

            foreach (Universidad.EClases c in this.clasesDelDia)
            {
                sb.AppendLine(c.ToString());
            }

            return sb.ToString();
        }
        /// <summary>
        /// Imprime todos los datos de la clase base, ademas de las clases en las que participa. (public)
        /// </summary>
        /// <returns>String con lo que retorna el metodo MostrarDatos</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;

            if (i is null)
            {
                return false;
            }

            foreach (Universidad.EClases c in i.clasesDelDia)
            {
                if (c == clase)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        #endregion
    }
}
