using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N001.Builder.Builder
{
    public class Gen2Builder : BaseBuilder
    {
        public override void BuildOption()
        {
            Console.WriteLine("Gen2Builder.BuildOption()");
        }

        public override void BuildStand()
        {
            Console.WriteLine("Gen2Builder.BuildStand()");
        }
    }
}
