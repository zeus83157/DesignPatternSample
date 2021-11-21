using G003.Strategy.CreateInstanceWithSimpleFactory.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G003.Strategy.CreateInstanceWithSimpleFactory
{
    public static class AlgorithmFactory
    {
        public static IAlgorithm GetAlgorithm(AlgorithmType algorithmType)
        {
            switch (algorithmType)
            {
                case AlgorithmType.AddAlgorithm:
                    return new AddAlgorithm();
                case AlgorithmType.SubtractAlgorithm:
                    return new SubtractAlgorithm();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
