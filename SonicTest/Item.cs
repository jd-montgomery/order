using System;

namespace Exam
{
    /// <summary>
    /// Represents a part or service that can be sold.
    ///
    /// Care should be taken to ensure that this class is immutable since it
    /// is sent to other systems for processing that should not be able to
    /// change it in any way.
    ///
    /// </summary>
    [Serializable]
    public abstract class Item
    {
        private int key;
        private string name;
        private float price;

        public Item(int key, string name, float price)
        {
            this.key = key;
            this.name = name;
            this.price = price;
        }

        public int GetKey()
        {
            return key;
        }

        public string GetName()
        {
            return name;
        }

        public float GetPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return $"[{key}] {name} @ {price.ToString("C")}";
        }

        public override bool Equals(object obj)
        {
            var otherItem = obj as Item;

            if (otherItem == null)
                return false;

            return otherItem.key == key
                && otherItem.name == name
                && otherItem.price == price;
        }

        public override int GetHashCode()
        {
            return this.key;
        }
    }
}
