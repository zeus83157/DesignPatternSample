using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace M003.Proxy.TransparentProxyWithRealProxy
{
    public class Proxy<T> : RealProxy
        where T : class
    {
        private readonly T _instance;
        public Proxy(T instance)
            :base(typeof(T))
        {
            _instance = instance;
        }
        public override IMessage Invoke(IMessage msg)
        {
            var methodCallMessage = msg as IMethodCallMessage;
            var methodInfo = methodCallMessage.MethodBase as MethodInfo;
            BeforeAction();
            var result = methodInfo.Invoke(_instance, methodCallMessage.InArgs);
            AfterAction();
            return new ReturnMessage(result, null, 0, methodCallMessage.LogicalCallContext, methodCallMessage);
        }
        private void BeforeAction()
        {
            Console.WriteLine("Proxy.BeforeAction()");
        }
        private void AfterAction()
        {
            Console.WriteLine("Proxy.AfterAction()");
        }
    }
}
