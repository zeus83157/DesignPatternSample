using I002.State.Interface.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I002.State.Interface
{
    public class Context
    {
        public IState State;
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
