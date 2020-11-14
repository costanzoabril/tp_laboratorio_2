using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// Constructor de defecto.
        /// </summary>
        public NacionalidadInvalidaException()
            :base("La nacionalidad no se condice con el numero de DNI.")
        {

        }
        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="message"></param>
        public NacionalidadInvalidaException(string message)
            :base(message)
        {

        }
    }
}
