﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    abstract class Vehiculo
    {
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public ETamanio Tamanio 
        { 
            get { return this.Tamanio; } 
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {chasis}\n");
            sb.AppendLine($"MARCA : {marca.ToString()}\n");
            sb.AppendLine($"COLOR : {color.ToString()}\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1 is null && v2 is null)
            {
                if (v1.chasis == v2.chasis)
                {
                    return (v1.chasis == v2.chasis);
                }
            }
            
            return false;

        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
    }
}
