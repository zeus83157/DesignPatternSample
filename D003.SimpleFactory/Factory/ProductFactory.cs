using D003.SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D003.SimpleFactory.Factory
{
    public static class ProductFactory
    {
        public static IProduct GetProduct(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.AProduct:
                    return new AProduct();
                case ProductType.BProduct:
                    return new BProduct();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
