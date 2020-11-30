using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento : Producto
    {
        string ubicacion;

        /// <summary>
        /// Getter de ubicacion
        /// </summary>
        public string Ubicacion
        {
            get
            {
                return this.ubicacion;
            }
        }

        #region Constructores
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="ubicacion"></param>
        public Estacionamiento(float precio, string ubicacion)
            :base(precio)
        {
            this.ubicacion = ubicacion;
        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="ubicacion"></param>
        public Estacionamiento(string precio, string ubicacion)
            : base(precio)
        {
            this.ubicacion = ubicacion;
        }
        #endregion

        #region Sobrecargas 
        /// <summary>
        /// Sobrecarga del metodo ToString, imprime la informacion del estacionamiento
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ESTACIONAMIENTO");
            sb.AppendFormat("Ubicacion: {0}\n", this.ubicacion);
            sb.AppendFormat(" Precio: ${0}", this.Precio);

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador ==, son iguales si el estacionamiento pertenece a la lista de estacionamientos
        /// </summary>
        /// <param name="e"></param>
        /// <param name="es"></param>
        /// <returns></returns>
        public static bool operator ==(Estacionamiento e, List<Estacionamiento> es)
        {
            bool retorno = false;

            foreach (Estacionamiento item in es)
            {
                if (item == e)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga de operador !=, son disintos si el estacionamiento no pertenece a la lista de estacionamientos
        /// </summary>
        /// <param name="unProducto"></param>
        /// <param name="misProductos"></param>
        /// <returns>True si es distinto, false si no</returns>
        public static bool operator !=(Estacionamiento e, List<Estacionamiento> es)
        {
            return !(e == es);
        }

        /// <summary>
        /// Sobrecarga del operador +, agrega un estacionamiento a la lista
        /// </summary>
        /// <param name="es"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator +(List<Estacionamiento> es, Estacionamiento e)
        {
            bool retorno = false;

            if (e != es)
            {
                es.Add(e);
                retorno = true;
            }

            return retorno;
        }
        #endregion
    }
}
