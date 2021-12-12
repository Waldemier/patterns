using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DatabaseSample
    {
        private static readonly Object _locker = new();

        private static DatabaseSample Instance { get; set; }

        private DatabaseSample()
        {
        }

        public static DatabaseSample GetInstance()
        {
            if(Instance == null)
            {
                lock (_locker)
                {
                    // The second one, because first thread who had got there already created this instance, and the next one haven't to do that again
                    if (Instance == null)
                    {
                        Instance = new DatabaseSample();
                    }
                }
            }

            return Instance;
        }

        // Not static because it should be accessible from a real object
        public void Query(string query)
        {
            // Performs some complex logic
            Console.WriteLine(query);
        }

        public override string ToString()
        {
            return $"{this.GetHashCode()}";
        }
    }
}
