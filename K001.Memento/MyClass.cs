using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K001.Memento
{
    public class MyClass
    {
        private string _state;
        public MyClass(string state)
        {
            _state = state;
        }
        public Memento CreateMemento()
        {
            return new Memento { State = _state };
        }
        public void SetMemento(Memento memento)
        {
            _state = memento.State;
        }
        public void SetState(string state)
        {
            _state = state;
        }
        public void ShowState()
        {
            Console.WriteLine(_state);
        }
    }
}
