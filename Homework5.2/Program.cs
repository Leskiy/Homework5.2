using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //названия и параметры растений
            Plant Burachok = CreatePlant("Burachok", 2, "Spring", "Authemn");
            Plant Pumpkin = CreatePlant("Pumpkin", 3, "Spring", "Authemn");
            Plant Onion = CreatePlant("Onion", 1, "Authemn", "Summer");
            Plant Garlic = CreatePlant("Garlic", 1, "Authemn", "Summer");

            //названия и параметры грядок
            Plank Gr01 = GetPlank("Gr01", 10);
            Gr01.PlantsOnPlank.Add(Burachok); Gr01.WorkLoad += Burachok.Area;
            Gr01.PlantsOnPlank.Add(Burachok); Gr01.WorkLoad += Burachok.Area;
            Gr01.PlantsOnPlank.Add(Burachok); Gr01.WorkLoad += Burachok.Area;
            Gr01.PlantsOnPlank.Add(Burachok); Gr01.WorkLoad += Burachok.Area;
            //Gr01.GetInfo();
            Plank Gr02 = GetPlank("Gr02", 8);
            Gr02.PlantsOnPlank.Add(Burachok); Gr02.WorkLoad += Burachok.Area;
            Gr02.PlantsOnPlank.Add(Pumpkin); Gr02.WorkLoad += Burachok.Area;
            Gr02.PlantsOnPlank.Add(Onion); Gr02.WorkLoad += Burachok.Area;
            Gr02.PlantsOnPlank.Add(Onion); Gr02.WorkLoad += Burachok.Area;
            //Gr02.GetInfo();
            Plank Gr03 = GetPlank("Gr03", 7);
            Gr03.PlantsOnPlank.Add(Pumpkin); Gr03.WorkLoad += Burachok.Area;
            Gr03.PlantsOnPlank.Add(Pumpkin); Gr03.WorkLoad += Burachok.Area;
            Gr03.PlantsOnPlank.Add(Garlic); Gr03.WorkLoad += Burachok.Area;
            //Gr03.GetInfo();

            //названия параметры продуктов
            Product Milk = CreateProduct("Milk", 20);
            Product Chease = CreateProduct("Chease", 10);
            Product Meat = CreateProduct("Meat", 5);
            Product Egg = CreateProduct("Egg", 1);
            Product Feather = CreateProduct("Feather", 1);

            //название параметры животных
            Animal Korova = GetProduct("Korova", 5);
            Korova.Products.Add(Milk);
            Korova.Products.Add(Chease);
            Korova.Products.Add(Meat);

            Animal Chiken = GetProduct("Chiken", 5);
            Chiken.Products.Add(Egg);
            Chiken.Products.Add(Feather);

            //название и параметры здания
            Building Hlev = GetAnimal("Hlev", 30);
            Hlev.Animals.Add(Korova);

            Building ChikenCoop = GetAnimal("ChikenCoop", 10);
            ChikenCoop.Animals.Add(Chiken);
            ChikenCoop.Animals.Add(Chiken);
            ChikenCoop.Animals.Add(Chiken);
            ChikenCoop.Animals.Add(Chiken);

            //сама ферма
            Farm Bitardsk = GetFarm("Bitardsk", 150);
            Bitardsk.Buildings.Add(Hlev);
            Bitardsk.Buildings.Add(ChikenCoop);
            Bitardsk.Planks.Add(Gr01);
            Bitardsk.Planks.Add(Gr02);
            Bitardsk.Planks.Add(Gr03);

            Bitardsk.GetInfo();

            //метод создания растения
            static Plant CreatePlant(string PlantName, int Area, string PlantingSeason, string HarvestSeason)
            {
                Plant plant = new Plant { PlantName = PlantName, Area = Area, PlantingSeason = PlantingSeason, HarvestSeason = HarvestSeason };
                return plant;
            }

            //метод добавления растений на грядку
            static Plank GetPlank(string name, int area)
            {
                Plank plank = new Plank() { PlankName = name };
                plank.PlantsOnPlank = new List<Plant>();
                plank.Area = area;
                return plank;
            }

            //метод продукта
            static Product CreateProduct(string Name, int Weight)
            {
                Product product = new Product { Name = Name, Weight = Weight };
                return product;
            }

            //метод создания и добавления животного продукта 
            static Animal GetProduct(string Name, int Area)
            {
                Animal animal = new Animal() { Name = Name };
                animal.Products = new List<Product>();
                animal.Area = Area;
                return animal;
            }

            //метод создания зданий с животными
            static Building GetAnimal(string Name, int Area)
            {
                Building building = new Building() { Name = Name };
                building.Animals = new List<Animal>();
                building.Area = Area;
                return building;
            }

            //метод создания фермы, грядок, строений
            static Farm GetFarm(string farmaName, int farmaArea)
            {
                Farm ferma = new Farm() { farmaName = farmaName };
                ferma.Buildings = new List<Building>();
                ferma.Planks = new List<Plank>();
                ferma.farmaArea = farmaArea;
                return ferma;
            }


        }
    }
}
