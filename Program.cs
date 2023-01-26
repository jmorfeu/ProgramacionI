using System;
using System.Collections;
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
                int[] numbers = new int[10];
                int maxPar = int.MinValue;
                int pos = -1;

                Console.WriteLine("Ingresa 10 números enteros:");
                string numerosDigitados = Console.ReadLine();
              
                for (int i = 0; i < numerosDigitados.Length; i++)
                {
                    numbers[i] = int.Parse(numerosDigitados[0].ToString());
                    if (numbers[i] % 2 == 0 && numbers[i] > maxPar)
                    {
                        maxPar = numbers[i];
                        pos = i+1;
                    }
                }

                if (pos == -1)
                {
                    Console.WriteLine("No se encontró ningún número par.");
                }
                else
                {
                    Console.WriteLine("El número par más grande es {0} y se encuentra en la posición {1}.", maxPar, pos);
                }
            Console.ReadKey();
        }
           
        }
    }

