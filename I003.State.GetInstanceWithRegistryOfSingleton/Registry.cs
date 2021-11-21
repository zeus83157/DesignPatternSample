using I003.State.GetInstanceWithRegistryOfSingleton.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I003.State.GetInstanceWithRegistryOfSingleton
{
    static class Registry
    {
        private static Dictionary<Type, IState> _resource;
        static Registry()
        {
            _resource = new Dictionary<Type, IState> 
            {
                { typeof(AState), new AState()},
                { typeof(BState), new BState()}
            };
        }
        public static IState GetInstance<T>()
            where T : IState, new()
        {
            var type = typeof(T);
            if (!_resource.ContainsKey(type))
                _resource[type] = new T();
            return _resource[type];
        }
    }
}
