using System;

namespace CaffeineBeverage.Beverages
{
    internal abstract class CaffeineBeverageWithHook
    {
        internal void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        internal virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        internal abstract void Brew();
        
        internal abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
