using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L002.Decorator.WithAdapter.OriginalComponent
{
    public class ComponentAdapter : IComponent
    {
        private Component _component;
        public ComponentAdapter()
        {
            _component = new Component();
        }

        public void Execute()
        {
            _component.Execute();
        }
    }
}
