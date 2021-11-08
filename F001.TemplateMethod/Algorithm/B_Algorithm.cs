using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F001.TemplateMethod.Algorithm
{
    public class B_Algorithm : BaseAlgorithm
    {
        protected override void Start()
        {
            Console.WriteLine($"{GetType().Name}.Start()");
        }

        protected override void Execute()
        {
            Console.WriteLine($"{GetType().Name}.Execute()");
        }

        protected override void End()
        {
            Console.WriteLine($"{GetType().Name}.End()");
        }
    }
}
