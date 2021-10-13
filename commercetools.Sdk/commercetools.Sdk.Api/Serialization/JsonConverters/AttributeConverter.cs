using System;
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
        private readonly IMapperTypeRetriever<IAttribute> mapperTypeRetriever;
        private readonly AttributeTypeRetriever attributeTypeRetriever;
        private ISerializerService serializerService;

        public AttributeConverter(IMapperTypeRetriever<IAttribute> mapperTypeRetriever, AttributeTypeRetriever attributeTypeRetriever, ISerializerService serializerService)
        {
            this.mapperTypeRetriever = mapperTypeRetriever;
            this.attributeTypeRetriever = attributeTypeRetriever;
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
                attribute = attributeTypeRetriever.GetAttribute(valueProp);
                attribute.Name = nameProp.GetString();
                var returnType = this.mapperTypeRetriever.GetTypeForToken(valueProp);
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