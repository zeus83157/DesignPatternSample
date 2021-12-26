using O002.Command.Macro.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O002.Command.Macro
{
    public class Invoker
    {
        private OneBaseCommand _oneCommand;
        private TwoBaseCommand _twoCommand;
        public void SetCommand(OneBaseCommand oneCommand, TwoBaseCommand twoCommand)
        {
            _oneCommand = oneCommand;
            _twoCommand = twoCommand;
        }
        public void Execute()
        {
            _oneCommand.Execute();
            _twoCommand.Execute();
        }
    }
}
