using FactoryMethod.Classes;
using System;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            var truckLogistic = new TruckLogistic();
            var boardLogistic = new BoardLogistic();
            var logistics = new Logistic[] { truckLogistic, boardLogistic };

            foreach (Logistic logistic in logistics)
            {
                logistic.DoWork();
                logistic.MakeTransport();
                logistic.MakeTransport();
                logistic.MakeTransport();
            }

            // Showing created trucks
            foreach (var truck in truckLogistic.Trucks)
            {
                Console.WriteLine(truck);
            }

            // Showing created boards
            foreach (var board in boardLogistic.Boards)
            {
                Console.WriteLine(board);
            }
        }
    }
}
