using O001.Command.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O001.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver();
            var commandA = new ACommand(receiver);
            var commandB = new BCommand(receiver);
            var commandC = new CCommand(receiver);

            var invoker = new Invoker();

            invoker.SetSommand(commandA);
            invoker.Execute();

            invoker.SetSommand(commandB);
            invoker.Execute();

            invoker.SetSommand(commandC);
            invoker.Execute();


            Console.ReadLine();
        }
    }
}
