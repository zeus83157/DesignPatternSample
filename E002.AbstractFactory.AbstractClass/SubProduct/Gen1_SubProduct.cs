using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E002.AbstractFactory.AbstractClass.SubProduct
{
    internal class Gen1_SubProduct : BaseSubProduct
    {
        public override void ShowSubProduct()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
