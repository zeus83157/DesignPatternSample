using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O001.Command.Command
{
    public abstract class BaseCommand
    {
        protected readonly Receiver _receiver;
        public BaseCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public abstract void Execute();
    }
}
