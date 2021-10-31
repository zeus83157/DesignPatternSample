using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A001.Facade
{
    class MyComponent
    {
        private readonly Component _component;
        public MyComponent()
        {
            _component = new Component();
        }
        public void Process()
        {
            _component.Process1();
            _component.Process2();
            _component.Process3();
        }
    }
}
