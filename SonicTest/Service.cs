using System;

namespace Exam
{
    /// <summary>
    /// Represents a service that can be sold.
    /// </summary>
    [Serializable]
    public class Service : Item
    {
        public Service(int key, string name, float price) : base(key, name, price)
        {
        }
    }
}
