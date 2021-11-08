using E001.AbstractFactory.Interface.Product;
using E001.AbstractFactory.Interface.SubProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E001.AbstractFactory.Interface.Factory
{
    public interface IFactory
    {
        IProduct GetProduct();
        ISubProduct GetSubProduct();
    }
}
