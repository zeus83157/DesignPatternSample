using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J004.Prototype.DeepCloneWithDotnet.Prototype
{
    public class MyClass : ICloneable
    {
        public int MyProperty { get; set; }
        public SubClass SubClass { get; set; }

        public object Clone()
        {
            var obj = (MyClass)MemberwiseClone();
            obj.SubClass = (SubClass)SubClass.Clone();
            return obj;
        }
    }
}
