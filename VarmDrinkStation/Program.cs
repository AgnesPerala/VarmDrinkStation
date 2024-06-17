using System;
using System.Collections.Generic;
using System.Linq;
using VarmDrinkStation.Factory;

namespace VarmDrinkStation
{
    // Definierar ett interface för varma drycker
    public interface IWarmDrink
    {
        void Consume(); // Metod för att konsumera drycken
    }

    // Implementerar en specifik varm dryck, i detta fall vatten
    internal class Water : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Warm water is served."); // Utskrift vid konsumtion av vatten
        }
    }
    internal class Coffee : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Coffee is served.");
        }
    }
    internal class Cappuccino : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Cappuccino is served.");
        }
    }
    internal class Chocolate : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Chocolate is served.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new WarmDrinkMachine(); // Skapar en instans av WarmDrinkMachine
            IWarmDrink drink = machine.MakeDrink(); // Skapar en dryck
            drink.Consume(); // Konsumerar drycken
        }
    }
}

