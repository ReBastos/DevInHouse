using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_10.Entidades
{
    public class Zoologico
    {

        public List<Animal> Jaula;

        public void AdicionarAnimal(Animal animal)
        {
            if(Jaula == null)
            {
                Jaula = new List<Animal>();
            }

            Jaula.Add(animal);
        }

        public void PercorrerJaula()
        {
            foreach(Animal animal in Jaula)
            {
               Console.WriteLine(animal.Som());
            }
            
        }
    }
}
