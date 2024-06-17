using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation.Factory
{
    // Implementerar en specifik fabrik som förbereder kaffe
    internal class CoffeeFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Brew {total} ml of coffee.");
            return new Coffee();
        }
    }
}
