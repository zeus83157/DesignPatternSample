using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D004.SimpleFactory.TypeInAttribute.CustomAttribute
{
    internal class ProductTypeAttribute : Attribute
    {
        internal Type ProductType { get; }
        internal ProductTypeAttribute(Type type)
        {
            ProductType = type;
        }
    }
}
