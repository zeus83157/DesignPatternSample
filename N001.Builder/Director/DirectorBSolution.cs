using N001.Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N001.Builder.Director
{
    public class DirectorBSolution : BaseDirector
    {
        public DirectorBSolution(BaseBuilder builder) : base(builder)
        {}

        public override void Execute()
        {
            _builder.BuildStand();
            _builder.BuildOption();
        }
    }
}
