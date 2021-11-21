using G002.Strategy.AbstractClass.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G002.Strategy.AbstractClass
{
    public class Executer
    {
        private List<decimal> _source;
        public Executer(List<decimal> source)
        {
            _source = source;
        }
        public void Execute(BaseAlgorithm algorithm)
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
