using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public DniInvalidoException() 
            :base("El DNI no es valido.")
        {

        }
        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e) 
            :this("El DNI no es valido.", e)
        {

        }
        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="message"></param>
        public DniInvalidoException(string message) 
            :base(message)
        {

        }
        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public DniInvalidoException(string message, Exception e) 
            :base(message, e)
        {

        }
    }
}
