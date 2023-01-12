using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Indique el primer numero: ");
            int valor1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique el segundo numero: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Suma suma = new Suma(valor1,valor2);
            
            Console.WriteLine($"La Resta es: {suma.ResultadoResta()}");
            Console.WriteLine($"La suma es: {suma.ResultadoSuma()}");
            Console.ReadKey();

        }
    }
}
