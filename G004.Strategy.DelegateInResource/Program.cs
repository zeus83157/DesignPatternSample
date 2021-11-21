using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G004.Strategy.DelegateInResource
{
    class Program
    {
        static void Main(string[] args)
        {
            var executer = new Executer(new List<decimal> { 0, 1, 2, 3, 4, 5 });
            var addAlgorithm = AlgorithmResource.GetAlgorithm("+");
            executer.Execute(addAlgorithm);

            var subtractAlgorithm = AlgorithmResource.GetAlgorithm("-");
            executer.Execute(subtractAlgorithm);

            Console.ReadLine();
        }
    }
}
