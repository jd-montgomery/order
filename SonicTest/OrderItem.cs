using System;

namespace Exam
{
    /// <summary>
    /// Represents an item in an order.
    /// </summary>
    [Serializable]
    public class OrderItem
    {
        private Item item;
        private float quantity;

        public OrderItem(Item item, float quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }

        public Item GetItem()
        {
            return this.item;
        }

        public float GetTotal()
        {
            return this.item.GetPrice() * this.quantity;
        }
    }
}
