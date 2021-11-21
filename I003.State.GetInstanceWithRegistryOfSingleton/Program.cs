using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I003.State.GetInstanceWithRegistryOfSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.ReadLine();
        }
    }
}
