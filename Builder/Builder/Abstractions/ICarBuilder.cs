using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Implementations.Common.Enums;

namespace Builder.Abstractions
{
    public interface ICarBuilder
    {
        void Reset();
        void SetSeats(int seatsAmount);
        void SetEngine(IEngine engine);
        void SetTransmission(Transmission transmission);
        void SetGPS();
    }
}
