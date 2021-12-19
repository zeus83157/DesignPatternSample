using N001.Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N001.Builder.Director
{
    public class DirectorASolution : BaseDirector
    {
        public DirectorASolution(BaseBuilder builder) : base(builder)
        {}

        public override void Execute()
        {
            _builder.BuildStand();
        }
    }
}
