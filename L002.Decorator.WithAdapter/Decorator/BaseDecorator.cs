using L002.Decorator.WithAdapter.OriginalComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L002.Decorator.WithAdapter.Decorator
{
    public abstract class BaseDecorator : IComponent
    {
        protected IComponent _component;
        public BaseDecorator(IComponent component)
        {
            _component = component;
        }
        public abstract void Execute();
    }
}
