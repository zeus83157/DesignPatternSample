using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C002.RegistryOfSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = Registry.GetInstance<Component1>();
            obj.Show();
            var obj2 = Registry.GetInstance<Component1>();
            obj2.Show();
        }
    }
}
