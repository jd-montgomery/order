using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam;

namespace UnitTests
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void OrderItemsShouldBeSortedByName()
        {
            var order = new Order(GetOrderItems());
            string[] expectedSort = { "Alpha", "Bravo", "Charlie" };
            var actual = order.GetItems().Select(i => i.GetName()).ToArray();
            Assert.AreEqual(expectedSort[0], actual[0]);
            Assert.AreEqual(expectedSort[1], actual[1]);
            Assert.AreEqual(expectedSort[2], actual[2]);
        }

        [TestMethod]
        public void OrderTotalShouldIncludeTaxes()
        {
            var o = new Order(GetOrderItems());
            Assert.AreEqual(15.30f, o.GetOrderTotal(0.0825f));
        }

        private OrderItem[] GetOrderItems()
        {
            OrderItem[] orderItems = { new OrderItem(new Service(0, "Charlie", 1), 1),
                                       new OrderItem(new Material(1, "Alpha", 2), 2),
                                       new OrderItem(new Service(2, "Bravo", 3.3234f), 3) };
            return orderItems;
        }
    }
}
