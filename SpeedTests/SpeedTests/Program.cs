using System;

namespace SpeedTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var collectionCreateSpeedTests =  new CollectionCreateSpeedTests();
            collectionCreateSpeedTests.RunTests();
            Console.WriteLine("-------------------------------------------------");
            var collectionInsertSpeedTests = new CollectionInsertSpeedTests();
            collectionInsertSpeedTests.RunTests();

            Console.WriteLine("Hello World!");
        }
    }
}
