using D004.SimpleFactory.TypeInAttribute.CustomAttribute;
using D004.SimpleFactory.TypeInAttribute.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D004.SimpleFactory.TypeInAttribute.Factory
{
    public static class ProductFactory
    {
        public static IProduct GetProduct(ProductType productType)
        {
            var productInstanceType = ProductTypeHelper.GetProdcutType(productType);
            return Activator.CreateInstance(productInstanceType) as IProduct;
        }
    }
}
