using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    /// <summary>
    /// Represents and Order that contains a collection of items.
    ///
    /// Care should be taken to ensure that this class is immutable since it
    /// is sent to other systems for processing that should not be able
    /// to change it in any way.
    /// </summary>
    [Serializable]
    public class Order
    {
        private OrderItem[] orderItems;

        public Order(OrderItem[] orderItems)
        {
            this.orderItems = orderItems;
        }

        /// <summary>
        /// Returns the total order cost after the tax has been applied.
        /// </summary>
        /// <param name="taxRate">the rate to tax applicable items</param>
        /// <returns>Total rounded to nearest penny.</returns>
        public float GetOrderTotal(float taxRate)
        {

            float total = 0f;
            
            for (int i = 0; i < orderItems.Length; i++)
            {
                if (orderItems[i].GetItem() is Service)
                    total += orderItems[i].GetTotal() + (orderItems[i].GetTotal() * taxRate);
                else
                    total += orderItems[i].GetTotal();
            }
            
            return (float) Math.Round(total, 2);
        }

        /**
         * Returns a Collection of all items sorted by item name
         * (case-insensitive).
         *
         * @return ICollection<Item>
         */
        public ICollection<Item> GetItems()
        {
            return orderItems
                .Select(o => o.GetItem())
                .OrderBy(i => i.GetName())
                .ToList();
        }
    }
}