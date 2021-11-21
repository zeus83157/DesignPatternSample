using G001.Strategy.Interface.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G001.Strategy.Interface
{
    public class Executer
    {
        private List<decimal> _source;
        public Executer(List<decimal> source)
        {
            _source = source;
        }
        public void Execute(IAlgorithm algorithm)
        {
            bool firstOrNot = true;
            decimal result = 0;
            _source.ForEach(x =>
            {
                if (firstOrNot)
                {
                    result = x;
                    firstOrNot = false;
                }
                else 
                {
                    result = algorithm.Compute(result, x);
                }
            });
            Console.WriteLine(result);
        }
    }
}
