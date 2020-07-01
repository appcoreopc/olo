
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace olo
{
    class Program
    {
        static async Task Main(string[] args)
        {
           var content =  await new JsonFileReader().GetJsonFileContent("./pizza-small.json");
           var model =  JsonConvert.DeserializeObject<IList<PizzaModel>>(content);

           var pizzaSelector = new TopPizzaSelector();

            pizzaSelector.Process(model);

            pizzaSelector.GetTop(10);

        }
    }
}
