using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador (char operando)
        {
            char validar = '+';

            if(operando != '-' || operando != '/' || operando != '*')
            {
                validar = operando;
            }

            return validar;
        }

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

            return resultado;
        }
    }
}
