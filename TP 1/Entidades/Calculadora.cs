using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        #region Metodos

        /// <summary>
        /// Valida el operador a utilizar en la cuenta
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Operador ya validado</returns>
        private static string ValidarOperador(char operador)
        {
            string operadorValidado = "+";

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                operadorValidado = operador.ToString();
            }

            return operadorValidado;
        }

        /// <summary>
        /// Valida y realiza la operacion
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Operador, indica la operacion a realizar</param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            string operadorValidado;
            char operadorChar;

            if (!(num1 is null) && !(num2 is null))
            {
                char.TryParse(operador, out operadorChar);
                operadorValidado = Calculadora.ValidarOperador(operadorChar);
                if (operadorValidado.Equals("+"))
                {
                    retorno = num1 + num2;
                }
                else if (operadorValidado.Equals("-"))
                {
                    retorno = num1 - num2;
                }
                else if (operadorValidado.Equals("/"))
                {
                    retorno = num1 / num2;
                }
                else
                {
                    retorno = num1 * num2;
                }
            }

            return retorno;
        }
        #endregion

    }
}
