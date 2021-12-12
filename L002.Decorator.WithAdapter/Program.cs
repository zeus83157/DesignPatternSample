using L002.Decorator.WithAdapter.Decorator;
using L002.Decorator.WithAdapter.OriginalComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L002.Decorator.WithAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Decorator2(new Decorator1(new ComponentAdapter()));
            component.Execute();

            Console.ReadLine();
        }
    }
}
