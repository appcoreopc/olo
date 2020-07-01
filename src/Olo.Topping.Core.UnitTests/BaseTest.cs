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

        protected IEnumerable<PizzaModel> GetTrickyPepperPizzaToppingData()
        {
            return new List<PizzaModel>()
            {
                new PizzaModel {
                        Toppings = new string[] {"Pepperoni"}
                },
                new PizzaModel {
                        Toppings = new string[] {"cheese"}
                },
                new PizzaModel {
                        Toppings = new string[] {"mushroom"}
                },
                 new PizzaModel {
                        Toppings = new string[] {"pepper"}
                },
                new PizzaModel {
                        Toppings = new string[] {"pepper", "pepper1", "pepper2"}
                },
                new PizzaModel {
                        Toppings = new string[] {"pepper", "pepper2", "pepper4"}
                }
            };
        }
    }
}