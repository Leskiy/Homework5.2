using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5._2
{
    public class Animal
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public List<Product> Products { get; set; }
        public int WorkLoad { get; set; }
        public void GetProduct()
        {
            Products = new List<Product>();
            Products.Add(new Product());
        }
        public void GetInfo()
        {
            Console.WriteLine($"Animal {Name} \t ({Area} areas) \t give products:");
            for (int i = 0; i < Products.Count; i++)
            {
                Products[i].GetInfo();
            }
        }

    }
}
