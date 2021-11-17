using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F002.TemplateMethod.Delegate
{
    static class EnumerableExtension
    {
        public static IEnumerable<T> DoWhere<T>(this IEnumerable<T> source,
                                               Func<T, bool> predicate)
        {
            foreach (T item in source)
            {
                if (predicate.Invoke(item))
                {
                    yield return item;
                }
            }
        }
    }
}
