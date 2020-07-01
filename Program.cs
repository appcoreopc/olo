using System;




using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace olo
{
    class Program
    {
        static async Task Main(string[] args)
        {
           var content =  await new JsonFileReader().GetJsonFileContent("./pizza-small.json");
            var model =  JsonConvert.DeserializeObject<PizzaModel>(content);
        }
        
    }
}
