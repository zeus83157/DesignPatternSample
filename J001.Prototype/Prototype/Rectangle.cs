using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J001.Prototype.Prototype
{
    public class Rectangle : IPrototype
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public IPrototype Clone()
        {
            return new Rectangle 
            {
                Width = this.Width, 
                Height = this.Height 
            };
        }
    }
}
