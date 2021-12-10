using FactoryMethod.Abstractions;
using System;

namespace FactoryMethod.Classes
{
    public abstract class Logistic
    {
        public void DoWork() => Console.WriteLine("Do work");
        public abstract ITransport MakeTransport();
    }
}
