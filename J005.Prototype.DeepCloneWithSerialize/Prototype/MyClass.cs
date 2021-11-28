using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J005.Prototype.DeepCloneWithSerialize.Prototype
{
    public class MyClass : ICloneable
    {
        public int MyProperty { get; set; }
        public SubClass SubClass { get; set; }

        public object Clone()
        {
            var json = JsonConvert.SerializeObject(this);
            var obj = JsonConvert.DeserializeObject<MyClass>(json);
            return obj;
        }
    }
}
