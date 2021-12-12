using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var database = DatabaseSample.GetInstance();
            database.Query("SELECT * FROM Stock INNER JOIN Supplier ON SupplierId = Id");
            var database2 = DatabaseSample.GetInstance();

            Console.WriteLine($"Hash: {database} | {database2}");
        }
    }
}
