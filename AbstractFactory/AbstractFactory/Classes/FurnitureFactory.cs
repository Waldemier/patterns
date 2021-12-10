using AbstractFactory.Abstractions;

namespace AbstractFactory.Classes
{
    public abstract class FurnitureFactory
    {
        public abstract IChair CreateChair();
        public abstract ITable CreateTable();
    }
}
