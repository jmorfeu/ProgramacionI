using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Arreglos
    {
        public string[] Nombres { get; set; }

        public Arreglos()
        {
            Nombres = new string[] { "Juan", "Pedro", "Maria", "Carlos" };
        }

        public Arreglos(string[] nombres)
        {
            Nombres = nombres;
        }

        public Arreglos(int[] nombres)
        {
           
        }

        public void iterararray()
        {
           
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine(Nombres[i]);
            }

            arrayreverses(Nombres);
        }

        public void arrayreverses(string [] nombres)
        {

            Console.WriteLine("Reversando arreglo");
            Array.Reverse(nombres);
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            
        }

    }
}
