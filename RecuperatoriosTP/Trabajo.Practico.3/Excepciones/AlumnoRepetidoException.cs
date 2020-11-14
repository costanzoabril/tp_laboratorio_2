using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException : Exception
    {
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public AlumnoRepetidoException()
            :base("Alumno repetido.")
        {

        }
        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="message" cadena que sera asignada como mensaje></param>
        public AlumnoRepetidoException(string message)
            :base(message)
        {

        }
    }
}
