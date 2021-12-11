using Builder.Implementations;
using System;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new CarBuilder();
            var director = new Director(builder);

            director.MakeSportCar();
            var sportCar = builder.GetResult();
            Console.WriteLine(sportCar);

            director.MakeOrdinaryCar();
            var ordinaryCar = builder.GetResult();
            Console.WriteLine(ordinaryCar);

            director.MakeDieselCar();
            var dieselCar = builder.GetResult();
            Console.WriteLine(dieselCar);
        }
    }
}
