using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G002.Strategy.AbstractClass.Algorithm
{
    public class SubtractAlgorithm : BaseAlgorithm
    {
        public override decimal Compute(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
