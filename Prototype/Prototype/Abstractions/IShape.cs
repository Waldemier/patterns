using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Abstractions
{
    public interface IShape
    {
        double CalculateArea();
        IShape Clone();
    }
}
