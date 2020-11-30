using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ConexionException : Exception
    {
        /// <summary>
        /// Excepcion que se lanza si no pudo conectarse a la base de datos
        /// </summary>
        public ConexionException() : base("Error al conectarse con la base de datos")
        {
        }
        /// <summary>
        /// Excepcion que se lanza si no pudo conectarse a la base de datos
        /// </summary>
        /// <param name="message">mensaje recibido por parámetro</param>
        public ConexionException(string message) : base(message)
        {
        }
    }
}