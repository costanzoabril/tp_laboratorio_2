using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador elegido por el usuario
        /// </summary>
        /// <param name="op"></param>
        /// <returns></returns>
        private static string ValidarOperador(char op)
        {
            char retorno = '+';

            if (op == '+' || op == '-' || op == '*' || op == '/')
            {
                retorno = op;
            }

            return Convert.ToString(retorno);
        }

        /// <summary>
        /// Produce las operaciones matematicas y retorna su resultado
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="op"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string op)
        {
            double retorno = 0;

            string opValidado = ValidarOperador(Convert.ToChar(op));

            switch (opValidado)
            {
                case "+":
                    retorno = num1 + num2;
                    break;

                case "-":
                    retorno = num1 - num2;
                    break;

                case "*":
                    retorno = num1 * num2;
                    break;

                case "/":
                    retorno = num1 / num2;
                    break;
            }
            return retorno;
        }
    }
}
