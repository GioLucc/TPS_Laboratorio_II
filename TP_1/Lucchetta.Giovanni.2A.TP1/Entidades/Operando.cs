using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
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

        public string BinarioDecimal(string binario)
        {
            string resultado = "¡Valor invalido!";

            if (EsBinario(binario))
            {
                int numeroConvertido = 0;
                char[] cadenaAlReves = binario.ToArray();
                Array.Reverse(cadenaAlReves);

                for (int i = 0; i < binario.Length; i++)
                {
                    if (cadenaAlReves[i] == '1')
                    {
                        numeroConvertido += (int)(Math.Pow(2, i));

                    }
                }
                if (numeroConvertido > 0)
                {
                    resultado = numeroConvertido.ToString();
                }
            }
            return resultado;
        }

        public string DecimalBinario(string numero)
        {
            int resto;
            int valor;
            string resultado = "";

            if (int.TryParse(numero, out valor) && valor > 0)
            {
                while (valor > 0)
                {
                    resto = valor % 2;
                    valor = valor / 2;

                    resultado = resto.ToString() + resultado;
                }
            }
            else
            {
                resultado = "¡Valor invalido!";
            }


            return resultado;
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

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != 0 || binario[i] != 1)
                {
                    binaryValidation = false;
                    break;
                }
            }

            return binaryValidation;
        }



        /// visibildiad - comportamiento - resultado - operator (+,-,/,*,string,int,double,etc...) { }
        /// public      -       static   - bool    - operator - +
        /// private     -                - int     - operator - -
        /// protected   -                - string  - operator - /, *, string,int,double etc...


        public static double operator +(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            double resultado = 0;

            if(n2.numero > 0)
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }



    }
}

