using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J002.Prototype.Dotnet.Prototype
{
    public class Rectangle : ICloneable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
