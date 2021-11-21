using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H001.ChainOfResponsibility
{
    public class DateChecker : BaseChecker
    {
        public DateChecker(BaseChecker checker) : base(checker)
        { }
        protected override bool InnerCheck(string source)
        {
            var yearString = source.Substring(13, 4);
            var monthString = source.Substring(17, 2);
            var dayString = source.Substring(19, 2);
            return DateTime.TryParse($"{yearString}/{monthString}/{dayString}", out DateTime date);
        }
    }
}
