using System.Collections.Generic;
namespace Olo
{
    public interface ITopSelector
    {
        void Process(IEnumerable<PizzaModel> model);

        IEnumerable<KeyValuePair<string,int>> GetTop(int topItem);
    }
}