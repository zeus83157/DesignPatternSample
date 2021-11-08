using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F002.TemplateMethod.Delegate
{
    public class Predicate : BasePredicate<int>
    {
        public Predicate(IEnumerable<int> source) : base(source)
        { }

        protected override bool Invoke(int t)
        {
            return t < 3;
        }
    }
}
