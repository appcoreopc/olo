using System.Collections.Generic;
using System.Linq;

namespace olo
{
    public class TopPizzaSelector
    {
        private const string Separator = ",";
        Dictionary<string, int> DataMapper = new Dictionary<string, int>();

        internal void Process(IList<PizzaModel> model)
        {
            foreach (var item in model)
            {
                var key = string.Join(Separator, item.Toppings);
                MapCountItem(key);
            }
        }

        private void MapCountItem(string key, int count = 1)
        {   
            if (DataMapper.TryGetValue(key, out int currentValue))
                DataMapper[key] = currentValue + count;
            else 
                DataMapper.TryAdd(key, count);
        }

        internal IEnumerable<KeyValuePair<string,int>> GetTop(int topItem)
        {
            return DataMapper.OrderByDescending(x => x.Value).Take(topItem);
        }
    }
}