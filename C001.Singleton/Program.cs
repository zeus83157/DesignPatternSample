using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C001.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Component.ComponentObj.Show();
            Component.ComponentObj.Show();
            Component.ComponentObj.Clear();
            Component.ComponentObj.Show();
            Component.ComponentObj.Show();

        }
    }
}
