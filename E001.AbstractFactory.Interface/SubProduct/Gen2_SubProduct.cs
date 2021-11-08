using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E001.AbstractFactory.Interface.SubProduct
{
    internal class Gen2_SubProduct : ISubProduct
    {
        public void ShowSubProduct()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
