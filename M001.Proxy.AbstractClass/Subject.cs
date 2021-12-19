using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M001.Proxy.AbstractClass
{
    public class Subject : BaseSubject
    {
        public override void DoSomething()
        {
            Console.WriteLine("Subject.DoSomething()");
        }
    }
}
