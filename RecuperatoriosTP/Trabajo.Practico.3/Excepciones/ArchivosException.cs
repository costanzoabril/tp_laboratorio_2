using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public ArchivosException()
           : base("Error de archivos")
        {

        }
        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="message"></param>
        public ArchivosException(string message)
             : base(message)
        {


        }
        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException(Exception innerException)
             : base(innerException.Message)
        {
            
        }
    }
}
