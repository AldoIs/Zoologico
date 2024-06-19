using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Zologico
    {
        List<Animal> habitats = new List<Animal>();
        public Zologico(string nombre) {
            Console.WriteLine("El Zologico " + nombre + " esta abierto");
        }
        public void AddAnimal(Animal animal)
        {
            habitats.Add(animal);
            Console.WriteLine("Animal Agregado: " + animal.nombre);
        }
      public Animal getRandomHabitat()
        {
            Random random = new Random();
            int index = random.Next(habitats.Count);
            return habitats[index];
        }
        public void visitar()
        {
            Console.WriteLine("");
            Console.WriteLine("Y asi fue como el guia nos llevo a visitar el habitat donde....");
            Animal animal = getRandomHabitat();
            animal.comer();
            animal.moverse();
            animal.hablar();
        }
    }
}
