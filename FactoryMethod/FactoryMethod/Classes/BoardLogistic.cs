using FactoryMethod.Abstractions;
using System.Collections.Generic;

namespace FactoryMethod.Classes
{
    public class BoardLogistic : Logistic
    {
        public List<Board> Boards { get; set; }

        public BoardLogistic()
        {
            Boards = new List<Board>();
        }

        public override ITransport MakeTransport()
        {
            var instance = new Board();
            Boards.Add(instance);
            return instance;
        }
    }
}
