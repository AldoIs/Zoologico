using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {

        }

        public override void moverse()
        {
            Console.WriteLine("Sigilosamente con sus patas peludas");
        }
        public override void hablar()
        {
            Console.WriteLine("no pos Miaw");
        }
        public override void comer()
        {
            Console.WriteLine("Prrr....");
        }
    }
}
