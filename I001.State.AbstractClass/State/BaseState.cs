using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I001.State.AbstractClass.State
{
    public abstract class BaseState
    {
        public abstract void Handle(Context _context);
    }
}
