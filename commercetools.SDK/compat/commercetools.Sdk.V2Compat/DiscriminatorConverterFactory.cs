using System;
using System.Collections.Generic;
using System.Reflection;
using commercetools.Base.Abstractions.CustomAttributes;
using commercetools.Sdk.Registration;
using commercetools.Sdk.Serialization;
using Newtonsoft.Json;

namespace commercetools.Sdk.V2Compat
{
    public class DiscriminatorConverterFactory : JsonConverterBase
    {
        private readonly Dictionary<Type, JsonConverter> _converters;
        private readonly ITypeRetriever _typeRetriever;
        
        public DiscriminatorConverterFactory(ITypeRetriever typeRetriever)
        {
            _converters = new Dictionary<Type, JsonConverter>();
            _typeRetriever = typeRetriever;
        }

        public override List<SerializerType> SerializerTypes => new List<SerializerType>() { SerializerType.Deserialization };
        
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (!_converters.TryGetValue(objectType, out var converter))
            {
                var converterType = typeof(DiscriminatorConverter<>).MakeGenericType(objectType);
                converter = Activator.CreateInstance(converterType, _typeRetriever) as JsonConverter;
                _converters.Add(objectType, converter);
            }
            
            return converter?.ReadJson(reader, objectType, existingValue, serializer) ?? throw new JsonException($"Failed to instantiate converter for object type '{objectType.FullName}'");
        }

        /// <inheritdoc/>
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsClass && typeToConvert.IsAbstract && typeToConvert.IsDefined(typeof(DiscriminatorAttribute));
        }
    }
}