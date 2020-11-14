using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Se encarga de serializar los datos que recibe del objeto generico T, en el path recibido.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna true si pudo serializar correctamente, retornara false si se lanzo una excepcion y se capturó</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool guardado = false;

            using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
            {
                if (writer != null)
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    if (ser != null)
                    {
                        ser.Serialize(writer, datos);
                        guardado = true;
                    }
                }
                else
                {
                    throw new ArchivosException();
                }
            }
            return guardado;
        }

        /// <summary>
        /// Se encarga de deserializar los datos del path recibido, y los almacena en la variable generica datos recibida.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna true si pudo serializar correctamente, retornara false si se lanzo una excepcion y se capturó</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool leido;
            datos = default;

            using (XmlTextReader reader = new XmlTextReader(archivo))
            {
                if (reader != null)
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    if (ser != null)
                    {
                        datos = (T)ser.Deserialize(reader);
                        leido = true;
                    }
                    else
                    {
                        throw new ArchivosException();
                    }
                }
                else
                {
                    throw new ArchivosException();
                }
            }
            return leido;
        }
    }
}
