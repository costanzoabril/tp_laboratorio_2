using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Inicializa en 0 el campo numero
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Inicializa en 0 el campo numero
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Inicializa en 0 el campo numero
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }

        /// <summary>
        /// Valida que el string sea un numero. Lo devuelve en double o en caso de error devuelve 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double aux;

            if (!double.TryParse(strNumero, out aux))
                aux = 0;

            return aux;
        }

        /// <summary>
        /// Setter de numero
        /// </summary>
        public string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Valida que el string sea binario. Devuelve true si es binario, false si no lo es
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = false;

            foreach (char caracter in binario)
            {
                if (caracter == '0' || caracter == '1')
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Convierte un numero(double) decimal a binario y lo retorna
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            string retorno = "Valor invalido";

            if (numero > 0)
                retorno = Convert.ToString((int)numero, 2);

            return retorno;
        }

        /// <summary>
        /// Convierte un numero(string) decimal a binario y lo retorna
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";
            double aux;

            if (double.TryParse(numero, out aux))
                retorno = DecimalBinario(aux);

            return retorno;

        }

        /// <summary>
        /// Convierte un numero(string) de binario a decimal y lo retorna
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            double numero = 0;
            string retorno = "Valor invalido";

            if (EsBinario(binario))
            {
                numero = Convert.ToInt32(binario, 2);
                retorno = Convert.ToString(numero);
            }

            return retorno;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;

        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;

        }

        public static double operator /(Numero n1, Numero n2)
        {
            double rta = Double.MinValue;
            if (n2.numero != 0)
            {
                rta = n1.numero / n2.numero;

            }
            return rta;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
    }
}
