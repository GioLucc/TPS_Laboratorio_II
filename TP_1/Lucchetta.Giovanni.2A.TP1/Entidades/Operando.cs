using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        /// <summary>
        /// Este atributo es privado.
        /// </summary>
        private double numero;

        /// <summary>
        /// Asigna el valor a numero, no sin antes validarlo.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Asigna el valor 0 al atributo numero.
        /// </summary>
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

        /// <summary>
        /// Valida que la cadena recibida sea un numero, caso contrario devuelve 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Cadena parseada del numero o 0.</returns>
        private double ValidarOperando(string strNumero)
        {
            double strValidado = 0;

            double.TryParse(strNumero, out strValidado);

            return strValidado;
        }

        /// <summary>
        /// Valida que la cadena recibida solamente esté compuesta por 1 y 0.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>true si es binario o false si no lo es.</returns>
        private bool EsBinario(string binario)
        {
            bool binaryValidation = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    binaryValidation = false;
                    break;
                }
            }

            return binaryValidation;
        }

        /// <summary>
        /// Validará que se trate de un binario y luego convertirá ese número binario a decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Su conversión en decimal en caso de ser posible, Caso contrario retornará "Valor inválido"</returns>
        public string BinarioDecimal(string binario)
        {
            string resultado = "¡Valor invalido!";

            if(EsBinario(binario))
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

        /// <summary>
        /// Validará que se trate de un decimal y luego convertirá ese número de decimal a binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Su conversión en binario en caso de ser posible, Caso contrario retornará "Valor inválido"</returns>
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

        /// <summary>
        /// Recibe un double, lo convierte a string y llama a el metodo que se encarga de convertir de decimal a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>La llamada a la función adecuada.</returns>
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());            
        }

        /// <summary>
        /// Recibe 2 objetos del tipo operando y efectua la operación de suma.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la suma.</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }

        /// <summary>
        /// Recibe 2 objetos del tipo operando y efectua la operación de resta.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la suma.</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }

        /// <summary>
        /// Recibe 2 objetos del tipo operando y efectua la operación de multiplicación.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la suma.</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }

        /// <summary>
        /// Recibe 2 objetos del tipo operando y efectua la operación de división.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la suma o si no es mayor a 0 double.MinValue.</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double resultado = double.MinValue;

            if(n2.numero > 0)
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }



    }
}

