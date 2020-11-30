using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        float precio;

        #region Propiedades
        /// <summary>
        /// Getter de precio
        /// </summary>
        public float Precio
        {
            get { return this.precio; }
        }
        /// <summary>
        /// Setter que valida el numero
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.precio = ValidarNumero(value);
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="precio"></param>
        public Producto(float precio)
        {
            this.precio = precio;
        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="precio"></param>
        public Producto(string precio)
        {
            this.SetNumero = precio;
        }
        #endregion

        /// <summary>
        /// Valida que el string recibido sea un numero
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private float ValidarNumero(string strNumero)
        {
            float validatedNumber;

            if (float.TryParse(strNumero, out validatedNumber))
            {
                return validatedNumber;
            }
            else
            {
                return 0;
            }
        }

    }
}
