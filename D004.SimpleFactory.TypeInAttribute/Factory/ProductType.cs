using D004.SimpleFactory.TypeInAttribute.CustomAttribute;
using D004.SimpleFactory.TypeInAttribute.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D004.SimpleFactory.TypeInAttribute.Factory
{
    public enum ProductType
    {
        [ProductType(typeof(AProduct))]
        AProduct,

        [ProductType(typeof(BProduct))]
        BProduct
    }
}
