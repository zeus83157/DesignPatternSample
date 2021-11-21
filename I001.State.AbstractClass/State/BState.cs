using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I001.State.AbstractClass.State
{
    public class BState : BaseState
    {
        public override void Handle(Context _context)
        {
            Console.WriteLine(GetType().Name);
            _context.State = new AState();
        }
    }
}
