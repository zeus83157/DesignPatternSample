using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J003.Prototype.Serialize.Prototype
{
    public class Rectangle : ICloneable
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public object Clone()
        {
            var json = JsonConvert.SerializeObject(this);
            var obj = JsonConvert.DeserializeObject<Rectangle>(json);
            return obj;
        }
    }
}
