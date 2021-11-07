using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D007.SimpleFactory.ConstructorInResource.Product
{
    internal class BProduct : IProduct
    {
        public void Show()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
