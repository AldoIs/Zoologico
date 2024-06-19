using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Pinguino : Animal
    {
        public Pinguino(string nombre) : base(nombre)
        {

        }

        public override void moverse()
        {
            Console.WriteLine("No, Me tambaleo");
        }
        public override void hablar()
        {
            Console.WriteLine("BonIce BonIce");
        }
        public override void comer()
        {
            Console.WriteLine("Pescado");
        }
    }
}
