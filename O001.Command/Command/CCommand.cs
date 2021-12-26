using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O001.Command.Command
{
    public class CCommand : BaseCommand
    {
        public CCommand(Receiver receiver)
            : base(receiver)
        { }
        public override void Execute()
        {
            _receiver.DoC();
        }
    }
}
