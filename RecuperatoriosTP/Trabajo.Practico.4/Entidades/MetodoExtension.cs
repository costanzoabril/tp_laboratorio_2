using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public static class MetodoExtension
    {
        /// <summary>
        /// Método de extensión de la clase Exception, 
        /// guarda el mensaje de la excepción lanzada en un archivo de texto
        /// </summary>
        /// <param name="miException"></param>
        /// <returns></returns>
        public static bool Guardar(this Exception miException)
        {
            Texto txt = new Texto();
            string path = AppDomain.CurrentDomain.BaseDirectory;

            StringBuilder infoException = new StringBuilder();

            infoException.AppendLine(miException.Message.ToString());
            infoException.AppendLine($"Ocurrió el {DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}");
            infoException.AppendLine($"a las {DateTime.Now.Hour}h-{DateTime.Now.Minute}m-{DateTime.Now.Second}s-{DateTime.Now.Millisecond}ms");

            return txt.Guardar(path + "ExcepcionesTxt\\" + $"Excepcion a las {DateTime.Now.Hour}h-{DateTime.Now.Minute}m-{DateTime.Now.Second}s-{DateTime.Now.Millisecond}ms.txt", infoException.ToString());
        }
    }
}
