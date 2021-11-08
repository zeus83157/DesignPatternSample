using E001.AbstractFactory.Interface.Product;
using E001.AbstractFactory.Interface.SubProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E001.AbstractFactory.Interface.Factory
{
    public class Gen1_Factory : IFactory
    {
        public IProduct GetProduct()
        {
            return new Gen1_Product();
        }

        public ISubProduct GetSubProduct()
        {
            return new Gen1_SubProduct();
        }
    }
}
