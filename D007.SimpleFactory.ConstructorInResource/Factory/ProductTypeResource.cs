using D007.SimpleFactory.ConstructorInResource.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D007.SimpleFactory.ConstructorInResource.Factory
{
    internal static class ProductTypeResource
    {
        private static Dictionary<ProductType, Func<object>> _Resource;
        static ProductTypeResource()
        {
            _Resource = new Dictionary<ProductType, Func<object>>
            {
                { ProductType.AProduct, () => new AProduct()},
                { ProductType.BProduct, () => new BProduct()}
            };
        }
        static internal Func<object> GetConstructorDelegate(ProductType productType)
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
