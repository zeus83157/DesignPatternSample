using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J004.Prototype.DeepCloneWithDotnet.Prototype
{
    public class SubClass:ICloneable
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
