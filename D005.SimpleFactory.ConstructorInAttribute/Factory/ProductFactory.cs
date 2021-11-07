using D005.SimpleFactory.ConstructorInAttribute.CustomAttribute;
using D005.SimpleFactory.ConstructorInAttribute.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D005.SimpleFactory.ConstructorInAttribute.Factory
{
    public static class ProductFactory
    {
        public static IProduct GetProduct(ProductType productType)
        {
            var constructorDelegate = ProductTypeHelper.GetProdcutConstructorDelegate(productType);
            return constructorDelegate.Invoke() as IProduct;
        }
    }
}
