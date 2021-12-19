using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M002.Proxy.Interface
{
    public class Proxy : ISubject
    {
        private readonly ISubject _subject;
        public Proxy()
        {
            _subject = new Subject();
        }
        public void DoSomething()
        {
            BeforeAction();
            _subject.DoSomething();
            AfterAction();
        }
        private void BeforeAction()
        {
            Console.WriteLine("Proxy.BeforeAction()");
        }
        private void AfterAction()
        {
            Console.WriteLine("Proxy.AfterAction()");
        }
    }
}
