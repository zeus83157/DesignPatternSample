using D006.SimpleFactory.TypeInResource.Factory;
using D006.SimpleFactory.TypeInResource.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D006.SimpleFactory.TypeInResource
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
