using N001.Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N001.Builder.Director
{
    public abstract class BaseDirector
    {
        protected readonly BaseBuilder _builder;
        public BaseDirector(BaseBuilder builder)
        {
            _builder = builder;
        }
        public abstract void Execute();
    }
}
