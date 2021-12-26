using O002.Command.Macro.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O002.Command.Macro.Command
{
    public abstract class OneBaseCommand
    {
        protected AReceiver _aReceiver;
        protected BReceiver _bReceiver;
        public OneBaseCommand()
        {
            _aReceiver = new AReceiver();
            _bReceiver = new BReceiver();
        }
        public abstract void Execute();
    }
}
