using Builder.Abstractions;
using Builder.Implementations.Extra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Implementations.Common.Enums;

namespace Builder.Implementations
{
    public class Director
    {
        private readonly ICarBuilder Builder;

        public Director(ICarBuilder builder)
        {
            Builder = builder;
        }

        public void MakeSportCar()
        {
            Builder.Reset();
            Builder.SetSeats(2);
            Builder.SetGPS();
            Builder.SetEngine(new SportEngine());
            Builder.SetTransmission(Transmission.Automatic);
        } 
        
        public void MakeOrdinaryCar()
        {
            Builder.Reset();
            Builder.SetSeats(4);
            Builder.SetEngine(new FuelEngine());
            Builder.SetTransmission(Transmission.Mechanical);
        }

        public void MakeDieselCar()
        {
            Builder.Reset();
            Builder.SetSeats(4);
            Builder.SetEngine(new DieselEngine());
            Builder.SetTransmission(Transmission.Automatic);
        }
    }
}
