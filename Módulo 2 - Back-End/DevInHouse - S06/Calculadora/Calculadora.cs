using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public float Memoria1 { get; set; }
        public float Memoria2 { get; set; }
        public string Operacao { get; set; }

        public float Somar()
        {
            return Memoria1 + Memoria2;
        }

        public float Subtrair()
        {
            return Memoria1 - Memoria2;
        }

        public float Multiplicar()
        {
            return Memoria1 * Memoria2;
        }

        public float Dividir()
        {
            return Memoria1 / Memoria2;
        }


    }
}
