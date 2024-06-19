using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Gaviota : Animal
    {
        public Gaviota(string nombre) : base(nombre)
        {

        }

        public override void moverse()
        {
            Console.WriteLine("Cuando desplazo plazo por el aire");
        }
        public override void hablar()
        {
            Console.WriteLine("No hay No hay !");
        }
        public override void comer()
        {
            Console.WriteLine("Lo mismo no...");
        }
    }
}
