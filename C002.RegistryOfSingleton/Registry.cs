using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C002.RegistryOfSingleton
{
    static class Registry
    {
        private static Dictionary<Type, object> _Registry = new Dictionary<Type, object>();
        public static T GetInstance<T>()
            where T : new()
        {
            var key = typeof(T);
            if (!_Registry.ContainsKey(key))
            {
                _Registry[key] = new T();
            }
            return (T)_Registry[key];
        }
    }
}
