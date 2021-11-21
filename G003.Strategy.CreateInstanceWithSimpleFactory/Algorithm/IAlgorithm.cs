using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G003.Strategy.CreateInstanceWithSimpleFactory.Algorithm
{
    public interface IAlgorithm
    {
        decimal Compute(decimal a, decimal b);
    }
}
