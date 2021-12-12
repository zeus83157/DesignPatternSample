using L003.Decorator.WithFactory.OriginalComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L003.Decorator.WithFactory.Decorator
{
    public class Decorator2 : BaseDecorator
    {
        public Decorator2(IComponent component)
            : base(component)
        { }
        public override void Execute()
        {
            _component.Execute();
            SpecialFunction();
        }
        private void SpecialFunction()
        {
            Console.WriteLine("Decorator2.SpecialFunction()");
        }
    }
}
