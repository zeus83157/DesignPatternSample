using E002.AbstractFactory.AbstractClass.Factory;
using E002.AbstractFactory.AbstractClass.Product;
using E002.AbstractFactory.AbstractClass.SubProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E002.AbstractFactory.AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseFactory gen1_Factory = new Gen1_Factory();
            BaseProduct gen1_Product = gen1_Factory.GetProduct();
            BaseSubProduct gen1_SubProduct = gen1_Factory.GetSubProduct();
            gen1_Product.ShowProduct();
            gen1_SubProduct.ShowSubProduct();

            BaseFactory gen2_Factory = new Gen2_Factory();
            BaseProduct gen2_Product = gen2_Factory.GetProduct();
            BaseSubProduct gen2_SubProduct = gen2_Factory.GetSubProduct();
            gen2_Product.ShowProduct();
            gen2_SubProduct.ShowSubProduct();

            Console.ReadLine();
        }
    }
}
