using J004.Prototype.DeepCloneWithDotnet.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J004.Prototype.DeepCloneWithDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var o1 = new MyClass
            {
                MyProperty = 5,
                SubClass = new SubClass
                {
                    MyProperty = 1,
                    MyProperty2 = 2
                }
            };

            var o2 = (MyClass)o1.Clone();

            Console.WriteLine(o1.MyProperty == o2.MyProperty);
            Console.WriteLine(o1.SubClass.MyProperty == o2.SubClass.MyProperty);
            Console.WriteLine(o1.SubClass.MyProperty2 == o2.SubClass.MyProperty2);

            Console.WriteLine(ReferenceEquals(o1.SubClass, o2.SubClass));
            Console.WriteLine(ReferenceEquals(o1, o2));

            Console.ReadLine();
        }
    }
}
