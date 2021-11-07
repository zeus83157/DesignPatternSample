using D002.FactoryMethod.Interface.Factory;
using D002.FactoryMethod.Interface.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D002.FactoryMethod.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory aFactory = new AProductFactory();
            IProduct aProduct = aFactory.GetProduct();
            aProduct.Show();

            IFactory bFactory = new BProductFactory();
            IProduct bProduct = bFactory.GetProduct();
            bProduct.Show();

            Console.ReadLine();
        }
    }
}
