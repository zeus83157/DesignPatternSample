using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A001.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Original Operation
            var component = new Component();
            component.Process1();
            component.Process2();
            component.Process3();

            //Facade
            var component2 = new MyComponent();
            component2.Process();
        }
    }
}
