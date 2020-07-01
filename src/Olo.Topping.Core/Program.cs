
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Olo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please provide a json filename that contains pizza toppings (json).");
                return;
            }

            await GetPizzaToppingRanks(args);
        }

        private static async Task GetPizzaToppingRanks(string[] args)
        {
            var content = await new JsonFileReader().GetJsonFileContent(args[0]);
            var model = JsonConvert.DeserializeObject<IList<PizzaModel>>(content);

            var pizzaSelector = new TopPizzaSelector();

            pizzaSelector.Process(model);

            var rankingResult = pizzaSelector.GetTop(10);

            if (rankingResult != null && rankingResult.Count() > 0)
            {
                Console.WriteLine($"Top most ordered pizza toppings are :");
                foreach (var item in rankingResult)
                {
                    Console.WriteLine($" Ingredients {item.Key}: Count: {item.Value}");
                }
            }
            else
                Console.WriteLine($"No pizza toppings results found");

        }
    }
}
