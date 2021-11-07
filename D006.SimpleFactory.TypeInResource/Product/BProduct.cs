using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D006.SimpleFactory.TypeInResource.Product
{
    internal class BProduct : IProduct
    {
        public void Show()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
