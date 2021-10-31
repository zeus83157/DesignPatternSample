using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B001.Adapter
{
    class ComponentAdapter : IProcessor
    {
        private readonly Component _component;
        public ComponentAdapter()
        {
            _component = new Component();
        }
        public void Process()
        {
            _component.DoSomething();
        }
    }
}
