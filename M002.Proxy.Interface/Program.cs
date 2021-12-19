using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M002.Proxy.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Subject();
            subject.DoSomething();

            Console.WriteLine("-------");

            ISubject proxy = new Proxy();
            proxy.DoSomething();

            Console.ReadLine();
        }
    }
}
