using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F002.TemplateMethod.Delegate
{
    public abstract class BasePredicate<T>
    {
        private IEnumerable<T> _Source;

        public BasePredicate(IEnumerable<T> souece)
        {
            _Source = souece;
        }

        public IEnumerable<T> DoWhere()
        {
            foreach (var item in _Source)
            {
                if (Invoke(item))
                    yield return item;
            }
        }

        protected abstract bool Invoke(T t);
    }
}
