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

        public static double Operar(Operando numero, Operando numero1, char operador)
        {

        }
    }
}
