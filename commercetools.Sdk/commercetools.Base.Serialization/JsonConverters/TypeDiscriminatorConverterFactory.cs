using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;

namespace commercetools.Base.Serialization.JsonConverters
{
    public class TypeDiscriminatorConverterFactory
        : JsonConverterFactory
    {
        protected JsonNamingPolicy NamingPolicy { get; }

        protected JsonSerializerOptions JsonSerializerOptions { get; }

        protected static ConcurrentDictionary<Type, JsonConverter> Converters = new ConcurrentDictionary<Type, JsonConverter>();

        /// <summary>
        /// Initializes a new <see cref="AbstractClassConverterFactory"/>
        /// </summary>
        /// <param name="namingPolicy">The current <see cref="JsonNamingPolicy"/></param>
        /// <param name="jsonSerializerOptions"></param>
        public TypeDiscriminatorConverterFactory(
            JsonNamingPolicy namingPolicy,
            JsonSerializerOptions jsonSerializerOptions)
        {
            this.JsonSerializerOptions = jsonSerializerOptions;
            this.NamingPolicy = namingPolicy;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return (typeToConvert.IsAbstractClass() || typeToConvert.IsInterface)
                    && typeToConvert.IsDefined(typeof(TypeDiscriminatorAttribute));
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (!Converters.TryGetValue(typeToConvert, out JsonConverter converter))
            {
                var converterType = typeof(TypeDiscriminatorConverter<>).MakeGenericType(typeToConvert);
                converter = (JsonConverter)Activator.CreateInstance(converterType, this.NamingPolicy, JsonSerializerOptions);
                Converters.TryAdd(typeToConvert, converter);
            }
            return converter;
        }

    }
}