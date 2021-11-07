using D005.SimpleFactory.ConstructorInAttribute.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D005.SimpleFactory.ConstructorInAttribute.CustomAttribute
{
    internal static class ProductTypeHelper
    {
        internal static Func<object> GetProdcutConstructorDelegate(ProductType productType)
        {
            var fieldInfo = typeof(ProductType).GetField(productType.ToString());
            var attribute = Attribute.GetCustomAttribute(fieldInfo, typeof(ProductTypeAttribute)) as ProductTypeAttribute;
            return attribute.ConstructorDelegate;
        }
    }
}
