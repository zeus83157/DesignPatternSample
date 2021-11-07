using D004.SimpleFactory.TypeInAttribute.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D004.SimpleFactory.TypeInAttribute.CustomAttribute
{
    internal static class ProductTypeHelper
    {
        public static Type GetProdcutType(ProductType productType)
        {
            var fieldInfo = typeof(ProductType).GetField(productType.ToString());
            var attribute = Attribute.GetCustomAttribute(fieldInfo, typeof(ProductTypeAttribute)) as ProductTypeAttribute;
            return attribute.ProductType;
        }
    }
}
