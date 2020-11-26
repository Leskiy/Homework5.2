using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5._2
{
    public class Plant
    {
        public string PlantName { get; set; }
        public int Area { get; set; }
        public string PlantingSeason { get; set; }
        public string HarvestSeason { get; set; }
        public void GetInfo() => Console.WriteLine($"Plant {PlantName} \tArea:{Area} \tPlanting Season: {PlantingSeason} \tHarvest Season {HarvestSeason}");
    }

}

