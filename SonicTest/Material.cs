using System;

namespace Exam
{
    /// <summary>
    /// Represents a material that can be sold.
    /// </summary>
    [Serializable]
    public class Material : Item
    {
        public Material(int key, string name, float price) : base(key, name, price)
        {
        }
    }
}
