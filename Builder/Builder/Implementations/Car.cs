using Builder.Abstractions;
using Builder.Implementations.Common;
using Builder.Implementations.Extra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Implementations.Common.Enums;

namespace Builder.Implementations
{
    public class Car
    {
        public IEngine Engine { get; set; } = new FuelEngine();
        public int Seats { get; set; } = 4;
        public bool GPS { get; set; } = false;
        public Transmission Transmission { get; set; } = Transmission.Mechanical;

        public override string ToString()
        {
            return $"Engine: {this.Engine} | Seats: {this.Seats} | HasGPS: {this.GPS} | Transmission: {Transmission.GetName(this.Transmission)}";
        }
    }
}
