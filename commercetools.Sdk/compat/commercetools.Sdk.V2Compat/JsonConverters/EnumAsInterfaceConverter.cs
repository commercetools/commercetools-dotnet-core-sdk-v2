using System;
using System.Linq;
using System.Reflection;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace commercetools.Sdk.V2Compat.JsonConverters
{
    public class EnumAsInterfaceConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsInterface
                   && typeToConvert.IsDefined(typeof(EnumInterfaceCreatorAttribute));
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string enumJsonValue = null;
            var jToken = JToken.Load(reader);

            if (jToken.Type == JTokenType.Object)
            {
                if (jToken.Children().First() is JProperty jProperty)
                {
                    enumJsonValue = jProperty.Value.ToString();
                }
            }
            else
            {
                enumJsonValue = jToken.Value<string>();
            }

            var attr = typeof(T).GetCustomAttribute<EnumInterfaceCreatorAttribute>();
            if (attr == null)
                throw new NullReferenceException($"Failed to find the required '{nameof(EnumInterfaceCreatorAttribute)}'");
            if (string.IsNullOrEmpty(enumJsonValue))
                throw new NullReferenceException($"Failed to find the Enum value'");
            var attrDelegate = attr.Creator();
            return (T)attrDelegate.DynamicInvoke(enumJsonValue);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is IJsonName withJsonName)
            {
                writer.WriteValue(withJsonName.JsonName);
            }
        }
    }
}