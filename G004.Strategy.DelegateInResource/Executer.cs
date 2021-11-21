using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G004.Strategy.DelegateInResource
{
    public class Executer
    {
        private List<decimal> _source;
        public Executer(List<decimal> source)
        {
            _source = source;
        }
        public void Execute(Func<decimal, decimal, decimal> algorithm)
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
                    result = algorithm.Invoke(result, x);
                }
            });
            Console.WriteLine(result);
        }
    }
}
