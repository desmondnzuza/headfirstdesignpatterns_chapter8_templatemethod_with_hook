using System;
using CaffeineBeverage.Beverages;

namespace CaffeineBeverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Coffee();
            var tea = new Tea();

            Console.WriteLine("Making Tea...");
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking Coffee...");
            coffee.PrepareRecipe();

            Console.ReadLine();
        }
    }
}
