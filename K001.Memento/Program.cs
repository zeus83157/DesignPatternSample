using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K001.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass("Cat");
            myClass.ShowState();
            var caretaker = new CareTaker(myClass.CreateMemento());

            myClass.SetState("Dog");
            myClass.ShowState();

            myClass.SetMemento(caretaker.GetMemento());
            myClass.ShowState();

            Console.ReadLine();

        }
    }
}
