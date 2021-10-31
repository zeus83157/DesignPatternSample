using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B001.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IProcessor processor = new ComponentAdapter();
            processor.Process();
        }
    }
}
