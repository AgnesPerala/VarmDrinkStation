using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation.Factory
{
    // Implementerar en specifik fabrik som förbereder Cappuccino
    internal class CappuccinoFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Brew {total} ml of Cappuccino.");
            return new Coffee();
        }
    }
}
