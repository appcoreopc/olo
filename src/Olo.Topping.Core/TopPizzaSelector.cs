using System.Collections.Generic;
using System.Linq;

namespace Olo
{
    public class TopPizzaSelector : ITopSelector
    {
        private const string Separator = ",";
        Dictionary<string, int> DataMapper = new Dictionary<string, int>();

        public void Process(IEnumerable<PizzaModel> model)
        {
            foreach (var item in model)
            {
                var key = string.Join(Separator, item.Toppings);
                
                MapCountItem(key.ToLower());
            }
        }

        public IEnumerable<KeyValuePair<string,int>> GetTop(int topItem)
        {
            return DataMapper.OrderByDescending(x => x.Value).Take(topItem);
        }

        private void MapCountItem(string key, int count = 1)
        {   
            if (DataMapper.TryGetValue(key, out int currentValue))
                DataMapper[key] = currentValue + count;
            else 
                DataMapper.TryAdd(key, count);
        }
    }
}
