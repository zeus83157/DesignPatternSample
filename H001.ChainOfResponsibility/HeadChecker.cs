using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H001.ChainOfResponsibility
{
    public class HeadChecker : BaseChecker
    {
        public HeadChecker(BaseChecker checker) : base(checker) 
        { }
        protected override bool InnerCheck(string source)
        {
            return source.Substring(0, 3) == "965";
        }
    }
}
