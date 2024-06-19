using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Animal
    {
        public string nombre;

        public Animal(string nombre)
        {
            this.nombre = nombre;
        }
        public virtual void comer()
        {
            Console.WriteLine("Estoy comiendo");
        }

        public virtual void moverse()
        {
            Console.WriteLine("Estoy moviendome");
        }
        public virtual void hablar()
        {
            Console.WriteLine("Estoy hablando");
        }
    }
}
