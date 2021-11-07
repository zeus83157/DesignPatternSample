using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D002.FactoryMethod.Interface.Product
{
    internal class AProduct : IProduct
    {
        public void Show()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
