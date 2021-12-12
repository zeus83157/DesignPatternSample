using L003.Decorator.WithFactory.Decorator;
using L003.Decorator.WithFactory.OriginalComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L003.Decorator.WithFactory
{
    public enum DecoratorType
    {
        Decorator1,
        Decorator2,
    }
    public static class DecoratorFactory
    {
        public static IComponent GetComponentWithDecorators(List<DecoratorType> decoratorTypes)
        {
            IComponent component = new Component();

            foreach (var item in decoratorTypes)
            {
                switch (item)
                {
                    case DecoratorType.Decorator1:
                        component = new Decorator1(component);
                        break;
                    case DecoratorType.Decorator2:
                        component = new Decorator2(component);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return component;
        }
    }
}
