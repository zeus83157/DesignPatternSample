using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M003.Proxy.TransparentProxyWithRealProxy
{
    public class Subject : ISubject
    {
        public void DoSomething()
        {
            Console.WriteLine("Subject.DoSomething()");
        }
    }
}
