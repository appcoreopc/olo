using System.Collections.Generic;

namespace Olo.Topping.Core.UnitTests
{
    public class BaseTest
    {
        protected IEnumerable<PizzaModel> GetTwoTypesPizzaToppingData()
        {
            return new List<PizzaModel>()
            {
                new PizzaModel {
                        Toppings = new string[] {"Pepperoni"}
                },
                new PizzaModel {
                        Toppings = new string[] {"Pepperoni"}
                },
                new PizzaModel {
                        Toppings = new string[] {"Pepperoni"}
                },
                 new PizzaModel {
                        Toppings = new string[] {"Hawaian"}
                },

            };
        }
    }
}