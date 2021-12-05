using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K002.Memento.GetInternalInfoWithPrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.SubClass = new SubClass 
            { 
                State1 = new Random().Next(),
                State12 = Guid.NewGuid().ToString() 
            };
            myClass.Show();

            myClass.SubClass = new SubClass
            {
                State1 = new Random().Next(),
                State12 = Guid.NewGuid().ToString()
            };
            myClass.Show();



            myClass.Recover();
            myClass.Show();



            Console.ReadLine();
        }
    }
}
