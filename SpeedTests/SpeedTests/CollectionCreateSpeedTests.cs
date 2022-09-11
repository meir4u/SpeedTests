using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTests
{
    internal class CollectionCreateSpeedTests : AbsSpeedTest
    {
        public CollectionCreateSpeedTests(int totalRuns = 10000000) : base(totalRuns)
        {

        }

        public void RunTests()
        {
            Console.WriteLine($"Create string ConcurrentQueue: ms {ConcurrentQueueStringCreateTest()}");
            Console.WriteLine($"Create int ConcurrentQueue: ms {ConcurrentQueueIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Create string LinkedList: ms {LinkedListStringCreateTest()}");
            Console.WriteLine($"Create int LinkedList: ms {LinkedListIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Create string Queue: ms {QueueStringCreateTest()}");
            Console.WriteLine($"Create int Queue: ms {QueueIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Create string Array: ms {ArrayStringCreateTest()}");
            Console.WriteLine($"Create int Array: ms {ArrayIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Create string List: ms {ListStringCreateTest()}");
            Console.WriteLine($"Create int List: ms {ListIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Create string Dictionary: ms {DictionaryStringCreateTest()}");
            Console.WriteLine($"Create int Dictionary: ms {DictionaryIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Create string HashSet: ms {HashSetStringCreateTest()}");
            Console.WriteLine($"Create int HashSet: ms {HashSetIntCreateTest()}");
            Console.WriteLine("");
        }

        protected long ConcurrentQueueStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                ConcurrentQueue<string> list = new ConcurrentQueue<string>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long ConcurrentQueueIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                ConcurrentQueue<int> list = new ConcurrentQueue<int>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
        protected long LinkedListStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                LinkedList<string> list = new LinkedList<string>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long LinkedListIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                LinkedList<int> list = new LinkedList<int>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long QueueStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                Queue<string> list = new Queue<string>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long QueueIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                Queue<int> list = new Queue<int>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long ArrayStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                string[] list = new string[10];
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long ArrayIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                int[] list = new int[10];
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long ListStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                List<string> list = new List<string>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long ListIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                List<int> list = new List<int>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long DictionaryStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                Dictionary<string, string> list = new Dictionary<string, string>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long DictionaryIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                Dictionary<int, int> list = new Dictionary<int, int>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long HashSetStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                HashSet<string> list = new HashSet<string>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long HashSetIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                HashSet<int> list = new HashSet<int>();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
