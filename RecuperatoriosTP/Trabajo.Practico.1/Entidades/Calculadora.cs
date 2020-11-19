using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
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
        public static double Operar(Numero num1, Numero num2, char op)
        {

             switch (Calculadora.ValidarOperador(op))
             {
                 case "-":
                     {
                         return num1 - num2;
                     }
                 case "/":
                     {
                         return num1 / num2;
                     }
                 case "*":
                     {
                         return num1 * num2;
                     }
                 default:
                     {
                         return num1 + num2;
                     }
             }

        }
    }
}
