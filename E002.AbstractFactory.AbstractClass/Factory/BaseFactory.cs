using E002.AbstractFactory.AbstractClass.Product;
using E002.AbstractFactory.AbstractClass.SubProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E002.AbstractFactory.AbstractClass.Factory
{
    public abstract class BaseFactory
    {
        public abstract BaseProduct GetProduct();
        public abstract BaseSubProduct GetSubProduct();
    }
}
