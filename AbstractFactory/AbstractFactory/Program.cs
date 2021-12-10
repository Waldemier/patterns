using AbstractFactory.Classes;
using System;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            FurnitureFactory factory;
            var random = new Random();
            var bound = random.Next(1, 3);

            switch (bound)
            {
                case 1:
                    factory = new ModernFurnitureFactory();
                    break;
                case 2: 
                    factory = new VictorianFurnitureFactory();
                    break;
                default:
                    throw new ArgumentException("Factory hasn't been chosen.");
            }

            factory.CreateChair();
            factory.CreateChair();
            factory.CreateTable();
            factory.CreateTable();

            Console.WriteLine(factory.ToString());
        }
    }
}
