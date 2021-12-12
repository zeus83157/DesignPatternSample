using L004.Decorator.Extension.Decorator;
using L004.Decorator.Extension.OriginalComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004.Decorator.Extension
{
    public static class ComponentExtension
    {
        public static IComponent Decorate<T>(this IComponent component)
            where T : BaseDecorator
        {
            return Activator.CreateInstance(typeof(T), new object[] { component }) as IComponent;
        }
    }
}
