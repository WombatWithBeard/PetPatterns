using System;
using FactoryMethod.Creators;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main()
        {
            var creator = new Creator();
            
            var product = creator.Create("First");
            Console.WriteLine(product.Name);
            
            var product2 = creator.Create("Second");
            Console.WriteLine(product2.Name);
        }
    }
}