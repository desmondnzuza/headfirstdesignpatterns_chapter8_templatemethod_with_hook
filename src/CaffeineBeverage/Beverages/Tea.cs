using System;

namespace CaffeineBeverage.Beverages
{
    internal class Tea : CaffeineBeverageWithHook
    {
        internal override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        internal override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        internal override bool CustomerWantsCondiments()
        {
            return GetUserInput();
        }

        private bool GetUserInput()
        {
            Console.Write("Would you like lemon with your tea (y/n)? ");
            var answer = Console.ReadLine();

            return answer == "y";
        }
    }
}
