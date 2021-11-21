using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I003.State.GetInstanceWithRegistryOfSingleton.State
{
    public class AState : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine(GetType().Name);
            context.State = Registry.GetInstance<BState>();
        }
    }
}
