using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D005.SimpleFactory.ConstructorInAttribute.Product
{
    internal class AProduct : IProduct
    {
        public void Show()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
