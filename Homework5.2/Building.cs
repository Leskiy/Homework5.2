using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5._2
{
    public class Building
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public List<Building> Buildings { get; set; }
        public List<Animal> Animals { get; set; }
        public int WorkLoad { get; set; }
        public void GetAnimal()
        {
            Animals = new List<Animal>();
            Animals.Add(new Animal());
        }
        public void GetInfo()
        {
            Console.WriteLine($"Animal {Name} \t ({Area} in Building) \t give this products:");
            for (int i = 0; i < Animals.Count; i++)
            {
                Animals[i].GetInfo();
            }
        }

    }
}
