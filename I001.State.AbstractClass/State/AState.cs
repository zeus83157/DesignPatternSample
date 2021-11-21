using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I001.State.AbstractClass.State
{
    public class AState : BaseState
    {
        public override void Handle(Context context)
        {
            Console.WriteLine(GetType().Name);
            context.State = new BState();
        }
    }
}
