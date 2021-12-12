using L004.Decorator.Extension.Decorator;
using L004.Decorator.Extension.OriginalComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004.Decorator.Extension
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
                        component = component.Decorate<Decorator1>();
                        break;
                    case DecoratorType.Decorator2:
                        component = component.Decorate<Decorator2>();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return component;
        }
    }
}
