using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTests
{
    internal class CollectionInsertSpeedTests : AbsSpeedTest
    {
        public CollectionInsertSpeedTests(int totalRuns = 10000000) : base(totalRuns)
        {

        }

        public void RunTests()
        {
            Console.WriteLine($"Insert string ConcurrentQueue: ms {ConcurrentQueueStringCreateTest()}");
            Console.WriteLine($"Insert int ConcurrentQueue: ms {ConcurrentQueueIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Insert string LinkedList: ms {LinkedListStringCreateTest()}");
            Console.WriteLine($"Insert int LinkedList: ms {LinkedListIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Insert string Queue: ms {QueueStringCreateTest()}");
            Console.WriteLine($"Insert int Queue: ms {QueueIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Insert string Array: ms {ArrayStringCreateTest()}");
            Console.WriteLine($"Insert int Array: ms {ArrayIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Insert string List: ms {ListStringCreateTest()}");
            Console.WriteLine($"Insert int List: ms {ListIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Insert string Dictionary: ms {DictionaryStringCreateTest()}");
            Console.WriteLine($"Insert int Dictionary: ms {DictionaryIntCreateTest()}");
            Console.WriteLine("");

            Console.WriteLine($"Insert string HashSet: ms {HashSetStringCreateTest()}");
            Console.WriteLine($"Insert int HashSet: ms {HashSetIntCreateTest()}");
            Console.WriteLine("");
        }

        protected long ConcurrentQueueStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                ConcurrentQueue<string> list = new ConcurrentQueue<string>();
                watch.Start();
                list.Enqueue("data");
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long ConcurrentQueueIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                ConcurrentQueue<int> list = new ConcurrentQueue<int>();
                watch.Start();
                list.Enqueue(1);
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
        protected long LinkedListStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                LinkedList<string> list = new LinkedList<string>();
                watch.Start();
                list.AddLast("data");
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long LinkedListIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                LinkedList<int> list = new LinkedList<int>();
                watch.Start();
                list.AddLast(1);
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long QueueStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                Queue<string> list = new Queue<string>();
                watch.Start();
                list.Enqueue("data");
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long QueueIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                Queue<int> list = new Queue<int>();
                watch.Start();
                list.Enqueue(1);
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long ArrayStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                string[] list = new string[10];
                watch.Start();
                list[0] = "data";
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long ArrayIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                int[] list = new int[10];
                watch.Start();
                list[0] = 1;
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long ListStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                List<string> list = new List<string>();
                watch.Start();
                list.Add("data");
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long ListIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                List<int> list = new List<int>();
                watch.Start();
                list.Add(1);
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long DictionaryStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                Dictionary<string, string> list = new Dictionary<string, string>();
                watch.Start();
                list["0"] = "data";
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long DictionaryIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                Dictionary<int, int> list = new Dictionary<int, int>();
                watch.Start();
                list[1] = 1;
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long HashSetStringCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                HashSet<string> list = new HashSet<string>();
                watch.Start();
                list.Add("data");
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        protected long HashSetIntCreateTest()
        {
            watch.Restart();
            for (int i = 0; i < totalRuns; i++)
            {
                watch.Stop();
                HashSet<int> list = new HashSet<int>();
                watch.Start();
                list.Add(1);
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
