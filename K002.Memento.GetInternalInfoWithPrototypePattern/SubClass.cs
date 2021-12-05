using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K002.Memento.GetInternalInfoWithPrototypePattern
{
    public class SubClass :ICloneable
    {
        public int State1 { get; set; }
        public String State12 { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
