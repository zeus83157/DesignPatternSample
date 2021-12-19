using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M001.Proxy.AbstractClass
{
    public class Proxy : BaseSubject
    {
        private readonly BaseSubject _subject;
        public Proxy()
        {
            _subject = new Subject();
        }
        public override void DoSomething()
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
