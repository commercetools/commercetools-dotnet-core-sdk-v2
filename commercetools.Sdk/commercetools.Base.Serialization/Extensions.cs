using System;
using System.Linq;
using System.Text.Json;

namespace commercetools.Base.Serialization
{
    public static class Extensions
    {
        public static T ToObject<T>(this JsonElement element, ISerializerService serializerService)
        {
            var json = element.GetRawText();
            return serializerService.Deserialize<T>(json);
        }
        public static object ToObject(this JsonElement element, Type returnType, ISerializerService serializerService)
        {
            var json = element.GetRawText();
            return serializerService.Deserialize(returnType,json);
        }

        public static bool IsAbstractClass(this Type type)
        {
            return type.IsClass && type.IsAbstract;
        }
        
    }
}
