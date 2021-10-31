using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C002.RegistryOfSingleton
{
    class Component1
    {
        private int i = 0;
        public void Show()
        {
            Console.WriteLine(i);
            i += 1;
        }
    }

    class Component2
    {
        private int i = 0;
        public void Show()
        {
            Console.WriteLine(i);
            i += 1;
        }
    }
}
