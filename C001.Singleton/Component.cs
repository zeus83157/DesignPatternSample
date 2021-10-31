using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C001.Singleton
{
    sealed class Component
    {
        private static object _syncRoot = new object();
        private int i = 0;
        private static Component _componentObj;
        private Component()
        { }
        public static Component ComponentObj
        {
            get
            {
                if (_componentObj == null)
                {
                    lock (_syncRoot)
                    {
                        if (_componentObj == null)
                        {
                            _componentObj = GetInstance();
                        }
                    }
                }
                return _componentObj;
            }
        }
        private static Component GetInstance()
        {
            return new Component();
        }
        public void Show()
        {
            Console.WriteLine(i);
            i += 1;
        }
        public void Clear()
        {
            _componentObj = null;
        }

    }
}
