using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Linq;

namespace PizzaToppings
{
    class Program
    {
        static void Main(string[] args)
        {
            //read a file from disk
            var json = File.ReadAllText("./toppings.json");
            //deserialize from json to C#
            //property names in json and C# need to match
            var toppingSelections = JsonConvert.DeserializeObject<List<PizzaSelection>>(json);

            var justToppings = new List<string>();
            foreach (var topping in toppingSelections)
            {
                var toppingString = string.Join(", ", topping.Toppings);
                justToppings.Add(toppingString);
            }

            var distinctToppings = justToppings.Distinct();

            Dictionary<string, int> toppingsCount = new Dictionary<string, int>();
            foreach (var distinctTopping in distinctToppings)
            {
                int count = justToppings.Where(topping => topping == distinctTopping).Count();
                toppingsCount.Add(distinctTopping, count);
            }

            var rankedPizzas = toppingsCount.OrderBy(x => x.Value).ToDictionary(x=> x.Key, x=>x.Value);

            var topPizzas = rankedPizzas.TakeLast(20).Reverse();
            Console.WriteLine("Top 20 Pizza Toppings\n-----------------------------");
            foreach (var (topping, count) in topPizzas)
            {
                Console.WriteLine($"{topping}: {count}");
            }
        }
    }
}
