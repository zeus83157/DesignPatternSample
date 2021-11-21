using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I002.State.Interface.State
{
    public class BState : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine(GetType().Name);
            context.State = new AState();
        }
    }
}
