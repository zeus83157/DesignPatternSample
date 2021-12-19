using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M003.Proxy.TransparentProxyWithRealProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Subject();
            subject.DoSomething();

            Console.WriteLine("-------");

            ISubject proxy = new Proxy<ISubject>(subject).GetTransparentProxy() as ISubject;
            proxy.DoSomething();

            Console.ReadLine();
        }
    }
}
