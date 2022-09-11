using NUnit.Framework;
using System.Collections.Generic;

namespace CollectionGenericTests
{
    public class CollectionCreateTests
    {
        const int totalRuns = 10000;
        [OneTimeSetUp]
        public void Setup()
        {
        }

        [Test]
        [Order(1)]
        public void ListCreateTest()
        {
            for (int i = 0; i < totalRuns; i++)
            {
                List<string> list = new List<string>();
            }
            Assert.Pass();
        }

        [Test]
        [Order(2)]
        public void DictionaryCreateTest()
        {
            for (int i = 0; i < totalRuns; i++)
            {
                Dictionary<string,string> list = new Dictionary<string, string>();
            }
            Assert.Pass();
        }

        [Test]
        [Order(3)]
        public void HashSetCreateTest()
        {
            for (int i = 0; i < totalRuns; i++)
            {
                HashSet<string> list = new HashSet<string>();
            }
            Assert.Pass();
        }
    }
}