using Prototype.Implementations;
using System;

namespace Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(3, 4);
            var square = new Square(4);

            Console.WriteLine(triangle);
            Console.WriteLine(square);

            var cloneableTriangle = triangle.Clone();
            var cloneableSquare = square.Clone();

            Console.WriteLine(cloneableTriangle);
            Console.WriteLine(cloneableSquare);
        }
    }
}
