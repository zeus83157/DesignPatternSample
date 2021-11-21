using I001.State.AbstractClass.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I001.State.AbstractClass
{
    public class Context
    {
        public BaseState State;
        public Context()
        {
            State = new AState();
        }
        public void Request()
        {
            State.Handle(this);
        }
    }
}
