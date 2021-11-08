using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E002.AbstractFactory.AbstractClass.Product
{
    internal class Gen1_Product : BaseProduct
    {
        public override void ShowProduct()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
