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
        /// Valida que el operador recibido sea +, -, / o *, sinó devuelve +.
        /// </summary>
        /// <param name="operando"></param>
        /// <returns>Operador validado o en su defecto +.</returns>
        private static char ValidarOperador (char operando)
        {
            char validar = '+';

            if(operando != '-' || operando != '/' || operando != '*')
            {
                validar = operando;
            }

            return validar;
        }

        /// <summary>
        /// Valida que el operador pedido por parametros sea correcto y realiza la operación.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Devuelve la operación realizada de los numeros que haya recibido junto con su operador.</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            if (num1 is not null && num2 is not null)
            {
                switch(ValidarOperador(operador))
                {
                    case '-':
                        resultado = num1 - num2;
                        break;

                    case '*':
                        resultado = num1 * num2;
                        break;

                    case '/':

                        resultado = num1 / num2;
                        break;

                    default:
                        resultado = num1 + num2;
                        break;
                }
            }
            return Math.Round(resultado,2);
        }
    }
}
