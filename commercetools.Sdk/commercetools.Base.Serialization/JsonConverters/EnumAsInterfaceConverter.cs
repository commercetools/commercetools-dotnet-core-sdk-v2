using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

namespace commercetools.Base.Serialization.JsonConverters
{
    public class EnumAsInterfaceConverter<T>
        : JsonConverter<T>
    {
        protected JsonNamingPolicy NamingPolicy { get; }
        
        protected JsonSerializerOptions JsonSerializerOptions { get; }
        
        
        public EnumAsInterfaceConverter(JsonNamingPolicy namingPolicy, JsonSerializerOptions jsonSerializerOptions)
        {
            this.NamingPolicy = namingPolicy;
            this.JsonSerializerOptions = jsonSerializerOptions;
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var attr = typeof(T).GetCustomAttribute<EnumInterfaceCreatorAttribute>();
            if (attr == null)
                throw new NullReferenceException($"Failed to find the required '{nameof(EnumInterfaceCreatorAttribute)}'");
            var attrDelegate = attr.Creator();
            return (T)attrDelegate.DynamicInvoke(reader.GetString());
        }
        
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            if (value is IJsonName withJsonName)
            {
                JsonSerializer.Serialize(writer, withJsonName.JsonName, options);
            }
        }
    }
}