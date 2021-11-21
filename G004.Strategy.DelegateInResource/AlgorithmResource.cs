using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G004.Strategy.DelegateInResource
{
    public static class AlgorithmResource
    {
        private static Dictionary<string, Func<decimal, decimal, decimal>> _resource;
        static AlgorithmResource()
        {
            _resource = new Dictionary<string, Func<decimal, decimal, decimal>>
            {
                { "+", (x, y) => x + y},
                { "-", (x, y) => x - y}
            };
        }
        public static Func<decimal, decimal, decimal> GetAlgorithm(string algorithmType)
        {
            if (!_resource.ContainsKey(algorithmType))
                throw new ArgumentOutOfRangeException();
            else
                return _resource[algorithmType];
        }
    }
}
