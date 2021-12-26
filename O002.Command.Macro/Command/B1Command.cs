using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O002.Command.Macro.Command
{
    public class B1Command : OneBaseCommand
    {
        public override void Execute()
        {
            _bReceiver.Do1();
        }
    }
}
