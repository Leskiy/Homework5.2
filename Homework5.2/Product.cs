using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5._2
{
    public class Product
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public void GetInfo() => Console.WriteLine($"Product {Name} \t Weights {Weight} kg");

    }
}
