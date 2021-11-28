using J006.Prototype.Extension.Extension;
using J006.Prototype.Extension.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J006.Prototype.Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            var o1 = new MyClass
            {
                MyProperty = 5
            };

            var o2 = o1.CloneByReflection();
            var o3  = o1.CloneBySerialize();

            Console.WriteLine(o1.MyProperty  == o2.MyProperty);
            Console.WriteLine(o1.MyProperty  == o3.MyProperty);

            Console.WriteLine(ReferenceEquals(o1, o2));
            Console.WriteLine(ReferenceEquals(o1, o3));

            Console.ReadLine();
        }
    }
}
