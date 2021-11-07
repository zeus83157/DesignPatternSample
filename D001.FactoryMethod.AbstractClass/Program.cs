using D001.FactoryMethod.AbstractClass.Factory;
using D001.FactoryMethod.AbstractClass.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D001.FactoryMethod.AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseFactory aFactory = new AProductFactory();
            IProduct aProduct = aFactory.GetProduct();
            aProduct.Show();

            BaseFactory bFactory = new BProductFactory();
            IProduct bProduct = bFactory.GetProduct();
            bProduct.Show();

            Console.ReadLine();
        }
    }
}
