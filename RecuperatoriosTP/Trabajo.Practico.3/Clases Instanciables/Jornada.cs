using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private EClases clases;
        private Profesor instructor;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }

            set
            {
                this.alumnos = value;
            }
        }
        public EClases Clase
        {
            get
            {
                return this.clases;

            }
            set
            {
                this.clases = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;

            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Jornada()
        {
            this.Alumnos = new List<Alumno>();

        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="clase" enumerado de tipo EClases></param>
        /// <param name="instructor" objeto de tipo Profesor></param>
        public Jornada(EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Guarda los datos de la Jornada en un archivo de texto
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();

            return texto.Guardar("jornada.txt", jornada.ToString());
        }
        /// <summary>
        /// Lee un archivo de texto.
        /// </summary>
        /// <returns>String con el archivo leido</returns>
        public static string Leer()
        {
            Texto texto = new Texto();
            string salida;

            texto.Leer("Jornada.txt", out salida);

            return salida;
        }
        /// <summary>
        /// Imprime todos los datos de la Jornada.
        /// </summary>
        /// <returns>String con todos los datos de una Jornada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ClASE DE: " + this.clases.ToString());
            sb.AppendLine(" POR " + this.instructor.ToString());
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno item in this.Alumnos)
            {
                sb.AppendLine(item.ToString());

            }
            sb.AppendLine("<------------------------------->");
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Una jornada y un alumno seran iguales si este participa en la clase
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>True si son iguales, false si no lo son</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool sonIguales = false;

            if (a == j.Clase)
            {
                sonIguales = true;
            }

            return sonIguales;
        }
        /// <summary>
        /// Una jornada y un alumno seran distintos si este no participa en la clase
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>True si son distintos, false si son iguales</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        /// <summary>
        /// Agrega un alumno a la jornada validando que este no este repetido
        /// </summary>
        /// <param name="j" ></param>
        /// <param name="a"></param>
        /// <returns>Objeto de tipo Jornada con el alumno nuevo incluido.</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (!j.Alumnos.Contains(a))
            {
                j.Alumnos.Add(a);
            }

            return j;
        }
        #endregion
    }
}
