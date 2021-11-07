using D006.SimpleFactory.TypeInResource.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D006.SimpleFactory.TypeInResource.Factory
{
    public static class ProductFactory
    {
        public static IProduct GetProduct(ProductType productType)
        {
            var type = ProductTypeResource.GetProductType(productType);
            return Activator.CreateInstance(type) as IProduct;
        }
    }
}
