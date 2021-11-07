using D008.GenericFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D008.GenericFactory.Factory
{
    public static class ProductFactory
    {
        public static T GetProduct<T>(string assemblyName, string typeName)
        {
            object instance = Activator.CreateInstance(assemblyName, typeName, null).Unwrap();
            return (T)instance;
        }
    }
}
