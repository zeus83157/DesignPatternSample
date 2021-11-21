using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G001.Strategy.Interface.Algorithm
{
    public class AddAlgorithm : IAlgorithm
    {
        public decimal Compute(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
