using AbstractFactory.Abstractions;
using AbstractFactory.Classes.Entities;
using System.Collections.Generic;

namespace AbstractFactory.Classes
{
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public List<ModernChair> Chairs { get; set; }
        public List<ModernTable> Tables { get; set; }

        public ModernFurnitureFactory()
        {
            Chairs = new List<ModernChair>();
            Tables = new List<ModernTable>();
        }

        public override IChair CreateChair()
        {
            var chair = new ModernChair();
            Chairs.Add(chair);
            return chair;
        }

        public override ITable CreateTable()
        {
            var table = new ModernTable();
            Tables.Add(table);
            return table;
        }

        public override string ToString()
        {
            return $"{nameof(ModernFurnitureFactory)} | Chairs: {Chairs.Count} | Tables: {Tables.Count}";
        }
    }
}
