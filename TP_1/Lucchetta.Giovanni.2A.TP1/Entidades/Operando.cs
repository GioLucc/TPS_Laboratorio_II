using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Operando
    {
        private double numero;

        private string Numero
        {
            set
            {
               this.numero = ValidarOperando(value);
            }
        }

        public Operando()
        {
            numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        private double ValidarOperando(string strNumero)
        {
            double strValidado = 0;

            double.TryParse(strNumero, out strValidado);

            return strValidado;
        }

        private bool EsBinario(string binario)
        {
            bool binaryValidation = true;

            for(int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != 0 || binario[i] != 1)
                {
                    binaryValidation = false;
                    break;
                }
            }
           
            return binaryValidation;
        }


    }
}
