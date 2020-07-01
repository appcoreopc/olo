using Xunit;
using System.Linq;

namespace Olo.Topping.Core.UnitTests
{
    public class TopPizzaSelectorTests : BaseTest
    {
        [Fact]
        public void WhenKeyAreMapToDictionaryThenValueMustBeLowerCase()
        {
            var target = new TopPizzaSelector();
            target.Process(GetTwoTypesPizzaToppingData());
            var result = target.GetTop(10).ToArray();
            
            Assert.Equal("pepperoni", result[0].Key);
            Assert.Equal("hawaian", result[1].Key);
        }

        [Fact]
        public void WhenCountRequestedIsHigherThanExistingCountValueThenReturnCountAvailable()
        {
            var target = new TopPizzaSelector();
            target.Process(GetTwoTypesPizzaToppingData());
            var result = target.GetTop(10);
            Assert.True(result.Count() == 2);
        }

        [Fact]
        public void WhenPizzaToppingsAreDifferentThenItCountWillNotBeAdded()
        {
            var target = new TopPizzaSelector();
            target.Process(GetTrickyPepperPizzaToppingData());
            var result = target.GetTop(10).ToArray();
            Assert.True(result.Count() == 6);
        }

        [Fact]
        public void WhenTop3AreRequestedThenCountGivenMustBe()
        {
            var target = new TopPizzaSelector();
            target.Process(GetTrickyPepperPizzaToppingData());
            var result = target.GetTop(3).ToArray();
            Assert.True(result.Count() == 3);
        }
    }
}
