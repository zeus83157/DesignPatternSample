using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N001.Builder.Builder
{
    public class Gen1Builder : BaseBuilder
    {
        public override void BuildOption()
        {
            Console.WriteLine("Gen1Builder.BuildOption()");
        }

        public override void BuildStand()
        {
            Console.WriteLine("Gen1Builder.BuildStand()");
        }
    }
}
