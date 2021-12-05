using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K002.Memento.GetInternalInfoWithPrototypePattern
{
    public static class CareTaker
    {
        private static Stack<Memento> _mementos = new Stack<Memento>();
        public static void Push(Memento subClass)
        {
            _mementos.Push(subClass);
        }
        public static Memento Pop()
        {
            return _mementos.Pop();
        }
    }
}
