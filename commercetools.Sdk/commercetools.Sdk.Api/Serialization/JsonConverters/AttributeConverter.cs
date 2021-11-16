using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Api.Models.Products;
using commercetools.Base.Serialization;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using commercetools.Sdk.Api.Serialization.MapperTypeRetrievers;
using Attribute = commercetools.Api.Models.Products.Attribute;
using Type = System.Type;

namespace commercetools.Sdk.Api.Serialization.JsonConverters
{
    public class AttributeConverter : JsonConverter<IAttribute>
    {
        private readonly IMapperTypeRetriever<IAttribute> _mapperTypeRetriever;
        private readonly AttributeTypeRetriever _attributeTypeRetriever;
        private ISerializerService serializerService;

        public AttributeConverter(IMapperTypeRetriever<IAttribute> mapperTypeRetriever, AttributeTypeRetriever attributeTypeRetriever, ISerializerService serializerService)
        {
            this._mapperTypeRetriever = mapperTypeRetriever;
            this._attributeTypeRetriever = attributeTypeRetriever;
            this.serializerService = serializerService;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IAttribute).IsAssignableFrom(typeToConvert);
        }

        public override IAttribute Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonDocument = JsonDocument.ParseValue(ref reader);
            IAttribute attribute;
            var rootElement = jsonDocument.RootElement;
            if (rootElement.ValueKind == JsonValueKind.Object)
            {
                var nameProp = rootElement.GetProperty("name");
                var valueProp = rootElement.GetProperty("value");
                attribute = _attributeTypeRetriever.GetAttribute(valueProp);
                attribute.Name = nameProp.GetString();
                var returnType = attribute is IGenericTypeAttribute attributeValueType ?
                    attributeValueType.GetValueType() :
                    _mapperTypeRetriever.GetTypeForToken(valueProp);
                attribute.Value = valueProp.ToObject(returnType, serializerService); ;
            }
            else
            {
                attribute = new Attribute();
            }

            return attribute;
        }

        public override void Write(Utf8JsonWriter writer, IAttribute value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("name", value.Name);
            writer.WritePropertyName("value");
            JsonSerializer.Serialize(writer, value.Value, options);
            writer.WriteEndObject();
        }
    }
}