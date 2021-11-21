using G002.Strategy.AbstractClass.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G002.Strategy.AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var executer = new Executer(new List<decimal> { 0, 1, 2, 3, 4, 5 });
            BaseAlgorithm addAlgorithm = new AddAlgorithm();
            executer.Execute(addAlgorithm);

            BaseAlgorithm subtractAlgorithm = new SubtractAlgorithm();
            executer.Execute(subtractAlgorithm);

            Console.ReadLine();
        }
    }
}
