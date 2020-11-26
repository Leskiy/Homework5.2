using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5._2
{
    public class Farm
    { 
        public string farmaName { get; set; }
        public int farmaArea { get; set; }
        public List<Plank> Planks { get; set; }
        public List<Building> Buildings { get; set; }
        public int WorkLoad { get; set; }
        public void GetFarm()
        {
            Planks = new List<Plank>();
            Planks.Add(new Plank());
            Buildings = new List<Building>();
            Buildings.Add(new Building());
        }
        public void GetInfo()
        {
            Console.WriteLine($"Farm {farmaName} in ar {farmaArea} areas has {Buildings.Count} buildings and {Planks.Count} planks");
            for (int i = 0; i < Buildings.Count; i++)
            {
                Buildings[i].GetInfo();
            }
            Console.WriteLine($"and these planks");
            for (int i = 0; i < Planks.Count; i++)
            {
                Planks[i].GetInfo();
            }
        }
    }
    
}
