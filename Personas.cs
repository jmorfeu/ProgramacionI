using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Personas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }



    }
    public class  Usuario: Personas
    {
        public List<Personas> Personas { get; set; }
   
        public Usuario()
        {
            Personas = new List<Personas>();
            
        }
    }

    public class Usuario1: Personas
    {
        public List<Personas> Personas { get; set; }

        public Usuario1()
        {
            Personas = new List<Personas>();

        }
    }
}
