using Prototype.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Implementations
{
    public class Square : IShape
    {
        private double Side { get; set; }
        private double Diagonal { get; set; }

        private Square(Square shape)
        {
            Side = shape.Side;
            Diagonal = shape.Diagonal;
        }

        public Square(double side)
        {
            Side = side;
            Diagonal = Side * Math.Sqrt(2);
        }

        public double CalculateArea()
        {
            return Math.Pow(Diagonal, 2) / 2;
        }

        public IShape Clone()
        {
            return new Square(this);
        }

        public override string ToString()
        {
            return $"Side: {this.Side} | Diagonal: {this.Diagonal} | Area: {this.CalculateArea()}";
        }
    }
}
