using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M001.Proxy.AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseSubject subject = new Subject();
            subject.DoSomething();

            Console.WriteLine("-------");

            BaseSubject proxy = new Proxy();
            proxy.DoSomething();

            Console.ReadLine();
        }
    }
}
