using D007.SimpleFactory.ConstructorInResource.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D007.SimpleFactory.ConstructorInResource.Factory
{
    public static class ProductFactory
    {
        public static IProduct GetProduct(ProductType productType)
        {
            var constructorDelegate = ProductTypeResource.GetConstructorDelegate(productType);
            return constructorDelegate.Invoke() as IProduct;
        }
    }
}
