using D005.SimpleFactory.ConstructorInAttribute.CustomAttribute;
using D005.SimpleFactory.ConstructorInAttribute.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D005.SimpleFactory.ConstructorInAttribute.Factory
{
    public enum ProductType
    {
        [ProductType(typeof(AProduct))]
        AProduct,

        [ProductType(typeof(BProduct))]
        BProduct
    }
}
