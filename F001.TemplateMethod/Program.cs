using F001.TemplateMethod.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F001.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseAlgorithm a_Algorithm = new A_Algorithm();
            a_Algorithm.Go();


            BaseAlgorithm b_Algorithm = new B_Algorithm();
            b_Algorithm.Go();

            Console.ReadLine();
        }
    }
}
