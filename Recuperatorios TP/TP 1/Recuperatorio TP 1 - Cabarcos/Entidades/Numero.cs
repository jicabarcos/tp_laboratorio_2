using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Propiedades
        /// <summary>
        /// Completa el atributo "numero" con el valor "value"
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor por defecto de la clase Numero.
        /// Llama al constructor con un parámetro de tipo double.
        /// </summary>
        public Numero():this(0)
        {
        }

        /// <summary>
        /// Constructor de instancia de la clase numero
        /// </summary>
        /// <param name="numero">Valor (double) a asignar en el atributo "numero" del objeto a crear</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor de instancia de la clase numero
        /// </summary>
        /// <param name="strNumero">Valor (string) a asignar en el atributo "numero" del objeto a crear</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Valida si la cadena pasada por argumento es un numero o no
        /// </summary>
        /// <param name="strNumero">Cadena a evaluar</param>
        /// <returns>Si la cadena es un numero, la retorna en formato double. De lo contrario retorna 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            if (Regex.IsMatch(strNumero, @"^[0-9]+$"))
            {
                Double.TryParse(strNumero, out retorno);
            }

            return retorno;
        }

        /// <summary>
        /// Valida que la cadena de caracteres esté compuesta únicamente por caracteres '0' y/o '1'
        /// </summary>
        /// <param name="binario">Cadena a evaluar</param>
        /// <returns>True si la cadena cumple la condición, false de lo contrario</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = false;

            foreach(char num in binario)
            {
                if(num == '0' || num == '1')
                {
                    retorno = true;
                }
                else
                {
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Convierte de binario a decimal
        /// </summary>
        /// <param name="binario">Numero binario a convertir</param>
        /// <returns>Numero convertido, de no ser posible "Valor invalido"</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido";

            if (this.EsBinario(binario))
            {
                retorno = Convert.ToString(Convert.ToInt32(binario, 2), 10);
            }
            
            return retorno;
        }

        /// <summary>
        /// Convierte de decimal a binario
        /// </summary>
        /// <param name="numero">Numero decimal a convertir (double)</param>
        /// <returns>Numero convertido, de no ser posible "Valor invalido"</returns>
        public string DecimalBinario(double numero)
        {
            int numAbsoluto = Convert.ToInt32(Math.Abs(numero));
            string numBinario = Convert.ToString(numAbsoluto, 2);

            if (this.EsBinario(numBinario))
            {
                return numBinario;
            }

            return "Valor inválido";
        }

        /// <summary>
        /// Convierte de decimal a binario
        /// </summary>
        /// <param name="numero">Numero decimal a convertir (string)</param>
        /// <returns>Numero convertido, de no ser posible "Valor invalido"</returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido";

            if (double.TryParse(numero, out double aux))
            {
                retorno = this.DecimalBinario(aux);
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador "+", suma los atributos "numero" de dos objetos "Numero"
        /// </summary>
        /// <param name="num1">Primer objeto</param>
        /// <param name="num2">Segundo objeto</param>
        /// <returns>Resultado de la suma</returns>
        public static double operator +(Numero num1, Numero num2)
        {
            double retornoNumero = 0;

            if (!(num1 is null) && !(num2 is null))
            {
                retornoNumero = num1.numero + num2.numero;
            }

            return retornoNumero;
        }

        /// <summary>
        /// Sobrecarga del operador "-", resta los atributos "numero" de dos objetos "Numero"
        /// </summary>
        /// <param name="num1">Primer objeto</param>
        /// <param name="num2">Segundo objeto</param>
        /// <returns>Resultado de la resta</returns>
        public static double operator -(Numero num1, Numero num2)
        {
            double retornoNumero = 0;

            if (!(num1 is null) && !(num2 is null))
            {
                retornoNumero = num1.numero - num2.numero;
            }

            return retornoNumero;
        }

        /// <summary>
        /// Sobrecarga del operador "/", divide los atributos "numero" de dos objetos "Numero"
        /// </summary>
        /// <param name="num1">Primer objeto</param>
        /// <param name="num2">Segundo objeto</param>
        /// <returns>Resultado de la division. En caso de que el divisor sea "0", retorna el minimo valor posible para "double"</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            double retornoNumero = 0;

            if (!(num1 is null) && !(num2 is null))
            {
                if (num2.numero != 0)
                {
                    retornoNumero = num1.numero / num2.numero;
                }
                else
                {
                    retornoNumero = double.MinValue;
                }
            }

            return retornoNumero;
        }

        /// <summary>
        /// Sobrecarga del operador "*", divide los atributos "numero" de dos objetos "Numero"
        /// </summary>
        /// <param name="num1">Primer objeto</param>
        /// <param name="num2">Segundo objeto</param>
        /// <returns>Resultado de la multiplicacion</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            double retornoNumero = 0;

            if (!(num1 is null) && !(num2 is null))
            {
                retornoNumero = num1.numero * num2.numero;
            }

            return retornoNumero;
        }
        #endregion
    }
}
