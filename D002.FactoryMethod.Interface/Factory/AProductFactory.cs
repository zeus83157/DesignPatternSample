using D002.FactoryMethod.Interface.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D002.FactoryMethod.Interface.Factory
{
    public class AProductFactory : IFactory
    {
        public IProduct GetProduct()
        {
            return new AProduct();
        }
    }
}
