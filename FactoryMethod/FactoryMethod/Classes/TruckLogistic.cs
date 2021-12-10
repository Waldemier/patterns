using FactoryMethod.Abstractions;
using FactoryMethod.Classes.Entities;
using System.Collections.Generic;

namespace FactoryMethod.Classes
{
    public class TruckLogistic : Logistic
    {
        public List<Truck> Trucks { get; set; }

        public TruckLogistic()
        {
            Trucks = new List<Truck>();
        }

        public override ITransport MakeTransport()
        {
            var instance = new Truck();
            Trucks.Add(instance);
            return instance;
        }
    }
}
