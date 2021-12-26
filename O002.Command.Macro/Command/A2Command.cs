using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O002.Command.Macro.Command
{
    public class A2Command : TwoBaseCommand
    {
        public override void Execute()
        {
            _aReceiver.Do2();
        }
    }
}
