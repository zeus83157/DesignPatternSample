using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L002.Decorator.WithAdapter.OriginalComponent
{
    /// <summary>
    /// can't be modified
    /// </summary>
    public class Component
    {
        public void Execute()
        {
            Console.WriteLine("Component.Execute()");
        }
    }
}
