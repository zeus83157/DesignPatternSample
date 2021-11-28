using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace J006.Prototype.Extension.Extension
{
    public static class CloneExtension
    {
        public static T CloneByReflection<T>(this T t)
            where T : class
        {
            var method = typeof(T).GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic);
            return method.Invoke(t, null) as T;
        }

        public static T CloneBySerialize<T>(this T t)
            where T : class
        {
            var json = JsonConvert.SerializeObject(t);
            var obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}
