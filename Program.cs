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
            
          

            Usuario usuario =new Usuario();
            Personas personas = new Personas(); 
           

            personas.Apellido = "Perez";
            personas.Nombre = "juan";
            personas.Id = 1;

            usuario.Personas.Add(personas);

            personas.Apellido = "jose";
            personas.Nombre = "perez";
            personas.Id = 2;



            usuario.Personas.Add(personas);
            //para este ejercio uso una clausura where para buscar en la lista 
            //defino una variable x para acceder a las propiedades y busco el registro 1
            //luego obtento el primer record de la pila
            var _usuarioPersona = usuario.Personas.Where(x => x.Id == 1).First();

            Console.WriteLine($"Los datos de la persona es: {_usuarioPersona.Nombre}");

            Console.ReadKey();

        }
    }
}
