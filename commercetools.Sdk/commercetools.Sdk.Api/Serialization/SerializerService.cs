using System.Text.Json;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.Types;
using commercetools.Base.Registration;
using commercetools.Base.Serialization.JsonConverters;
using commercetools.Base.Serialization;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using commercetools.Sdk.Api.Serialization.JsonConverters;
using commercetools.Sdk.Api.Serialization.MapperTypeRetrievers;
using Type = System.Type;

namespace commercetools.Sdk.Api.Serialization
{
    public class SerializerService : ISerializerService
    {
        private readonly JsonSerializerOptions _serializerOptions;

        public SerializerService(
            ITypeRetriever typeRetriever,
            IMapperTypeRetriever<IFieldContainer> customFieldsMapperTypeRetriever,
            IMapperTypeRetriever<IAttribute> attributesMapperTypeRetriever,
            AttributeTypeRetriever attributeTypeRetriever)
        {
            _serializerOptions = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            _serializerOptions.Converters.Add(new CustomDateTimeConverter());
            _serializerOptions.Converters.Add(new FieldContainerConverter(customFieldsMapperTypeRetriever, this));
            _serializerOptions.Converters.Add(new AttributeConverter(attributesMapperTypeRetriever, attributeTypeRetriever, this));
            _serializerOptions.Converters.Add(new DeserializeAsConverterFactory(
                _serializerOptions.PropertyNamingPolicy, _serializerOptions));
            _serializerOptions.Converters.Add(new EnumAsInterfaceConverterFactory(
                _serializerOptions.PropertyNamingPolicy, _serializerOptions));
            _serializerOptions.Converters.Add(new TypeDiscriminatorConverterFactory(
                _serializerOptions.PropertyNamingPolicy, _serializerOptions));
        }

        public T Deserialize<T>(string input)
        {
            return JsonSerializer.Deserialize<T>(input, _serializerOptions);
        }

        public object Deserialize(Type returnType, string input)
        {
            return JsonSerializer.Deserialize(input, returnType, _serializerOptions);
        }

        public string Serialize<T>(T input)
        {
            return JsonSerializer.Serialize<T>(input, _serializerOptions);
        }
    }
}
