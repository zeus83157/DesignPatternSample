using D001.FactoryMethod.AbstractClass.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D001.FactoryMethod.AbstractClass.Factory
{
    public class BProductFactory : BaseFactory
    {
        protected override Type ProductType => typeof(BProduct);
    }
}
