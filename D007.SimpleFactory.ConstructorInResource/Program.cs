using D007.SimpleFactory.ConstructorInResource.Factory;
using D007.SimpleFactory.ConstructorInResource.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D007.SimpleFactory.ConstructorInResource
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
