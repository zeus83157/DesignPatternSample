using O002.Command.Macro.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O002.Command.Macro
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Invoker();

            invoker.SetCommand(new A1Command(), new A2Command());
            invoker.Execute();

            Console.WriteLine("---");
            invoker.SetCommand(new A1Command(), new B2Command());
            invoker.Execute();

            Console.WriteLine("---");
            invoker.SetCommand(new B1Command(), new B2Command());
            invoker.Execute();

            Console.WriteLine("---");
            invoker.SetCommand(new B1Command(), new A2Command());
            invoker.Execute();

            Console.ReadLine();
        }
    }
}
