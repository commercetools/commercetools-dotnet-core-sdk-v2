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

        protected EnumInterfaceCreatorAttribute EnumInterfaceCreator { get; }

        public EnumAsInterfaceConverter(JsonNamingPolicy namingPolicy, JsonSerializerOptions jsonSerializerOptions)
        {
            this.NamingPolicy = namingPolicy;
            this.JsonSerializerOptions = jsonSerializerOptions;

            var enumInterfaceCreatorAttribute = typeof(T).GetCustomAttribute<EnumInterfaceCreatorAttribute>();
            EnumInterfaceCreator = enumInterfaceCreatorAttribute ?? throw new NullReferenceException($"Failed to find the required '{nameof(EnumInterfaceCreatorAttribute)}'");
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var attrDelegate = EnumInterfaceCreator.Creator();
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