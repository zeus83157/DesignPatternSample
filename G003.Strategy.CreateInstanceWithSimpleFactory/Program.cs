using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G003.Strategy.CreateInstanceWithSimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var executer = new Executer(new List<decimal> { 0, 1, 2, 3, 4, 5 });
            var addAlgorithm = AlgorithmFactory.GetAlgorithm(AlgorithmType.AddAlgorithm);
            executer.Execute(addAlgorithm);

            var subtractAlgorithm = AlgorithmFactory.GetAlgorithm(AlgorithmType.SubtractAlgorithm);
            executer.Execute(subtractAlgorithm);

            Console.ReadLine();
        }
    }
}
