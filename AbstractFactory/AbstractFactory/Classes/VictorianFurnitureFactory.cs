using AbstractFactory.Abstractions;
using AbstractFactory.Classes.Entities;
using System.Collections.Generic;

namespace AbstractFactory.Classes
{
    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public List<VictorianChair> Chairs { get; set; }
        public List<VictorianTable> Tables { get; set; }

        public VictorianFurnitureFactory()
        {
            Chairs = new List<VictorianChair>();
            Tables = new List<VictorianTable>();
        }

        public override IChair CreateChair()
        {
            var chair = new VictorianChair();
            Chairs.Add(chair);
            return chair;
        }

        public override ITable CreateTable()
        {
            var table = new VictorianTable();
            Tables.Add(table);
            return table;
        }

        public override string ToString()
        {
            return $"{nameof(VictorianFurnitureFactory)} | Chairs: {Chairs.Count} | Tables: {Tables.Count}";
        }
    }
}
