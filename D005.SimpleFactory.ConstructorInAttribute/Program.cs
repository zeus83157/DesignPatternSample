using D005.SimpleFactory.ConstructorInAttribute.Factory;
using D005.SimpleFactory.ConstructorInAttribute.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D005.SimpleFactory.ConstructorInAttribute
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
