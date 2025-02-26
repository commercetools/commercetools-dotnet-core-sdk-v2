using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.Registration;
using commercetools.Base.Serialization.JsonConverters;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using commercetools.Sdk.Api.Models.ProductTailorings;
using commercetools.Sdk.Api.Serialization.JsonConverters;
using commercetools.Sdk.Api.Serialization.MapperTypeRetrievers;
using Type = System.Type;

namespace commercetools.Sdk.Api.Serialization
{
    public class SerializerService : IApiSerializerService
    {
        private readonly JsonSerializerOptions _serializerOptions;

        public static readonly JsonNamingPolicy MappedCamelCase = new MappingCamelCaseNamingPolicy();

        public class MappingCamelCaseNamingPolicy : JsonNamingPolicy
        {
            private readonly JsonNamingPolicy _policy = CamelCase;

            private readonly Dictionary<string, string> _fieldMapping = new Dictionary<string, string>
            {
                { "POBox", "pOBox" }
            };

            public override string ConvertName(string name)
            {
                return _fieldMapping.TryGetValue(name, out string mappedName) ? mappedName : _policy.ConvertName(name);
            }
        }

        public SerializerService(
            ITypeRetriever typeRetriever,
            IMapperTypeRetriever<IFieldContainer> customFieldsMapperTypeRetriever,
            IMapperTypeRetriever<IAttribute> attributesMapperTypeRetriever,
            IMapperTypeRetriever<IProductTailoringAttribute> productTailoringAttributesMapperTypeRetriever,
            AttributeTypeRetriever attributeTypeRetriever,
            ProductTailoringAttributeTypeRetriever productTailoringAttributeTypeRetriever)
        {
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = MappedCamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            _serializerOptions.Converters.Add(new MessageDeliveryConverter(this));
            _serializerOptions.Converters.Add(new CustomDateTimeConverter());
            _serializerOptions.Converters.Add(new CustomDateConverter());
            _serializerOptions.Converters.Add(new ProductSearchFacetConverter(this));
            _serializerOptions.Converters.Add(new FieldContainerConverter(customFieldsMapperTypeRetriever, this));
            _serializerOptions.Converters.Add(new AttributeConverter(attributesMapperTypeRetriever, attributeTypeRetriever, this));
            _serializerOptions.Converters.Add(new ProductTailoringAttributeConverter(productTailoringAttributesMapperTypeRetriever, productTailoringAttributeTypeRetriever, this));
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

        public T Deserialize<T>(Stream inputStream)
        {
            return JsonSerializer.Deserialize<T>(inputStream, _serializerOptions);
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
