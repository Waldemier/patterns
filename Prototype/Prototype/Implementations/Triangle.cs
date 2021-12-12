using Prototype.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implementations
{
    public class Triangle: IShape
    {
        private double Base { get; set; }
        private double Height { get; set; }

        private Triangle(Triangle shape)
        {
            Base = shape.Base;
            Height = shape.Height;
        }

        public Triangle(double b, double h)
        {
            Base = b;
            Height = h;
        }

        public double CalculateArea()
        {
            return (Base * Height) / 2;
        }

        public IShape Clone()
        {
            return new Triangle(this);
        }

        public override string ToString()
        {
            return $"Base: {this.Base} | Height: {this.Height} | Area: {this.CalculateArea()}";
        }
    }
}
