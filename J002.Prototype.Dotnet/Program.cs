using J002.Prototype.Dotnet.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J002.Prototype.Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var o1 = new Rectangle
            {
                Width = 5,
                Height = 10
            };

            var o2 = (Rectangle)o1.Clone();


            Console.WriteLine(o1.Width == o2.Width);
            Console.WriteLine(o1.Height == o2.Height);
            Console.WriteLine(ReferenceEquals(o1, o2));

            Console.ReadLine();
        }
    }
}
