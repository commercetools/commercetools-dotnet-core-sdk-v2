using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.Serialization;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using commercetools.Sdk.Api.Models.ProductTailorings;
using commercetools.Sdk.Api.Serialization.MapperTypeRetrievers;
using Attribute = commercetools.Sdk.Api.Models.Products.Attribute;
using Type = System.Type;

namespace commercetools.Sdk.Api.Serialization.JsonConverters
{
    public class ProductTailoringAttributeConverter : JsonConverter<IProductTailoringAttribute>
    {
        private readonly IMapperTypeRetriever<IProductTailoringAttribute> _mapperTypeRetriever;
        private readonly ProductTailoringAttributeTypeRetriever _attributeTypeRetriever;
        private ISerializerService serializerService;

        public ProductTailoringAttributeConverter(IMapperTypeRetriever<IProductTailoringAttribute> mapperTypeRetriever, ProductTailoringAttributeTypeRetriever attributeTypeRetriever, ISerializerService serializerService)
        {
            this._mapperTypeRetriever = mapperTypeRetriever;
            this._attributeTypeRetriever = attributeTypeRetriever;
            this.serializerService = serializerService;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IProductTailoringAttribute).IsAssignableFrom(typeToConvert);
        }

        public override IProductTailoringAttribute Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonDocument = JsonDocument.ParseValue(ref reader);
            IProductTailoringAttribute attribute;
            var rootElement = jsonDocument.RootElement;
            if (rootElement.ValueKind == JsonValueKind.Object)
            {
                var nameProp = rootElement.GetProperty("name");
                var valueProp = rootElement.GetProperty("value");
                var attributeName = nameProp.GetString();
                attribute = _attributeTypeRetriever.GetAttribute(attributeName, valueProp);
                attribute.Name = attributeName;
                var returnType = attribute is IGenericTypeAttribute attributeValueType ?
                    attributeValueType.GetValueType() :
                    _mapperTypeRetriever.GetTypeForToken(valueProp);
                attribute.Value = valueProp.ToObject(returnType, serializerService); ;
            }
            else
            {
                attribute = new ProductTailoringAttribute();
            }

            return attribute;
        }

        public override void Write(Utf8JsonWriter writer, IProductTailoringAttribute value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("name", value.Name);
            writer.WritePropertyName("value");
            JsonSerializer.Serialize(writer, value.Value, options);
            writer.WriteEndObject();
        }
    }
}