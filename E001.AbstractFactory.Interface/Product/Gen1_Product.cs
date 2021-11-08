using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E001.AbstractFactory.Interface.Product
{
    internal class Gen1_Product : IProduct
    {
        public void ShowProduct()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
