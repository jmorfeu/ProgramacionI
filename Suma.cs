using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Suma
    {
        private int Valor1 { get; set; }
        private int Valor2 { get; set; }

        public Suma(int valor1, int valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
        }


        public int ResultadoSuma()
        {
            return Valor1 + Valor2;
        }

        public int ResultadoResta()
        {
            return Valor1 - Valor2;
        }
    }
}
