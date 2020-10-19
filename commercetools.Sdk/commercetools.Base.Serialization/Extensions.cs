using System;
using System.Linq;
using System.Text.Json;

namespace commercetools.Base.Serialization
{
    public static class Extensions
    {
        public static string ToSnakeCase(this string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
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
        
        
    }
}
