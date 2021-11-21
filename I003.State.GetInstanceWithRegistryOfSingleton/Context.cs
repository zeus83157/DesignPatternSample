using I003.State.GetInstanceWithRegistryOfSingleton.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I003.State.GetInstanceWithRegistryOfSingleton
{
    public class Context
    {
        public IState State;
        public Context()
        {
            State = Registry.GetInstance<AState>();
        }
        public void Request()
        {
            State.Handle(this);
        }
    }
}
