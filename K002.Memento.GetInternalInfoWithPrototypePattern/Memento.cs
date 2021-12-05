using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K002.Memento.GetInternalInfoWithPrototypePattern
{
    public class Memento
    {
        public SubClass SubClass { get; private set; }

        public Memento(SubClass subClass)
        {
            SubClass = subClass;
        }
    }
}
