using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Registration;

namespace commercetools.Base.Serialization.JsonConverters
{
    public sealed class DeserializeAsConverterFactory
        : JsonConverterFactory
    {
        private readonly ConcurrentDictionary<Type, JsonConverter> Converters = new ConcurrentDictionary<Type, JsonConverter>();

        public DeserializeAsConverterFactory(
            JsonNamingPolicy namingPolicy,
            JsonSerializerOptions jsonSerializerOptions)
        {
            this.JsonSerializerOptions = jsonSerializerOptions;
            this.NamingPolicy = namingPolicy;
            
            foreach (var type in typeof(DeserializeAsAttribute).GetMarkedTypes())
            {
                CreateConverter(type, jsonSerializerOptions);
            }
        }

        private JsonNamingPolicy NamingPolicy { get; }

        private JsonSerializerOptions JsonSerializerOptions { get; }

        public override bool CanConvert(Type typeToConvert)
        {
            return (typeToConvert.IsAbstractClass() || typeToConvert.IsInterface)
                   && typeToConvert.IsDefined(typeof(DeserializeAsAttribute)) && !typeToConvert.IsDefined(typeof(TypeDiscriminatorAttribute));
        }

        /// <inheritdoc/>
        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (!Converters.TryGetValue(typeToConvert, out JsonConverter converter))
            {
                Type converterType = typeof(DeserializeAsConverter<>).MakeGenericType(typeToConvert);
                converter = (JsonConverter)Activator.CreateInstance(converterType, this.NamingPolicy,
                    JsonSerializerOptions);
                Converters.TryAdd(typeToConvert, converter);
            }

            return converter;
        }
    }
}