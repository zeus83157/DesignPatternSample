using N001.Builder.Builder;
using N001.Builder.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N001.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseBuilder gen1Builder = new Gen1Builder();
            BaseBuilder gen2Builder = new Gen2Builder();

            BaseDirector a1 = new DirectorASolution(gen1Builder);
            a1.Execute();
            Console.WriteLine("-------");
            BaseDirector a2 = new DirectorASolution(gen2Builder);
            a2.Execute();
            Console.WriteLine("-------");
            BaseDirector b1 = new DirectorBSolution(gen1Builder);
            b1.Execute();
            Console.WriteLine("-------");
            BaseDirector b2 = new DirectorBSolution(gen2Builder);
            b2.Execute();

            Console.ReadLine();
        }
    }
}
