using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F002.TemplateMethod.Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            BasePredicate<int> predicate = new Predicate(source);
            predicate.DoWhere().ToList().ForEach(x => { Console.WriteLine(x); });

            Console.ReadLine();
        }
    }
}
