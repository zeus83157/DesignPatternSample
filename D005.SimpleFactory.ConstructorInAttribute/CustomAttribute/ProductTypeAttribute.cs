using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace D005.SimpleFactory.ConstructorInAttribute.CustomAttribute
{
    internal class ProductTypeAttribute : Attribute
    {
        internal Func<object> ConstructorDelegate { get; }
        public ProductTypeAttribute(Type type)
        {
            var ctor = type.GetConstructor(new Type[] { });
            var method = new DynamicMethod($"CreateInstance<>{type.Name}", typeof(object), null, type);
            ILGenerator generator = method.GetILGenerator();
            generator.Emit(OpCodes.Newobj, ctor);
            generator.Emit(OpCodes.Ret);
            ConstructorDelegate = method.CreateDelegate(typeof(Func<object>)) as Func<object>;
        }
    }
}
