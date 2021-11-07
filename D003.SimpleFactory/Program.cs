using D003.SimpleFactory.Factory;
using D003.SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D003.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct aProduct = ProductFactory.GetProduct(ProductType.AProduct);
            aProduct.Show();

            IProduct bProduct = ProductFactory.GetProduct(ProductType.BProduct);
            bProduct.Show();

            Console.ReadLine();
        }
    }
}
