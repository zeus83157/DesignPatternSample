using D006.SimpleFactory.TypeInResource.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D006.SimpleFactory.TypeInResource.Factory
{
    static internal class ProductTypeResource
    {
        private static Dictionary<ProductType, Type> _Resource;
        static ProductTypeResource()
        {
            _Resource = new Dictionary<ProductType, Type>
            {
                { ProductType.AProduct, typeof(AProduct)},
                { ProductType.BProduct, typeof(BProduct)},
            };
        }
        internal static Type GetProductType(ProductType productType)
        {
            if (_Resource.ContainsKey(productType))
                return _Resource[productType];
            else
            { 
                throw new ArgumentOutOfRangeException();   
            }
        }
    }
}
