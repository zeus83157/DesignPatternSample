using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K001.Memento
{
    public class CareTaker
    {
        private Memento _memento;
        public CareTaker(Memento memento)
        {
            _memento = memento;
        }
        public Memento GetMemento()
        {
            return _memento;
        }
    }
}
