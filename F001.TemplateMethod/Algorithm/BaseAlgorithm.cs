using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F001.TemplateMethod.Algorithm
{
    public abstract class BaseAlgorithm
    {
        public void Go()
        {
            Start();
            Execute();
            End();
        }
        protected abstract void Start();
        protected abstract void Execute();
        protected abstract void End();
    }
}
