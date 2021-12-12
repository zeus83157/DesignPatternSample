using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L004.Decorator.Extension.OriginalComponent
{
    public class Component : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("Component.Execute()");
        }
    }
}
