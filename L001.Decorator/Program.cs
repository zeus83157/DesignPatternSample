using L001.Decorator.OriginalComponent;
using L001.Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L001.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Decorator2(new Decorator1(new Component()));
            component.Execute();

            Console.ReadLine();
        }
    }
}
