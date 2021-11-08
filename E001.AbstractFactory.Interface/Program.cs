using E001.AbstractFactory.Interface.Factory;
using E001.AbstractFactory.Interface.Product;
using E001.AbstractFactory.Interface.SubProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E001.AbstractFactory.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory gen1_Factory = new Gen1_Factory();
            IProduct gen1_Product = gen1_Factory.GetProduct();
            ISubProduct gen1_SubProduct = gen1_Factory.GetSubProduct();
            gen1_Product.ShowProduct();
            gen1_SubProduct.ShowSubProduct();

            IFactory gen2_Factory = new Gen2_Factory();
            IProduct gen2_Product = gen2_Factory.GetProduct();
            ISubProduct gen2_SubProduct = gen2_Factory.GetSubProduct();
            gen2_Product.ShowProduct();
            gen2_SubProduct.ShowSubProduct();

            Console.ReadLine();
        }
    }
}
