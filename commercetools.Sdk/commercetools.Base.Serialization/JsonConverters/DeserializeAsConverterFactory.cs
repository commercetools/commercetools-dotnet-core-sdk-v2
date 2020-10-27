using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Base.Registration;
using commercetools.Base.CustomAttributes;

namespace commercetools.Base.Serialization.JsonConverters
{
    public class DeserializeAsConverterFactory
        : JsonConverterFactory
    {
        protected static ConcurrentDictionary<Type, JsonConverter> Converters = new ConcurrentDictionary<Type, JsonConverter>();

        public DeserializeAsConverterFactory(
            JsonNamingPolicy namingPolicy,
            JsonSerializerOptions jsonSerializerOptions)
        {
            this.JsonSerializerOptions = jsonSerializerOptions;
            this.NamingPolicy = namingPolicy;
        }

        protected JsonNamingPolicy NamingPolicy { get; }

        protected JsonSerializerOptions JsonSerializerOptions { get; }

        public override bool CanConvert(Type typeToConvert)
        {
            return (typeToConvert.IsAbstractClass() || typeToConvert.IsInterface)
                   && typeToConvert.IsDefined(typeof(DeserializeAsAttribute));
        }

        /// <inheritdoc/>
        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (!Converters.TryGetValue(typeToConvert, out JsonConverter converter))
            {
                Type converterType = typeof(DeserializeAsConverter<>).MakeGenericType(typeToConvert);
                converter = (JsonConverter) Activator.CreateInstance(converterType, this.NamingPolicy,
                    JsonSerializerOptions);
                Converters.TryAdd(typeToConvert, converter);
            }

            return converter;
        }
    }
}