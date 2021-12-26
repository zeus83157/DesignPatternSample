using O001.Command.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O001.Command
{
    public class Invoker
    {
        private BaseCommand _command;
        public void Execute()
        {
            _command.Execute();
        }
        public void SetSommand(BaseCommand command)
        {
            _command = command;
        }
    }
}
