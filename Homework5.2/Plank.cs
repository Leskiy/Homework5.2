using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5._2
{
    public class Plank
    {
        public List<Plant> PlantsOnPlank { get; set; }
        public string PlankName { get; set; }
        public int Area { get; set; }
        public int WorkLoad { get; set; }
        public void AddPlants()
        {
            if (WorkLoad < Area)
            {
                PlantsOnPlank = new List<Plant>();
                PlantsOnPlank.Add(new Plant());
            }
            else 
            {
                Console.WriteLine("That plank is full. You can't add any more");
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Plank {PlankName} \t is full {WorkLoad} of {Area} \t Plants:");
            int Plantarea = 0;
            for (int i = 0; i < PlantsOnPlank.Count; i++)
            {
                PlantsOnPlank[i].GetInfo();
                Plantarea += PlantsOnPlank[i].Area;
            }
            Console.WriteLine($"percentage is {Plantarea * 100 / Area} %");
        }

    }
}
