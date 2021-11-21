using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H001.ChainOfResponsibility
{
    public class LengthChecker : BaseChecker
    {
        public LengthChecker(BaseChecker checker) : base(checker)
        { }
        protected override bool InnerCheck(string source)
        {
            return source.Length > 7;
        }
    }
}
