using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation.Factory
{
    // Implementerar en specifik fabrik som förbereder Chocolate
    internal class ChocolateFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml of Chocolate in your cup!.");
            return new Coffee();
        }
    }
}
