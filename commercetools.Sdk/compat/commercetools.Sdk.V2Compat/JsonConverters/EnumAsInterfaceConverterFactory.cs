using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using commercetools.Base.CustomAttributes;
using commercetools.Sdk.Serialization;
using Newtonsoft.Json;

namespace commercetools.Sdk.V2Compat.JsonConverters
{
    public class EnumAsInterfaceConverterFactory : JsonConverterBase
    {
        private readonly ConcurrentDictionary<Type, JsonConverter> _converters;

        public EnumAsInterfaceConverterFactory()
        {
            _converters = new ConcurrentDictionary<Type, JsonConverter>();
        }

        public override List<SerializerType> SerializerTypes =>
            new List<SerializerType>() { SerializerType.Deserialization, SerializerType.Serialization };

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (!_converters.TryGetValue(objectType, out var converter))
            {
                var converterType = typeof(EnumAsInterfaceConverter<>).MakeGenericType(objectType);
                converter = Activator.CreateInstance(converterType) as JsonConverter;
                _converters.TryAdd(objectType, converter);
            }

            return converter?.ReadJson(reader, objectType, existingValue, serializer) ?? throw new JsonException($"Failed to instantiate converter for object type '{objectType.FullName}'");
        }
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsInterface
                   && typeToConvert.IsDefined(typeof(EnumInterfaceCreatorAttribute));
        }
    }
}