using Builder.Abstractions;
using Builder.Implementations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Implementations.Common.Enums;

namespace Builder.Implementations
{
    public class CarBuilder : ICarBuilder
    {
        private Car Car;

        public CarBuilder() => Car = new Car();

        public void Reset() => Car = new Car();

        public void SetEngine(IEngine engine) => Car.Engine = engine;

        public void SetGPS() => Car.GPS = true;

        public void SetSeats(int seatsAmount) => Car.Seats = seatsAmount;

        public void SetTransmission(Transmission transmission) => Car.Transmission = transmission;

        public Car GetResult() => Car;
    }
}
