using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation.Factory
{
    // Definierar ett interface för fabriker som kan skapa varma drycker
    public interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(int total); // Metod för att förbereda drycken med en specifik mängd
    }

}
