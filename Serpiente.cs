using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Serpiente : Animal
    {
        public Serpiente(string nombre) : base(nombre)
        {
            
        }
        
        public override void moverse()
        {
            Console.WriteLine("Serpenteo por la vida");
        }
        public override void hablar()
        {
            Console.WriteLine("S S S por que S");
        }
        public override void comer()
        {
            Console.WriteLine("Serpiente no come, devora!");
        }
    }
}
