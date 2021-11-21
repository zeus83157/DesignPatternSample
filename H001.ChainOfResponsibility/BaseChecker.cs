using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H001.ChainOfResponsibility
{
    public abstract class BaseChecker
    {
        private BaseChecker _innerChecker;
        public BaseChecker(BaseChecker checker)
        {
            _innerChecker = checker;
        }
        protected abstract bool InnerCheck(string source);
        public string Check(string source)
        {
            if (InnerCheck(source))
            {
                if (_innerChecker == null)
                    return "Check Success";
                return _innerChecker.Check(source);
            }
            return $"{source} Check Fail In {GetType().Name}";
        }
    }
}
