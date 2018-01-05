using System;

namespace CaffeineBeverage.Beverages
{
    internal class Coffee : CaffeineBeverageWithHook
    {
        internal override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        internal override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        internal override bool CustomerWantsCondiments()
        {
            return GetUserInput();
        }

        private bool GetUserInput()
        {
            Console.Write("Would you like Sugar and Milk with your coffee (y/n)? ");
            var answer = Console.ReadLine();

            return answer == "y";
        }
    }
}
