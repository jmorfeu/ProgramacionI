using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Listas
    {
        public void iterarlistas(int _numero)
        {
            List<int> numeros = new List<int>();

            for (int i = 1; i <= _numero; i++)
            {
                numeros.Add(i);
            }

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);

            }

        }
    }
}
