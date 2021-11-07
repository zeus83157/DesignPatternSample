using D008.GenericFactory.Factory;
using D008.GenericFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D008.GenericFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct aProduct = ProductFactory.GetProduct<IProduct>("D008.GenericFactory", "D008.GenericFactory.Product.AProduct");
            aProduct.Show();

            IProduct bProduct = ProductFactory.GetProduct<IProduct>("D008.GenericFactory", "D008.GenericFactory.Product.BProduct");
            bProduct.Show();

            Console.ReadLine();
        }
    }
}
