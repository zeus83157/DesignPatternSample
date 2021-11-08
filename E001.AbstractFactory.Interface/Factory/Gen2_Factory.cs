using E001.AbstractFactory.Interface.Product;
using E001.AbstractFactory.Interface.SubProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E001.AbstractFactory.Interface.Factory
{
    public class Gen2_Factory : IFactory
    {
        public IProduct GetProduct()
        {
            return new Gen2_Product();
        }

        public ISubProduct GetSubProduct()
        {
            return new Gen2_SubProduct();
        }
    }
}
