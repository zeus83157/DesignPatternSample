using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K002.Memento.GetInternalInfoWithPrototypePattern
{
    public class MyClass
    {
        private SubClass _subClass;
        public SubClass SubClass
        {
            get
            {
               return _subClass;
            }
            set
            {
                var memento = CreateMemento();
                CareTaker.Push(memento);
                _subClass = value;
            }
        }
        public void Recover()
        {
            var memento = CareTaker.Pop();
            _subClass = memento.SubClass;
        }
        public void Show()
        {
            Console.WriteLine(_subClass.State1);
            Console.WriteLine(_subClass.State12);
        }
        private Memento CreateMemento()
        {
            return _subClass == null ? null : new Memento((SubClass)_subClass.Clone());
        }
    }
}
