using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    [Serializable]
    public class Material : Item
    {
        public Material(int key, string name, float price) : base(key, name, price)
        {
        }
    }
}
