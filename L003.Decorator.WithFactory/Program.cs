using L003.Decorator.WithFactory.OriginalComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L003.Decorator.WithFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var decorators = new List<DecoratorType> { DecoratorType.Decorator1, DecoratorType.Decorator2 };
            IComponent component = DecoratorFactory.GetComponentWithDecorators(decorators);
            component.Execute();

            Console.ReadLine();
        }
    }
}
