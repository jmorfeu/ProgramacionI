using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Arreglos
    {
        public void iterararray()
        {
            string[] nombres = new string[] { "Juan", "Pedro", "Maria", "Carlos" };

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }
    }
}
