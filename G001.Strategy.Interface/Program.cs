using G001.Strategy.Interface.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G001.Strategy.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var executer = new Executer(new List<decimal> { 0, 1, 2, 3, 4, 5 });
            IAlgorithm addAlgorithm = new AddAlgorithm();
            executer.Execute(addAlgorithm);

            IAlgorithm subtractAlgorithm = new SubtractAlgorithm();
            executer.Execute(subtractAlgorithm);

            Console.ReadLine();
        }
    }
}
